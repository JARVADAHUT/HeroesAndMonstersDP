﻿using System;
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
            m._ID = (_minions.Count + 1);
            _minions.Add(m);
        }

        public void UnregisterSubject(Monster m) // can't use _minions.remove(m) unless we override object.Equals()
        {
            Monster monster;
            for (int x = 0; x < _minions.Count-1; x++)
            {
                monster = (Monster)_minions[x];
                if (monster._ID == m._ID)
                {
                    _minions.RemoveAt(x);
                    break;
                }
            }
        }

        public void moveMinions() // serves as delegate
        {
            ArrayList weight;
            Random random = new Random();
            int sum = 0, dir = 0, r;

            foreach (Monster monster in _minions)
            {
                weight = monster.GetMoveWeight();

                // total all the weight 0 <= x <= maxWeight*4 (4 being the number of possible directions)
                foreach (int weightValue in weight) 
                    sum += weightValue;

                // grab a random value between 0 and sum
                r = random.Next(0, sum); 

                do
                {
                    // subtract direction's weight from r
                    r -= (int)weight[dir]; 

                    // if the direction's weight brought the random number at or below 0, move in that direction
                    if (r <= 0) 
                        monster.Interact((EnumDirection)dir);

                    // else increment the direction to the next one, loop again
                    dir++;

                } while (r > 0);

                // reset values for each minion
                sum = 0;
                dir = 0;

            } // end foreach

        } // end moveMinions

    }
}
