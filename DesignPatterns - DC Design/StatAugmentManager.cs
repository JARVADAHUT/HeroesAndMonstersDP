using System.Threading;

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

            var sacThread = new StatAugmentCommandThread(cmd);

            ThreadPool.QueueUserWorkItem(sacThread.ThreadStart);
            //var t = new Thread(new ThreadStart(sacThread.ThreadStart));
            //t.Start();
        }


        private class StatAugmentCommandThread
        {
            private StatAugmentCommand _cmd;

            public StatAugmentCommandThread(StatAugmentCommand cmd)
            {
                _cmd = cmd;
            }

            internal void ThreadStart(object state)
            {
                var delay = _cmd.Delay;
                var duration = _cmd.Duration;

                Thread.Sleep(delay * 1000);
                _cmd.ApplyAugment();
                if (duration > 0)
                {
                    Thread.Sleep(duration*1000);
                    _cmd.RemoveAugment();
                }
            }

        }
    }

}
