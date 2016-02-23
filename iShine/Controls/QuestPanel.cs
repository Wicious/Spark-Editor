using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iShine.FiestaLib;

namespace iShine.Controls
{
    public partial class QuestPanel : UserControl
    {
        public QuestFile file;
        public QuestPanel(QuestFile file)
        {
            InitializeComponent();

            this.file = file;
            init();
        }

        private async void init()
        {
            await Task.Run(() => file.Load(new Progress<int>()));

            lbQuests.DataSource = file.Quests;
            lbQuests.DisplayMember = "TitleString";

            lbQuests.SelectedIndexChanged += lbQuests_SelectedIndexChanged;
        }

        private void lbQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            var quest = (Quest)lbQuests.Items[lbQuests.SelectedIndex];
            pgQuestProperties.SelectedObject = quest;
        }
    }
}
