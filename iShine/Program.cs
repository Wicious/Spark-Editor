using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iShine
{
    static class Program
    {
        public static EncodingInfo DefaultEncodingInfo
        {
            get
            {
                return Encoding.GetEncodings().First(ei => ei.Name == Properties.Settings.Default.Encoding);
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
