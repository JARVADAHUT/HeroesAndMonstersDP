using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectChest : MazeObject
    {
        public MazeObjectChest() : base()
        {

        }

        public override string ToString()
        {
            return "c";
        }

        public override void interact(LivingCreature creature)
        {

        }
    }
}
