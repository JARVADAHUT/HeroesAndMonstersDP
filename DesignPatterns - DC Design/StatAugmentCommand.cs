using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class StatAugmentCommand
    {
        public PublicEnums.StatsType Stat { get; set; }
        public int AugmentAmt { get; set; }

        public StatAugmentCommand(PublicEnums.StatsType stat, int augmentAmt)
        {
            this.Stat = stat;
            this.AugmentAmt = augmentAmt;
        }

        public int ApplyAugment(int statValue)
        {
            return statValue + AugmentAmt;
        }

        public int RemoveAugment(int statValue)
        {
            return statValue - AugmentAmt;
        }

    }
}
