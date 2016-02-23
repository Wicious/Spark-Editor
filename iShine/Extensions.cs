using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iShine
{
    public static class Extensions
    {
        private static byte[] Buffer = new byte[0x100];

        public static string ReadString(this BinaryReader reader, int length)
        {
            var str = Encoding.Default.GetString(reader.ReadBytes(length));
            str = str.Trim((char)0x00);

            return str;
        }

        public static void WriteString(this BinaryWriter writer, string str, int length)
        {
            // Replace \n with 0x0A which is the new line character.
            str = str.Replace("\\n", Environment.NewLine);

            // If there is no defined length
            if (length == -1)
            {
                writer.Write(Encoding.Default.GetBytes(str));
                writer.Write((byte)0);
                return;
            }

            writer.Write(Encoding.Default.GetBytes(str));

            // Fill rest with zeros
            for (int i = str.Length; i < length; i++)
            {
                writer.Write((byte)0x00);
            }
        }

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        [DebuggerStepThrough]
        public static String ReadStringUntilZero(this BinaryReader reader)
        {
            int count = 0;
            for (byte i = reader.ReadByte(); i != 0; i = reader.ReadByte())
            {
                Buffer[count++] = i;
                if (count >= 0x100)
                    break;
            }
            string str = Encoding.Default.GetString(Buffer, 0, count);
            if (count == 0x100) { str = str + reader.ReadStringUntilZero(); }
            str = str.Replace(char.ConvertFromUtf32(10), "\\n");
            return str;
        }
    }
}
