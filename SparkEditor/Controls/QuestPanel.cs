using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SparkEditor.FiestaLib;
using SparkEditor.FiestaLib.Quest;
using System.Text.RegularExpressions;
using System.Reflection;

namespace SparkEditor.Controls
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

            txtDescription.Text = file.QuestStrings[SelectedQuest.Description];
            nudDescription.Value = SelectedQuest.Description;
        }

        private void QuestPanel_Load(object sender, EventArgs e)
        {

        }

        private void nudDescription_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedQuest.Description = Convert.ToUInt16(nudDescription.Value);
                txtDescription.Text = file.QuestStrings[SelectedQuest.Description];
            }
            catch (Exception ex)
            {
                txtDescription.Text = "-";
            }
        }

        private void btnSaveScripts_Click(object sender, EventArgs e)
        {
            SelectedQuest.StartScript = txtScriptStart.Text;
            SelectedQuest.InProgressScript = txtScriptInProgress.Text;
            SelectedQuest.FinishScript = txtScriptFinish.Text;
        }

        private void btnQuestSearch_Click(object sender, EventArgs e)
        {
            setQuestFilter(txtQuestSearch.Text);
        }

        private void setQuestFilter(string text)
        {
            try
            {
                if (text == "")
                {
                    lbQuests.DataSource = file.Quests;
                    return;
                }

                text = Regex.Replace(text, @"\s+", " ");
                var args = text.Split(' ');

                var property = args[0].Trim().ToLower();
                var compareOperator = args[1].Trim().ToLower();
                var value = args[2].Trim().ToLower();
                SearchType type = SearchType.Equals;

                switch (compareOperator)
                {
                    case "=":
                        type = SearchType.Equals;
                        break;

                    case "%=":
                        type = SearchType.StartsWith;
                        break;

                    case "=%":
                        type = SearchType.EndsWith;
                        break;

                    case "%=%":
                        type = SearchType.Contains;
                        break;

                    case ">":
                        type = SearchType.MoreThan;
                        break;

                    case "<":
                        type = SearchType.LessThan;
                        break;
                }

                setFilter(type, property, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setFilter(SearchType type, string property, string value)
        {
            List<Quest> filteredQuests = new List<Quest>();
            value = value.ToLower();

            switch (property)
            {
                case "id":
                    if (type == SearchType.Equals)
                        filteredQuests.AddRange(file.Quests.Where(x => x.ID == Convert.ToUInt16(value)));

                    else if (type == SearchType.StartsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.ID.ToString().ToLower().StartsWith(value)));

                    else if (type == SearchType.EndsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.ID.ToString().ToLower().EndsWith(value)));

                    else if (type == SearchType.MoreThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.ID > Convert.ToUInt16(value)));

                    else if (type == SearchType.LessThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.ID < Convert.ToUInt16(value)));
                    break;

                case "haslevelrequirement":
                    filteredQuests.AddRange(file.Quests.Where(x => x.HasLevelRequirement == Convert.ToBoolean(value)));
                    break;

                case "islevelingquest":
                    filteredQuests.AddRange(file.Quests.Where(x => x.IsLevelQuest == Convert.ToBoolean(value)));
                    break;

                case "leveltoreach":
                    if (type == SearchType.Equals)
                        filteredQuests.AddRange(file.Quests.Where(x => x.LevelToReach == Convert.ToUInt16(value)));

                    else if (type == SearchType.StartsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.LevelToReach.ToString().ToLower().StartsWith(value)));

                    else if (type == SearchType.EndsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.LevelToReach.ToString().ToLower().EndsWith(value)));

                    else if (type == SearchType.MoreThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.LevelToReach > Convert.ToUInt16(value)));

                    else if (type == SearchType.LessThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.LevelToReach < Convert.ToUInt16(value)));
                    break;

                case "requiredclass":

                    if (type == SearchType.StartsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.RequiredClass.ToString().ToLower().StartsWith(value)));

                    else if (type == SearchType.EndsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.RequiredClass.ToString().ToLower().EndsWith(value)));

                    else
                        filteredQuests.AddRange(file.Quests.Where(x => x.RequiredClass.ToString().ToLower() == value));
                    break;

                case "isenabled":
                    filteredQuests.AddRange(file.Quests.Where(x => x.IsEnabled == Convert.ToBoolean(value)));
                    break;

                case "title":
                    if (type == SearchType.Equals)
                        filteredQuests.AddRange(file.Quests.Where(x => x.TitleString.ToLower() == value));

                    else if (type == SearchType.StartsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.TitleString.ToString().ToLower().StartsWith(value)));

                    else if (type == SearchType.EndsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.TitleString.ToString().ToLower().EndsWith(value)));

                    else if (type == SearchType.Contains)
                        filteredQuests.AddRange(file.Quests.Where(x => x.TitleString.ToString().ToLower().Contains(value)));

                    else if (type == SearchType.MoreThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.Title > Convert.ToUInt16(value)));

                    else if (type == SearchType.LessThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.Title < Convert.ToUInt16(value)));
                    break;

                case "minlevel":
                    if (type == SearchType.Equals)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MinLevel == Convert.ToUInt16(value)));

                    else if (type == SearchType.StartsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MinLevel.ToString().ToLower().StartsWith(value)));

                    else if (type == SearchType.EndsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MinLevel.ToString().ToLower().EndsWith(value)));

                    else if (type == SearchType.MoreThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MinLevel > Convert.ToUInt16(value)));

                    else if (type == SearchType.LessThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MinLevel < Convert.ToUInt16(value)));
                    break;

                case "maxlevel":
                    if (type == SearchType.Equals)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MaxLevel == Convert.ToUInt16(value)));

                    else if (type == SearchType.StartsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MaxLevel.ToString().ToLower().StartsWith(value)));

                    else if (type == SearchType.EndsWith)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MaxLevel.ToString().ToLower().EndsWith(value)));

                    else if (type == SearchType.MoreThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MaxLevel > Convert.ToUInt16(value)));

                    else if (type == SearchType.LessThan)
                        filteredQuests.AddRange(file.Quests.Where(x => x.MaxLevel < Convert.ToUInt16(value)));
                    break;
            }

            lbQuests.DataSource = filteredQuests;
        }

        public enum SearchType
        {
            Equals,
            StartsWith,
            EndsWith,
            MoreThan,
            LessThan,
            Contains
        }
    }
}
