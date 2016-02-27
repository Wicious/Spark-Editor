using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkEditor.FiestaLib.Quest
{
    public class Mob
    {
        public ushort ID { get; set; }
        public string InxName { get; set; }
        public string Name { get; set; }

        // For in-quest mobs
        public bool IsEnabled { get; set; }
        public bool IsToKill { get; set; }
        public byte KillAmount { get; set; }
    }
}
