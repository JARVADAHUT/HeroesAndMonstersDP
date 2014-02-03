using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class Surroundings
    {
        private MazeObject _left;
        private MazeObject _right;
        private MazeObject _up;
        private MazeObject _down;


        public Surroundings()
        {
            _left = null;
            _right = null;
            _up = null;
            _down = null;
        }


        //setters-------------------------------


        public void setLeft(MazeObject left)
        {
            _left = left;
        }

        public void setRight(MazeObject right)
        {
            _right = right;
        }

        public void setUp(MazeObject up)
        {
            _up = up;
        }

        public void setDown(MazeObject down)
        {
            _down = down;
        }


        //getters-------------------------------


        public MazeObject getLeft()
        {
            return _left;
        }

        public MazeObject getRight()
        {
            return _right;
        }

        public MazeObject getUp()
        {
            return _up;
        }

        public MazeObject getDown()
        {
            return _down;
        }



    }
}
