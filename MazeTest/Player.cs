using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    /*abstract*/ class Player : LivingCreature
    {
        private static Player _thisPlayer = null;
        //singleton

        private Player()
        {

        }

        public static Player getInstance()
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

    }
}
