﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObject : IInteractionType
    {
        protected Surroundings _surroundings;
        private bool _discovered;
        private IInteractionType _interaction;

        public MazeObject(IInteractionType i)
        {
            _surroundings = new Surroundings();
            _discovered = false;
            _interaction = i;
        }

        protected void SetInteraction(IInteractionType i)
        {
            _interaction = i;
        }

        public void Interact(LivingCreature creature)
        {
            _interaction.Interact(creature);
        }

        public void SetDiscovered(bool b)
        {
            _discovered = b;
        }

        public bool GetDiscovered()
        {
            return _discovered;
        }

        public Surroundings getSurroundings()
        {
            return _surroundings;
        }

        public override string ToString()
        {
            return _interaction.ToString();
        }

        public EnumMazeObject GetInteractionType()
        {
            return _interaction.GetInteractionType();
        }



    }
}
