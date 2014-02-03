using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    interface ICombatAction
    {
        public abstract void performAction(Target target);
        public abstract int getResourceUse();
    }
}
