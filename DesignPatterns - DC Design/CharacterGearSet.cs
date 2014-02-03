using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class CharacterGearSet
    {
        Dictionary<string, IGear> _gearSet;

        public CharacterGearSet(string[] locations)
        {
            _gearSet = new Dictionary<string, IGear>(locations.Length);
            foreach (string loc in locations)
            {
                IGear nullGear = new NullGear();
                _gearSet.Add(loc, nullGear);
            }
        }

        public void replaceGear(string location, IGear newGear, out IGear oldGear)
        {
             oldGear = _gearSet[location];
             _gearSet.Remove(location);
             _gearSet.Add(location, newGear);
        }
    }
}
