using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iShine.Cryptography;
using System.Windows.Forms;
using System.Reflection;

namespace iShine.ShineFile
{
    public class SHNFile : DataTable, IFile
    {
        public byte[] BaseHeader { get; private set; }
        public uint DataHeader { get; private set; }

        public int ColumnCount { get { return Columns.Count; } }
        public int RowCount { get { return Rows.Count; } }
        public string FilePath { get; private set; }

        private BinaryReader reader { get; set; }
        private BinaryWriter writer { get; set; }
        private byte[] fileData { get; set; }
        private uint recordCount { get; set; }
        private uint columnCount { get; set; }
        private uint defaultRecordLength { get; set; }

        public SHNFile(string filePath)
        {
            FilePath = filePath;
            TableName = Path.GetFileName(FilePath);
        }

        /// <summary>
        /// Loads the file. The progress parameter is a way for us
        /// to report progress to the calling thread.
        /// </summary>
        /// <param name="progress"></param>
        public async Task Load(IProgress<int> progress)
        {
            using (reader = new BinaryReader(File.OpenRead(FilePath)))
            {
                writer = new BinaryWriter(File.OpenWrite(FilePath + ".clear"));

                // Save file's header.
                BaseHeader = reader.ReadBytes(0x20);

                // Read the bytes into a byte array for decrypting.
                fileData = reader.ReadBytes(reader.ReadInt32() - 0x24);

                // Decrypt data
                Crypter.Crypt(fileData, 0, fileData.Length);

                // Re-initalize the reader with the unciphered data.
                reader = new BinaryReader(new MemoryStream(fileData));

                DataHeader = reader.ReadUInt32();
                recordCount = reader.ReadUInt32();
                defaultRecordLength = reader.ReadUInt32();
                columnCount = reader.ReadUInt32();

                // Read columns
                var unknownColumnCount = 0;
                var recordLength = 2;
                for (int i = 0; i < columnCount; i++)
                {
                    var columnName = reader.ReadString(0x30);
                    var columnType = reader.ReadUInt32();
                    var columnLength = reader.ReadInt32();

                    // If column name is empty, supply it with a UnkCol name.
                    if (columnName.Length == 0 || string.IsNullOrWhiteSpace(columnName))
                    {
                        columnName = "UnkCol" + unknownColumnCount.ToString("00");
                        unknownColumnCount++;
                    }

                    var shnType = getSHNTypeFromID(columnType);
                    var shnColumn = new SHNColumn(columnName, columnLength, shnType, getTypeFromID(columnType));

                    Columns.Add(shnColumn);
                    recordLength += columnLength;
                }

                if (recordLength != defaultRecordLength)
                {
                    throw new Exception("Record length is invalid!");
                }
                writer.Write(fileData);
                writer.Close();

                readRows(new Progress<int>(p => progress.Report(p)));
            }
        }

        private SHNType getSHNTypeFromID(uint columnType)
        {
            var type = typeof(SHNType);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(SHNTypeAttribute)) as SHNTypeAttribute;
                if (attribute != null)
                {
                    if (attribute.Values.Contains(columnType))
                        return (SHNType)field.GetValue(null);
                }

            }

