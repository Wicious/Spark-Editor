using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iShine.Forms.Options
{
    public partial class pCopyPaste : UserControl
    {
        public bool NeedsSameFile { get { return cbOnlyIfSameFile.Checked; } }
        public bool GenerateNewID { get { return cbGenerateValue.Checked; } }
        public string DefaultStringValue { get { return txtDefaultStringValue.Text; } }
        public decimal DefaultNumericValue { get { return nudDefaultNumericValue.Value; } }

        public pCopyPaste()
        {
            InitializeComponent();

            txtDefaultStringValue.Text = Properties.Settings.Default.PasteDefaultValue;
            cbGenerateValue.Checked = Properties.Settings.Default.GenerateNewID;
            cbOnlyIfSameFile.Checked = Properties.Settings.Default.GenerateOnlyIfSameFile;
            nudDefaultNumericValue.Value = Properties.Settings.Default.DefaultNumericValue;
        }

        private void cbGenerateValue_CheckedChanged(object sender, EventArgs e)
        {
            cbOnlyIfSameFile.Enabled = cbGenerateValue.Checked;
        }
    }
}
