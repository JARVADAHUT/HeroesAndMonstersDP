using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    abstract class StatAugmentCommand
    {
        public PublicEnums.StatsType Stat { get; set; }

        public abstract void ApplyAugment(int statValue);
        public abstract void RemoveAugment(int statValue);

        private abstract int ValidateNewStat(int statValue);

    }
}
