using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkEditor.Forms.NewFile
{
    public partial class frmQuestDependencies : Form
    {
        public string MobInfoPath { get; private set; }
        public string ItemInfoPath { get; private set; }

        public frmQuestDependencies()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(File.Exists(txtItemInfo.Text) && File.Exists(txtMobInfo.Text))
            {
                MobInfoPath = txtMobInfo.Text;
                ItemInfoPath = txtItemInfo.Text;
            }
        }

        private void btnBrowseItemInfo_Click(object sender, EventArgs e)
        {
            using (var frm = new OpenFileDialog())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.Title = "Open ItemInfo";
                    frm.Filter = "SHN File|*.shn";
                    txtItemInfo.Text = frm.FileName;
                }
            }
        }

        private void btnBrowseMobInfo_Click(object sender, EventArgs e)
        {
            using (var frm = new OpenFileDialog())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.Title = "Open MobInfo";
                    frm.Filter = "SHN File|*.shn";
                    txtMobInfo.Text = frm.FileName;
                }
            }
        }
    }
}
