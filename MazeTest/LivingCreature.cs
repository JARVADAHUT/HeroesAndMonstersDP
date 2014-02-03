using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    abstract class LivingCreature : MazeObject
    {
        protected int _hitPoints;
        protected int _resourcePoints;
        protected string _name;
        private EnumDirection _lastMoveDirection;

        abstract public void die();

        public override void interact(EnumDirection dir)
        {
            this.setLastMove(dir);

            MazeObject interaction = getInteractionObject(dir);

            interaction.interact(this);
        }

        public void setLastMove(EnumDirection dir)
        {
            _lastMoveDirection = dir;
        }

        public EnumDirection getLastMove()
        {
            return _lastMoveDirection;
        }

        //could this go somewhere else? -- where?
        private MazeObject getInteractionObject(EnumDirection dir)
        {
            switch (dir)
            {
                case EnumDirection.Up:
                    return _surroundings.getUp();

                case EnumDirection.Down:
                    return _surroundings.getDown();

                case EnumDirection.Left:
                    return _surroundings.getLeft();

                case EnumDirection.Right:
                    return _surroundings.getRight();

                default:
                    throw new FieldAccessException();
            }
        }

    }
}
