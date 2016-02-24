using iShine.FiestaLib.SHN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib.Quest
{
    public class QuestFile : IFile
    {
        public QuestFileVersion QuestFileVersion { get; set; }

        public SHNFile QuestDialog { get; set; }
        public SHNFile ItemInfo { get; set; }
        public SHNFile MobInfo { get; set; }

        public BindingList<Quest> Quests =
            new BindingList<Quest>();

        public Dictionary<ushort, string> QuestStrings =
            new Dictionary<ushort, string>();

        public Dictionary<ushort, object[]> MobRows =
            new Dictionary<ushort, object[]>();

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
            MobInfo = new SHNFile(Path.Combine(Path.GetDirectoryName(filePath), "MobInfo.shn"));
            Init();
        }

        private async void Init()
        {
            await QuestDialog.Load(new Progress<int>());
            await MobInfo.Load(new Progress<int>());

            foreach (DataRow row in QuestDialog.Rows)
            {
                if (QuestStrings.ContainsKey(Convert.ToUInt16(row.ItemArray[0]))) continue;

                QuestStrings.Add(Convert.ToUInt16(row.ItemArray[0]), row.ItemArray[1].ToString());
            }

            foreach (DataRow row in MobInfo.Rows)
            {
                if (MobRows.ContainsKey(Convert.ToUInt16(row.ItemArray[0]))) continue;
                MobRows.Add(Convert.ToUInt16(row.ItemArray[0]), row.ItemArray);
            }

        }

        public async Task Load(IProgress<int> progress)
        {
            int percent = 0;
            using (reader = new BinaryReader(File.OpenRead(FilePath)))
            {
                Header = reader.ReadInt16();
                QuestFileVersion = (Header == 4 ? QuestFileVersion.NA11 : QuestFileVersion.CN12);

                var questCount = reader.ReadInt16();

                for (int i = 0; i < questCount; i++)
                {
                    var quest = new Quest();
                    quest.Mobs = new List<Mob>();

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
                        ID = reader.ReadUInt16()
                    };

                    reader.ReadBytes(28); // unk

                    quest.HasClassRequirement = Convert.ToBoolean(reader.ReadByte());
                    quest.RequiredClass = (PlayerClass)reader.ReadByte();

                    reader.ReadBytes(20); // unk
                    quest.IsLevelQuest = Convert.ToBoolean(reader.ReadByte());
                    quest.LevelToReach = reader.ReadByte();
                    reader.ReadUInt16(); // unk
                    ushort id = reader.ReadUInt16();
                    quest.RewardingNPC = new Mob()
                    {
                        ID = id,
                    };
                    reader.ReadUInt16();

                    readMobs(quest);

                    var unk = reader.ReadBytes(512); // unk

                    quest.StartScript = reader.ReadStringUntilZero();
                    quest.InProgressScript = reader.ReadStringUntilZero();
                    quest.FinishScript = reader.ReadStringUntilZero();

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

        private void readMobs(Quest quest)
        {
            for (int i = 0; i < 4; i++)
            {
                var mob = new Mob();

                mob.IsEnabled = Convert.ToBoolean(reader.ReadByte());
                reader.ReadByte();
                mob.ID = reader.ReadUInt16();

                if (MobRows.ContainsKey(mob.ID))
                    mob.Name = MobRows[mob.ID][2].ToString();
                else
                    mob.Name = "-";

                mob.IsToKill = Convert.ToBoolean(reader.ReadByte());
                mob.KillAmount = reader.ReadByte();

                quest.Mobs.Add(mob);
            }
        }
    }
}
