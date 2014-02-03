using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeNodeObject
    {
        private MazeObject _occupiedBy;
        private Surroundings _surroundings;

        public MazeNodeObject(MazeObject mo)
        {
            _occupiedBy = mo;
            _surroundings = new Surroundings();
        }


        public Surroundings getSurroundings()
        {
            return _surroundings;
        }

        public MazeObject getObject()
        {
            return _occupiedBy;
        }

        public void setObject(MazeObject mo)
        {
            _occupiedBy = mo;
        }

        private bool swappable()
        {
            return _occupiedBy.interact();
        }

        public bool move(EnumDirection dir)
        {
            switch (dir)
            {
                case EnumDirection.Right:
                    if (_surroundings.getRight().swappable())
                    {
                        MazeObject temp = _surroundings.getRight().getObject();
                        _surroundings.getRight().setObject(_occupiedBy);
                        _occupiedBy = temp;
                        return true;
                    }
                    return false;

                case EnumDirection.Left:
                    if (_surroundings.getLeft().swappable())
                    {
                        MazeObject temp = _surroundings.getLeft().getObject();
                        _surroundings.getLeft().setObject(_occupiedBy);
                        _occupiedBy = temp;
                        return true;
                    }
                    return false;

                case EnumDirection.Up:
                    if (_surroundings.getUp().swappable())
                    {
                        MazeObject temp = _surroundings.getUp().getObject();
                        _surroundings.getUp().setObject(_occupiedBy);
                        _occupiedBy = temp;
                        return true;
                    }
                    return false;

                case EnumDirection.Down:
                    if (_surroundings.getDown().swappable())
                    {
                        MazeObject temp = _surroundings.getDown().getObject();
                        _surroundings.getDown().setObject(_occupiedBy);
                        _occupiedBy = temp;
                        return true;
                    }
                    return false;

                default:
                    return false;

            }//end switch
        }


    }
}
