using SparkEditor.FiestaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkEditor
{
    static class Program
    {
        // Put all files in here for access.
        public static List<IFile> LoadedFiles = new List<IFile>();

        public static EncodingInfo DefaultEncodingInfo
        {
            get
            {
                return Encoding.GetEncodings().First(ei => ei.Name.ToLower() == Properties.Settings.Default.Encoding.ToLower());
            }
            set
            {
                DefaultEncoding = value.GetEncoding();
            }
        }

        public static Encoding DefaultEncoding = DefaultEncodingInfo.GetEncoding();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
