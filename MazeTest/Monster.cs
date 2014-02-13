using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class Monster : LivingCreature
    {
        private const int _maxWeight = 60;

        //private static int = 0;

        public int _ID { set; get; }
        private ArrayList _moveWeight;

        public Monster() : base() // unsure about null 
        {
            HiveMind.GetInstance().RegisterSubject(this);

            //4 movement directions
            _moveWeight = new ArrayList(4);
            for (int x = 0; x < 4; x++)
                _moveWeight.Add(10);

            SetInteraction(this);
        }

        public override void Die()
        {
            SetInteraction( FMazeObjectFactory.GetMazeObject(EnumMazeObject.Air) );
            HiveMind.GetInstance().UnregisterSubject(this);
            // possibly unregister itself from HiveMind
        }

        public override void Exit()
        {
            // do nothing you're a monster
        }

        public override EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Monster;
        }

        public override void Interact(LivingCreature lc)
        {
            this.Die();
            // do nothing
        }

        public override string ToString()
        {
            return "m";
        }

        public override void Hook()
        {
            if ((int)_moveWeight[(int)(this.GetLastMove())] == _maxWeight)
                _moveWeight[(int)(this.GetLastMove())] = 10;
            else
                _moveWeight[(int)(this.GetLastMove())] = (int)(_moveWeight[(int)(this.GetLastMove())]) + 10;
        }

        public ArrayList GetMoveWeight()
        {
            return _moveWeight;
        }

        public bool Equals(Monster otherMonster)
        {
            return _ID == otherMonster._ID;
        }
    }
}
