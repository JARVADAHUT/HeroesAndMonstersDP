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

        public override void Interact(LivingCreature creature)
        {
            Maze.GetInstance().Exit();
            Maze maze = Maze.GetInstance();
            maze.Generate(10);
        }
        public override string ToString()
        {
            return "e";
        }
    }
}
