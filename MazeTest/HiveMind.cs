using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    // Singleton

    // ALL Monsters must register themselves with the HiveMind on creation. At any moment a monster dies or merges, it will unregister itself
    // The HiveMind will control the movements of all the monsters. Monsters will be done on one thread and the hive will work on that thread.

    class HiveMind
    {

        private static HiveMind _Hive = null;
        private ArrayList _minions;

        private HiveMind()
        {
            _minions = new ArrayList();
        }

        public static HiveMind GetInstance()
        {
            return _Hive ?? (_Hive = new HiveMind());
        }

        public int SubjectsLeft()
        {
            return _minions.Count;
        }

        public void RegisterSubject(Monster m)
        {
            _minions.Add(m);
            m._ID = (_minions.Count + 1);
        }

        public void UnregisterSubject(Monster m)
        {
            _minions.Remove(m);
        }

        // IN HIVEMIND
        public void moveMinions()
        {
            ArrayList weight;
            foreach (Monster monster in _minions)
            {
                weight = monster.GetMoveWeight();
            }
        }

    }
}