            return SHNType.Default;
        }

        private void readRows(IProgress<int> progress)
        {
            int percent = 0;
            for (uint i = 0; i < recordCount; i++)
            {
                var row = NewRow();

                reader.ReadUInt16();
                for (int x = 0; x < ColumnCount; x++)
                {
                    var type = Columns[x].DataType;

                    if (((SHNColumn)Columns[x]).SHNType == SHNType.UnknownLengthString)
                        row[x] = reader.ReadStringUntilZero();

                    else if (type == typeof(byte))
                        row[x] = reader.ReadByte();

                    else if (type == typeof(ushort))
                        row[x] = reader.ReadUInt16();

                    else if (type == typeof(string))
                        row[x] = reader.ReadString(((SHNColumn)Columns[x]).Length);

                    else if (type == typeof(uint))
                        row[x] = reader.ReadUInt32();

                    else if (type == typeof(Single))
                        row[x] = reader.ReadSingle();

                    else if (type == typeof(short))
                        row[x] = reader.ReadInt16();

                    else if (type == typeof(sbyte))
                        row[x] = reader.ReadSByte();

                    else if (type == typeof(int))
                        row[x] = reader.ReadInt32();

                    else
                        row[x] = reader.ReadInt32();
                }
                Rows.Add(row);

                percent = Convert.ToInt32(((double)i / (double)recordCount) * 100);
                progress.Report(percent);
            }
        }

        /// <summary>
        /// Saves the file. The progress parameter is a way for us
        /// to report progress to the calling thread.
        /// </summary>
        /// <param name="progress"></param>
        public async Task Save(IProgress<int> progress)
        {
            var stream = new MemoryStream();
            writer = new BinaryWriter(stream);

            writer.Write(DataHeader);
            writer.Write(RowCount);
            writer.Write(defaultRecordLength);
            writer.Write(ColumnCount);

            foreach (SHNColumn col in Columns)
            {
                if (col.ColumnName.Contains("UnkCol"))
                {
                    writer.Write(new byte[0x30]);
                }
                else
                {
                    writer.WriteString(col.ColumnName, 0x30);
                }

                writer.Write(getIDFromType(col.DataType));
                writer.Write(col.Length);
            }

            writeRows(new Progress<int>(p => progress.Report(p)));

            stream.WriteTo(File.OpenWrite("filetest.save"));
        }

        private void writeRows(IProgress<int> prog)
        {
            foreach (DataRow row in Rows)
            {
                writer.Write((ushort)0x00);

                foreach (SHNColumn col in Columns)
                {
                    dynamic value = row[col];

                    if (value == null)
                        value = "0";

                    var type = col.DataType;

                    if (type == typeof(string))
                        writer.WriteString((string)value, col.Length);

                    writer.Write(value);
                }
            }
        }

        private Type getTypeFromID(uint columnType)
        {
            foreach (var mem in typeof(SHNType).GetMembers())
            {
                var attributes = mem.GetCustomAttributes(typeof(SHNTypeAttribute), false);
                foreach (var attr in attributes)
                {
                    if (((SHNTypeAttribute)attr).Values.Contains(columnType))
                    {
                        return ((SHNTypeAttribute)attr).Type;
                    }
                }
            }

            return typeof(object);
        }

        private uint getIDFromType(Type columnType)
        {
            foreach (var mem in typeof(SHNType).GetMembers())
            {
                var attributes = mem.GetCustomAttributes(typeof(SHNTypeAttribute), false);
                foreach (var attr in attributes)
                {
                    if (((SHNTypeAttribute)attr).Type == columnType)
                    {
                        return ((SHNTypeAttribute)attr).Values[0];
                    }
                }
            }

            return 0x09;
        }
    }
}

public class SHNColumn : DataColumn
{
    public int Length { get; set; }
    public SHNType SHNType { get; set; }

    public SHNColumn(string name, int length, SHNType shnType, Type dataType)
        : base(name, dataType)
    {
        Length = length;
        SHNType = shnType;
    }
}

public enum SHNType
{

    [SHNType(typeof(string), 0x09, 0x18)]
    String,

    [SHNType(typeof(byte), 0x01, 0x0C, 0x10)]
    Byte,

    [SHNType(typeof(ushort), 0x02)]
    UShort,

    [SHNType(typeof(string), 0x1A)]
    UnknownLengthString,

    [SHNType(typeof(uint), 0x03, 0x0B, 0x12, 0x1B)]
    UInt,

    [SHNType(typeof(Single), 0x05)]
    Single,

    [SHNType(typeof(short), 0x15, 0x0D)]
    Short,

    [SHNType(typeof(sbyte), 0x14)]
    SByte,

    [SHNType(typeof(int), 0x16)]
    Int,

    [SHNType(typeof(object))]
    Default
}



