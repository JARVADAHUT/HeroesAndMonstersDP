using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class MonsterTurnManager
    {
        private Queue<Monster> _monsterQueue;

        public MonsterTurnManager()
        {
            _monsterQueue = new Queue<Monster>();
        }

        public void RegisterMonster(Monster monster)
        {
            _monsterQueue.Enqueue(monster);

        }

        public void start()
        {
            
        }


        private class QueueThread
        {
            private Queue<Monster> _queue;

            internal QueueThread(Queue<Monster> queue)
            {
                _queue = queue;
            }

            internal void ThreadStart(Object state)
            {
                while (_queue.Count > 0)
                {
                    var monster = _queue.Dequeue();
                    var mThread = new Thread(new MonsterThread(monster).ThreadStart);
                    mThread.Start();
                    mThread.Join();

                    _queue.Enqueue(monster);
                }
                
            }


        }

        private class MonsterThread
        {
            private readonly Monster _monster;

            internal MonsterThread(Monster monster)
            {
                _monster = monster;
            }

            internal void ThreadStart()
            {
                Thread.Sleep(2000 - 100*_monster.DCStats.GetStat(StatsType.Agility));
                _monster.TakeTurn();
            }
        }
    }

}
