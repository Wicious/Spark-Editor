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
using iShine.FiestaLib.Quest;

namespace iShine.Controls
{
    public partial class QuestPanel : UserControl
    {
        public QuestFile file;
        public Quest SelectedQuest { get; private set; }
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

            loadQuest(0);
        }

        private void lbQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadQuest(lbQuests.SelectedIndex);
        }

        private void loadQuest(int selectedIndex)
        {
            SelectedQuest = (Quest)lbQuests.Items[selectedIndex];

            pgQuestProperties.SelectedObject = SelectedQuest;
            lblQuestName.Text = SelectedQuest.TitleString;

            txtScriptStart.Text = SelectedQuest.StartScript;
            txtScriptInProgress.Text = SelectedQuest.InProgressScript;
            txtScriptFinish.Text = SelectedQuest.FinishScript;

            lblMob00.Text = SelectedQuest.Mobs[0].IsEnabled ? SelectedQuest.Mobs[0].KillAmount + " " + SelectedQuest.Mobs[0].Name : "-";
            lblMob01.Text = SelectedQuest.Mobs[1].IsEnabled ? SelectedQuest.Mobs[1].KillAmount + " " + SelectedQuest.Mobs[1].Name : "-";
            lblMob02.Text = SelectedQuest.Mobs[2].IsEnabled ? SelectedQuest.Mobs[2].KillAmount + " " + SelectedQuest.Mobs[2].Name : "-";
            lblMob03.Text = SelectedQuest.Mobs[3].IsEnabled ? SelectedQuest.Mobs[3].KillAmount + " " + SelectedQuest.Mobs[3].Name : "-";
        }

        private void QuestPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
