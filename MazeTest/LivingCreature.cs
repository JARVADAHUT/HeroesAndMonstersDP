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

        abstract public void Die();

        public void Interact(EnumDirection dir)
        {
            this.SetLastMove(dir);

            MazeObject interaction = GetInteractionObject(dir);

            interaction.Interact(this);
        }

        public void SetLastMove(EnumDirection dir)
        {
            _lastMoveDirection = dir;
        }

        public EnumDirection GetLastMove()
        {
            return _lastMoveDirection;
        }

        //could this go somewhere else? -- where?
        private MazeObject GetInteractionObject(EnumDirection dir)
        {
            switch (dir)
            {
                case EnumDirection.Up:
                    return _surroundings.GetUp();

                case EnumDirection.Down:
                    return _surroundings.GetDown();

                case EnumDirection.Left:
                    return _surroundings.GetLeft();

                case EnumDirection.Right:
                    return _surroundings.GetRight();

                default:
                    throw new FieldAccessException();
            }
        }

        public void ResetPosition()
        {
            _surroundings = new Surroundings();
        }

    }
}
