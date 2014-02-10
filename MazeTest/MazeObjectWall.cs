using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectWall : IInteractionType
    {
        public MazeObjectWall()
        {

        }

        public void Interact(LivingCreature creature)
        {
            //do nothing, you are a wall
        }

        public override string ToString()
        {
            return "w";
        }

        public EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Wall;
        }
    }
}
