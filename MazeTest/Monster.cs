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
        private const int maxWeight = 3;

        public int _ID { set; get; }
        public ArrayList _moveWeight;

        public Monster() : base(null) // unsure about null 
        {
            HiveMind.GetInstance().RegisterSubject(this);
            _moveWeight = new ArrayList();
            for (int x = 0; x < 4; x++)
                _moveWeight.Add(0);
        }

        public override void Die()
        {
            // possibly unregister itself from HiveMind
        }

        public override void Exit()
        {
            // do nothing
        }

        public override void Move()
        {
            // do nothing
        }

        public override EnumMazeObject GetInteractionType()
        {
            return EnumMazeObject.Monster;
        }

        public override void Interact(LivingCreature lc)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "m";
        }

        public override void hook()
        {
            if ((int)_moveWeight[(int)(this.GetLastMove())] != maxWeight)
                _moveWeight[(int)(this.GetLastMove())] = (int)(_moveWeight[(int)(this.GetLastMove())]) + 1;
        }

        public ArrayList GetMoveWeight()
        {
            return _moveWeight;
        }

    }
}
