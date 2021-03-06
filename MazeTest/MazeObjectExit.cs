﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectExit : IInteractionType
    {
        public MazeObjectExit()
        {
            
        }

        public void Interact(LivingCreature creature)
        {
            creature.Exit();
        }

        public override string ToString()
        {
            return "e";
        }

        public EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Exit;
        }
    }
}
