namespace DesignPatterns___DC_Design
{
    public class StatAugmentCommand
    {
        public PublicEnums.StatsType Stat { get; set; }
        public int Magnitude { set; get; }
        public int Delay { set; get; }
        public int Duration { set; get; }


        private Stats _characterStats;


        public StatAugmentCommand(PublicEnums.StatsType statForMod, Stats stats, int magnitude, int delay, int duration)
        {
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

