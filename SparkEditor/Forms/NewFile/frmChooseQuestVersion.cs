using SparkEditor.FiestaLib.Quest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkEditor.Forms.NewFile
{
    public partial class frmChooseQuestVersion : Form
    {
        private QuestFile file;

        public frmChooseQuestVersion(QuestFile file)
        {
            InitializeComponent();
            this.file = file;

            cbQuestVersion.Items.AddRange(new string[] { "NA 2011", "CN 2012", "EU 2015" });
            cbQuestVersion.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            file.QuestFileVersion = QuestFileVersion.NA11;
        }
    }
}
