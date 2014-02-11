using System.Collections.Generic;

namespace DesignPatterns___DC_Design
{
    class CharacterGearSet
    {
        Dictionary<string, Gear> _gearSet;
        Dictionary<string, Gear> _gearSet;

        public CharacterGearSet(string[] locations)
        {
            _gearSet = new Dictionary<string, Gear>(locations.Length);
            _gearSet = new Dictionary<string, Gear>(locations.Length);
            foreach (string loc in locations)
            {
                Gear nullGear = new NullGear();
                Gear nullGear = new NullGear();
                _gearSet.Add(loc, nullGear);
            }
        }

        public void ReplaceGear(string location, Gear newGear, out Gear oldGear)
        public void ReplaceGear(string location, Gear newGear, out Gear oldGear)
        {
             oldGear = _gearSet[location];
             _gearSet.Remove(location);
             _gearSet.Add(location, newGear);
        }

        public Gear GetGear()
        public Gear GetGear()
        {
            return null; //stub
        }
    }
}
