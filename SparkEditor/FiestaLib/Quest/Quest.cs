using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkEditor.FiestaLib.Quest
{
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

        [Browsable(false)]
        public ushort Description { get; set; }

        [ReadOnly(false)]
        [DisplayName("\t\t\t\tHasLevelRequirement")]
        [Category("Requirements")]
        [Description("Whether or not this quest requires the player to have a certain level. (ex. 1-20)")]
        public bool HasLevelRequirement { get; set; }

        [ReadOnly(false)]
        [DisplayName("\t\t\tMinLevel")]
        [Category("Requirements")]
        [Description("What level the player needs to be at least.")]
        public byte MinLevel { get; set; }

        [ReadOnly(false)]
        [DisplayName("\t\tMaxLevel")]
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
        public ushort QuestGiverID { get { if (QuestNPC == null) return 0; else return QuestNPC.ID; } set { QuestNPC.ID = value; } }

        [Browsable(false)]
        public Mob RewardingNPC { get; set; }

        [ReadOnly(true)]
        [DisplayName("RewardingNPC")]
        [Category("Strings")]
        [Description("The NPC that you turn the quest in to for a reward, in text.")]
        public string RewardNPC { get; set; }

        [ReadOnly(false)]
        [DisplayName("RewardingNPC")]
        [Category("General")]
        [Description("The NPC that you turn the quest in to for a reward.")]
        public ushort RewardingNPCID { get { if (RewardingNPC == null) return 0; else return RewardingNPC.ID; } set { RewardingNPC.ID = value; } }

        [Browsable(false)]
        public bool HasClassRequirement { get; set; }

        [ReadOnly(false)]
        [DisplayName("IsLevelingQuest")]
        [Category("General")]
        [Description("Determines whether the player needs to reach a specific level to finish the quest as a quest objective.")]
        public bool IsLevelQuest { get; set; }

        [ReadOnly(false)]
        [DisplayName("LevelToReach")]
        [Category("General")]
        [Description("The level to reach to finish the quest, IsLevelQuest needs to be enabled for this option.")]
        public byte LevelToReach { get; set; }

        [ReadOnly(false)]
        [DisplayName("\tRequiredClass")]
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
}
