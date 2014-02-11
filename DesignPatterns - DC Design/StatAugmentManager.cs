using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    public class StatAugmentManager
    {
        private static StatAugmentManager _instanceStatAugmentManager = null;

        private StatAugmentManager()
        {
            
        }

        public static StatAugmentManager GetInstance()
        {
            if (_instanceStatAugmentManager == null)
            {
                _instanceStatAugmentManager = new StatAugmentManager();
            }
            return _instanceStatAugmentManager;
        }

        public void ReceiveCommand(StatAugmentCommand cmd)
        {
            StatAugmentCommandThread sacThread = new StatAugmentCommandThread(cmd);

            Thread t = new Thread(new ThreadStart(sacThread.threadStart));
            t.Start();
        }


        private class StatAugmentCommandThread
        {
            private StatAugmentCommand _cmd;

            public StatAugmentCommandThread(StatAugmentCommand cmd)
            {
                this._cmd = cmd;
            }

            public void threadStart()
            {
                int delay = _cmd.Delay;
                int duration = _cmd.Duration;

                Thread.Sleep(delay * 1000);
                _cmd.ApplyAugment();
                Thread.Sleep(duration * 1000);
                _cmd.RemoveAugment();
            }

        }
    }

}
