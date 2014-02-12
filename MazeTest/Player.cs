using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DesignPatterns___DC_Design;

namespace MazeTest
{
    /*abstract*/ class Player : LivingCreature
    {
        private static Player _thisPlayer = null;
        //singleton

        private Player() : base(_thisPlayer)
        {
            //this.dc = new Hero();
        }

        public static Player GetInstance()
        {
            return _thisPlayer ?? (_thisPlayer = new Player());
        }

        public override void Die()
        {

        }

        public override string ToString()
        {
            return "p";
        }

        public override void Interact(LivingCreature l)
        {
            
        }


        public override void Exit()
        {
            Maze maze = Maze.GetInstance();
            this.ResetPosition();
            maze.GenerateNext();
        }

        private void ResetPosition()
        {
            _surroundings = new Surroundings();
        }

        public override EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Player;
        }
    }
}
