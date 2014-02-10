using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectExit : IInteractionType
    {
        public MazeObjectExit()
        {
            
        }

        public void Interact(LivingCreature creature)
        {
<<<<<<< HEAD
            creature.Exit();
=======
            Maze maze = Maze.GetInstance();

            creature.ResetPosition();
            
            maze.GenerateNext();
>>>>>>> ba13352ac059212eab6f1873e8010413419c07ba
        }

        public override string ToString()
        {
            return "e";
        }

        public EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Exit;
        }
    }
}
