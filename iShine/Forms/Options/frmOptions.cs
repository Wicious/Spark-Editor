using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iShine.Forms.Options
{
    public partial class frmOptions : Form
    {
        private pEncryption pEncryption = new pEncryption();
        private pEncoding pEncoding = new pEncoding();
        private pCopyPaste pCopyPaste = new pCopyPaste();

        public frmOptions()
        {
            InitializeComponent();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOptions.SelectedItem == null) return;

            pOptionPage.Controls.Clear();

            switch (lbOptions.SelectedItem.ToString())
            {
                case "Encoding":
                    pEncoding.Dock = DockStyle.Fill;
                    pOptionPage.Controls.Add(pEncoding);
                    break;

                case "Default Encryption":
                    pEncryption.Dock = DockStyle.Fill;
                    pOptionPage.Controls.Add(pEncryption);
                    break;

                case "Copy & Paste":
                    pCopyPaste.Dock = DockStyle.Fill;
                    pOptionPage.Controls.Add(pCopyPaste);
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save encoding
            Properties.Settings.Default.Encoding = pEncoding.Encoding.Name;

            //save encryption
            Properties.Settings.Default.Xor00 = pEncryption.Xor00;
            Properties.Settings.Default.Xor01 = pEncryption.Xor01;
            Properties.Settings.Default.Xor02 = pEncryption.Xor02;
            Properties.Settings.Default.Xor03 = pEncryption.Xor03;

            Cryptography.Crypter.DefaultEncryption[0] = pEncryption.Xor00;
            Cryptography.Crypter.DefaultEncryption[1] = pEncryption.Xor01;
            Cryptography.Crypter.DefaultEncryption[2] = pEncryption.Xor02;
            Cryptography.Crypter.DefaultEncryption[3] = pEncryption.Xor03;

            //save copy&paste settings
            Properties.Settings.Default.PasteDefaultValue = pCopyPaste.DefaultStringValue;
            Properties.Settings.Default.GenerateNewID = pCopyPaste.GenerateNewID;
            Properties.Settings.Default.GenerateOnlyIfSameFile = pCopyPaste.NeedsSameFile;
            Properties.Settings.Default.DefaultNumericValue = pCopyPaste.DefaultNumericValue;

            Properties.Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
