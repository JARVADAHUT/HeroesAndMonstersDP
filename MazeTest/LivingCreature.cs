﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DesignPatterns___DC_Design;

namespace MazeTest
{
    abstract class LivingCreature : MazeObject, IInteractionType
    {
        //protected DungeonCharacter dc;
<<<<<<< HEAD
=======
        protected string _name;
>>>>>>> ba13352ac059212eab6f1873e8010413419c07ba
        private EnumDirection _lastMoveDirection;


        protected LivingCreature(IInteractionType i) : base(i)
        {

        }

        public abstract void Die();

        public abstract void Exit();
        public abstract void Move();

        public new abstract EnumMazeObject GetInteractionType();
        public new abstract void Interact(LivingCreature lc);
        public abstract override string ToString();


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

    }
}
