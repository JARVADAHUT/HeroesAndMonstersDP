using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectAir : MazeObject
    {
        public MazeObjectAir() : base()
        {

        }

        public override void interact(LivingCreature creature)
        {
            EnumDirection interactDirection = creature.getLastMove();

            int flipDirection = -1 * (int)interactDirection;

            interactDirection = (EnumDirection)flipDirection;

            MazeMover.move(interactDirection, this);
        }



        public override string ToString()
        {
            return "a";
        }
    }
}
