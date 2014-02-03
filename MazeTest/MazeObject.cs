using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{



    abstract class MazeObject
    {
        protected Surroundings _surroundings;
        private bool _discovered;


        protected MazeObject()
        {
            _surroundings = new Surroundings();
            _discovered = false;
        }


        // player interaction with the maze is movement? (if it is an air block)
        
        abstract public override string ToString();
        //abstract public bool interact();
        //abstract public bool interact(Direction d);

        public void setDiscovered(bool b)
        {
            _discovered = b;
        }

        public bool getDiscovered()
        {
            return _discovered;
        }

        protected bool move(EnumDirection dir)
        {
            MazeMover.move(dir, this);


            return false;
        }

        public abstract void interact(LivingCreature creature);

        public Surroundings getSurroundings()
        {
            return _surroundings;
        }
        
    }
}
