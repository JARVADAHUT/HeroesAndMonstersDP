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

        public override void Interact(LivingCreature creature)
        {
            EnumDirection interactDirection = creature.GetLastMove();

            interactDirection = FlipDirection(interactDirection);

            MazeMover.Move(interactDirection, this);
        }


        private EnumDirection FlipDirection(EnumDirection curDir)
        {
            int flipDirection = -1 * (int)curDir;

            return (EnumDirection)flipDirection;
        }


        public override string ToString()
        {
            return "a";
        }
    }
}
