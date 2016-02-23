using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib
{
    public class QuestFile : IFile
    {
        public SHNFile QuestDialog { get; set; }
        public SHNFile ItemInfo { get; set; }
        public SHNFile MobInfo { get; set; }

        public BindingList<Quest> Quests =
            new BindingList<Quest>();

        public Dictionary<ushort, string> QuestStrings =
            new Dictionary<ushort, string>();

        private BinaryReader reader { get; set; }
        private BinaryReader writer { get; set; }

        public short Header;
        public short QuestCount
        {
            get
            {
                return Convert.ToInt16(Quests.Count);
            }
        }

        public string FilePath { get; set; }
        public bool IsSaved { get; set; }

        public QuestFile(string filePath)
        {
            FilePath = filePath;
            IsSaved = true;

            QuestDialog = new SHNFile(Path.Combine(Path.GetDirectoryName(filePath), "QuestDialog.shn"));
            Init();
        }

        private async void Init()
        {
            await QuestDialog.Load(new Progress<int>());
            foreach (DataRow row in QuestDialog.Rows)
            {
                if (QuestStrings.ContainsKey(Convert.ToUInt16(row.ItemArray[0]))) continue;

                QuestStrings.Add(Convert.ToUInt16(row.ItemArray[0]), row.ItemArray[1].ToString());
            }
        }

        public async Task Load(IProgress<int> progress)
        {
            int percent = 0;
            using (reader = new BinaryReader(File.OpenRead(FilePath)))
            {
                Header = reader.ReadInt16();
                var questCount = reader.ReadInt16();

                for (int i = 0; i < questCount; i++)
                {
                    var quest = new Quest();
                    quest.Length = reader.ReadUInt16();

                    reader.ReadUInt16(); // unk

                    quest.ID = reader.ReadUInt16();
                    quest.Title = reader.ReadUInt16();
                    quest.TitleString = QuestStrings[quest.Title];
                    quest.Description = reader.ReadUInt16();

                    reader.ReadInt32(); // unk
                    reader.ReadUInt16(); // unk

                    quest.HasLevelRequirement = Convert.ToBoolean(reader.ReadByte());
                    quest.MinLevel = reader.ReadByte();
                    quest.MaxLevel = reader.ReadByte();
                    quest.IsEnabled = Convert.ToBoolean(reader.ReadByte());

                    quest.QuestNPC = new Mob()
                    {
                        ID = reader.ReadInt16()
                    };

                    reader.ReadBytes(28); // unk

                    quest.HasClassRequirement = Convert.ToBoolean(reader.ReadByte());
                    quest.RequiredClass = (PlayerClass)reader.ReadByte();

                    var unk = reader.ReadBytes(564); // unk

                    quest.StartScript = reader.ReadStringUntilZero();
                    quest.InProgressScript = reader.ReadStringUntilZero();
                    quest.FinishScript = reader.ReadStringUntilZero();

                    readMobs();

                    Quests.Add(quest);

                    percent = Convert.ToInt32(((double)i / questCount) * 100);
                    progress.Report(percent);
                }
            }
        }

        public async Task Save(string filePath, IProgress<int> progress)
        {
            using (writer = new BinaryReader(File.OpenWrite(filePath)))
            {

            }
        }

        private void readMobs()
        {

        }
    }

    public class Quest
    {
        [Browsable(false)]
        public ushort Length { get; set; }

        [ReadOnly(true)]
        [DisplayName("\t\t\t\tID")]
        [Category("General")]
        [Description("The ID number of this quest. To lower the chance of messing up, this option is read only.")]
        public uint ID { get; set; }

        [ReadOnly(false)]
        [DisplayName("\t\t\tTitle")]
        [Category("General")]
        [Description("The underlying ID for this quests title.")]
        public ushort Title { get; set; }

        [ReadOnly(false)]
        [DisplayName("Title")]
        [Category("Strings")]
        [Description("The quest title in text.")]
        public string TitleString { get; set; }

        [ReadOnly(false)]
        [DisplayName("\t\tDescription")]
        [Category("General")]
        [Description("The underlying ID for this quests description.")]
        public ushort Description { get; set; }

        [ReadOnly(false)]
        [DisplayName("HasLevelRequirement")]
        [Category("Requirements")]
        [Description("Whether or not this quest requires the player to have a certain level. (ex. 1-20)")]
        public bool HasLevelRequirement { get; set; }

        [ReadOnly(false)]
        [DisplayName("MinimumLevel")]
        [Category("Requirements")]
        [Description("What level the player needs to be at least.")]
        public byte MinLevel { get; set; }

        [ReadOnly(false)]
        [DisplayName("MaximumLevel")]
        [Category("Requirements")]
        [Description("What level the player needs to be below.")]
        public byte MaxLevel { get; set; }

        [ReadOnly(false)]
        [DisplayName("\tIsEnabled")]
        [Category("General")]
        [Description("Determines whether this quest will be visible in game.")]
        public bool IsEnabled { get; set; }

        [Browsable(false)]
        public Mob QuestNPC { get; set; }

        [ReadOnly(true)]
        [DisplayName("StartingNPC")]
        [Category("Strings")]
        [Description("The NPC who gives you the quest, in text.")]
        public string QuestGiver { get; set; }

        [ReadOnly(false)]
        [DisplayName("StartingNPC")]
        [Category("General")]
        [Description("The underlying ID of the NPC who gives you the quest.")]
        public short QuestGiverID { get { return QuestNPC.ID; } set { QuestNPC.ID = value; } }

        [Browsable(false)]
        public bool HasClassRequirement { get; set; }

        [ReadOnly(false)]
        [DisplayName("RequiredClass")]
        [Category("Requirements")]
        [Description("Player class required to accept this quest. Select \"Any\" if you want all classes.")]
        public PlayerClass RequiredClass { get; set; }

        [Browsable(false)]
        public string StartScript { get; set; }

        [Browsable(false)]
        public string InProgressScript { get; set; }

        [Browsable(false)]
        public string FinishScript { get; set; }

        [Browsable(false)]
        public List<Mob> Mobs { get; set; }

        [Browsable(false)]
        public List<Item> Items { get; set; }
    }

    public class Mob
    {
        public short ID { get; set; }
        public string InxName { get; set; }
        public string Name { get; set; }

        // For in-quest mobs
        public bool IsEnabled { get; set; }
        public bool IsToKill { get; set; }
        public byte KillAmount { get; set; }
    }

    public class Item
    {
        public short ID { get; set; }
        public string InxName { get; set; }
        public string Name { get; set; }
    }

    public class Reward
    {
        public RewardType Type { get; set; }
        public int Amount { get; set; }
        public bool IsFixed { get; set; }
    }

    public enum RewardType
    {
        Fame = 0,
        Money = 1,
        Item = 2,
        Exp = 4
    }

    public enum PlayerClass
    {
        Any,
        Fighter,
        CleverFighter,
        Warrior,
        Gladiator,
        Knight,
        Cleric,
        HighCleric,
        Paladin,
        HolyKnight,
        Guardian,
        Archer,
        HawkArcher,
        Scout,
        SharpShooter,
        Ranger,
        Mage,
        WizMage,
        Enchanter,
        Warlock,
        Wizard,
        Trickster,
        Gambit,
        Renegade,
        Spectre,
        Reaper,
    }
}
