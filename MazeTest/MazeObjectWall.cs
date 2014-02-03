using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectWall : MazeObject
    {
        public MazeObjectWall() : base()
        {

        }

        public override void interact(LivingCreature creature)
        {
            //do nothing, you are a wall
        }

        public override string ToString()
        {
            return "w";
        }
    }
}
