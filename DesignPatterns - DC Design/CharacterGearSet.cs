using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class CharacterGearSet
    {
        Dictionary<string, Gear> _gearSet;

        public CharacterGearSet(string[] locations)
        {
            _gearSet = new Dictionary<string, Gear>(locations.Length);
            foreach (string loc in locations)
            {
                Gear nullGear = new NullGear();
                _gearSet.Add(loc, nullGear);
            }
        }

        public void ReplaceGear(string location, Gear newGear, out Gear oldGear)
        {
             oldGear = _gearSet[location];
             _gearSet.Remove(location);
             _gearSet.Add(location, newGear);
        }

        public Gear GetGear()
    }
}
