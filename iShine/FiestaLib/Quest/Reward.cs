using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib.Quest
{
    public class Reward
    {
        public RewardType Type { get; set; }
        public int Amount { get; set; }
        public bool IsFixed { get; set; }
    }
}
