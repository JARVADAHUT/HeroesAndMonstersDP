using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectExit : MazeObject
    {
        //private LevelEntrance _nextLevel;


        public MazeObjectExit(/*LevelEntrance nextLevel*/) : base()
        {
            //_nextLevel = nextLevel;
        }

        public override void interact(LivingCreature creature)
        {

        }
        public override string ToString()
        {
            return "e";
        }
    }
}
