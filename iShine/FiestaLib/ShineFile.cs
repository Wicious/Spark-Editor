using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace iShine.FiestaLib
{
    public class ShineFile : DataSet, IFile
    {
        private List<string> lines = new List<string>();

        public string FilePath { get; private set; }
        public bool IsSaved { get; set; }
        public int SelectedIndex { get; set; }

        private StreamReader reader { get; set; }
        private StreamWriter writer { get; set; }

        string IFile.FilePath
        {
            get
            {
                return FilePath;
            }
        }

        public ShineFile(string filePath)
        {
            FilePath = filePath;
            DataSetName = Path.GetFileName(FilePath);
            IsSaved = true;
        }

        public async Task Load(IProgress<int> progress)
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException("The specified file does not exist.");

            using (reader = new StreamReader(File.OpenRead(FilePath)))
            {
                lines = File.ReadAllLines(FilePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string str = lines[i];

                    if (String.IsNullOrWhiteSpace(str)) continue;

                    str = str.Trim();
                    str = Regex.Replace(str, @"\t+", "\t");

                    if (str.StartsWith(";"))
                    {
                        var comment = str.Split(';')[1];

                        if (String.IsNullOrWhiteSpace(comment))
                            continue;
                    }

                    else if (str.ToLower().StartsWith("#table"))
                    {
                        Tables.Add(new ShineTable(str.Split('\t')[1]));
                    }

                    else if (str.ToLower().StartsWith("#columntype"))
                    {
                        if (Tables.Count == 0)
                            throw new Exception("There is not an existing table to add the column types to.");

                        ((ShineTable)Tables[Tables.Count - 1]).ColumnTypes
                            .AddRange(str.Split('\t')
                                .Skip(1));
                    }

                    else if (str.ToLower().StartsWith("#columnname"))
                    {
                        if (Tables.Count == 0)
                            throw new Exception("There is not an existing table to add the column names to.");

                        List<string> columnNames = str.Split('\t').Skip(1).ToList();

                        for (int x = 0; x < columnNames.Count(); x++)
                        {
                            Tables[Tables.Count - 1].Columns.Add(columnNames[x]);
                        }
                    }

                    else if (str.ToLower().StartsWith("#recordin"))
                    {
                        if (Tables.Count == 0)
                            throw new Exception("There is not an existing table to add the rows to.");

                        List<string> values = str.Split('\t').Skip(1).ToList();
                        string table = values[0];

                        var row = Tables.Cast<DataTable>().AsEnumerable().Where(x => x.Table.TableName == table).First().Table.NewRow();
                        values.RemoveAt(0);
                        row.ItemArray = values.ToArray<string>();

                        Tables.Cast<DataTable>().AsEnumerable().Where(x => x.Table.TableName == table).First().Table.Rows.Add(row);
                    }

                    else if (str.ToLower().StartsWith("#record"))
                    {
                        if (Tables.Count == 0)
                            throw new Exception("There is not an existing table to add the rows to.");

                        string[] values = str.Split('\t').Skip(1).ToArray();

                        var row = Tables[Tables.Count - 1].NewRow();
                        row.ItemArray = values;

                        Tables[Tables.Count - 1].Rows.Add(row);
                    }

                    else if (str.Contains(";"))
                    {
                        str = str.Replace(";", "");
                        str = str.Trim();
                    }

                }
            }
        }

        public async Task Save(string filePath, IProgress<int> progress)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("#ignore\t\\o042");
                writer.WriteLine("#exchange\t#\t\\x20");
                writer.WriteLine("#delimiter\t\\x20");

                foreach (ShineTable table in Tables)
                {
                    writer.WriteLine();

                    writer.WriteLine("#Table\t" + table.TableName);
                    writer.WriteLine("#ColumnType\t" + string.Join("\t", table.ColumnTypes));
                    writer.Write("#ColumnName");

                    foreach (DataColumn column in table.Columns)
                    {
                        writer.Write("\t" + column.ColumnName);
                    }

                    writer.WriteLine();

                    foreach (DataRow row in table.Rows)
                    {
                        writer.WriteLine("#Record\t" + string.Join("\t", row.ItemArray));
                    }

                }
                writer.WriteLine("#End");
            }
        }
    }

    public class ShineTable : DataTable
    {
        public List<string> ColumnTypes = new List<string>();

        public int ColumnCount { get { return Columns.Count; } }
        public int RowCount { get { return Rows.Count; } }

        public ShineTable(string TableName)
        {
            this.TableName = TableName;
        }
    }
}
