using System;
using System.Collections.Generic;

namespace DesignPatterns___DC_Design
{
    abstract class DungeonCharacter
    {
        private Stats _dcStats;
        CharacterGearSet _gearInfo;
        public string Name { get; set; }

        public Stats DCStats
        {
            get { return _dcStats; } 
        }

        List<ICombatAction> _combatActions;
        Inventory inventory;

        public abstract void useAction(int ActionNumber); //This is just an idea

        //Returns the index number of the action (used above)
        public int registerAction(ICombatAction action)
        {
            if (this._combatActions.Contains(action))
                throw new ArgumentException("The Action is already registered with this character");
            this._combatActions.Add(action);
            return this._combatActions.Count - 1;
        }


    }
}
