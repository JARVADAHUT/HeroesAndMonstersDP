using System;

namespace DesignPatterns___DC_Design
{
    public class StatAugmentCommand
    {
        public PublicEnums.StatsType Stat { get; set; }
        public int Magnitude { set; get; }
        public int Delay { set; get; }
        public int Duration { set; get; }


        private readonly Stats _characterStats;


        public StatAugmentCommand(PublicEnums.StatsType statForMod, Stats stats, int magnitude, int delay, int duration)
        {
            if (!ValidateCommand(statForMod, stats, magnitude, delay, duration))
                throw new ArgumentException("Invalid Command Parameters");

            this.Stat = statForMod;
            this._characterStats = stats;
            this.Magnitude = magnitude;
            this.Delay = delay;
            this.Duration = duration;
        }


        public StatAugmentCommand(PublicEnums.StatsType statForMod, Stats stats, int magnitude)
            : this(statForMod, stats, magnitude, 0, 0)
        {
        }

        private bool ValidateCommand(PublicEnums.StatsType statsForMod, Stats stats, int magnitude, int delay,
            int duration)
        {
            var result = true;

            result = stats.HasStat(statsForMod);
            result = delay >= 0 && duration >= 0;

            return result;
        }

        public void ApplyAugment()
        {
            _characterStats.ApplyAugment(Stat, Magnitude);
        }


        public void RemoveAugment()
        {
            _characterStats.RemoveAugment(Stat, Magnitude);
        }


    }
}

