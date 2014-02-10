using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectChest : IInteractionType
    {
        public MazeObjectChest()
        {

        }

        public override string ToString()
        {
            return "c";
        }

        public void Interact(LivingCreature creature)
        {

        }

        public EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Chest;
        }
    }
}
