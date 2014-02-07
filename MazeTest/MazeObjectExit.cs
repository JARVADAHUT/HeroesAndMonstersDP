using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectExit : MazeObject
    {
        public MazeObjectExit() : base()
        {
            
        }

        public override void Interact(LivingCreature creature)
        {
            Maze maze = Maze.GetInstance();
            creature.ResetPosition();
            maze.GenerateNext();
        }

        public override string ToString()
        {
            return "e";
        }
    }
}
