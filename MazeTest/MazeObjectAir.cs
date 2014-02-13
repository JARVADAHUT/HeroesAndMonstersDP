using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectAir : IInteractionType
    {
        public MazeObjectAir()
        {

        }

        public void Interact(LivingCreature creature)
        {
            creature.Move();
        }

        public override string ToString()
        {
            return " ";
        }

        public EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Air;
        }
    }
}
