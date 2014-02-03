using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class Stats
    {

        Dictionary<PublicEnums.StatsType, int> _stats;

        public void augmentStat(StatAugmentCommand augment)
        {
            if (Validate(augment))
            {
                PublicEnums.StatsType statForAugment = augment.Stat;
                var statValue = _stats[statForAugment];
                augment.ApplyAugment(statValue);
            }
        }

        private bool Validate(StatAugmentCommand augment)
        {
            return _stats.ContainsKey(augment.Stat);
        }
        /*
        int _maxHP, _curHp;
        int _strength, _agility, _defense, _intelegence;

        public int MaxHP { set { _maxHP=value < 0 ? 0 : value; } get { return _maxHP; } }
        public int CurHP { 
            set {
                if (value < 0)
                    value = 0;
                if (value > this.MaxHP)
                    value = this.MaxHP;
                _curHp = value; 
            } get { 
                return _curHp; 
            } 
        }
        public int Str { set { _strength = value < 0 ? 0 : value; } get { return _strength; } }
        public int Agl { set { _agility = value < 0 ? 0 : value;} get { return _agility;} }
        public int Def { set { _defense = value < 0 ? 0 : value; } get { return _defense; } }
        public int Int { set { _intelegence = value < 0 ? 0 : value; } get { return _intelegence; } }

        public void AugmentCurHP(int augment)
        {
            this.CurHP += augment;

            if (this.CurHP < 0)
                this.CurHP = 0;
            if (this.CurHP > this.MaxHP)
                this.CurHP = this.MaxHP;
        }

        public void AugmentMaxHP(int augment)
        {
            this.MaxHP += augment;

            if (this.MaxHP < 0)
                this.MaxHP = 0;
        }

        public void AugmentStr(int augment)
        {
            this.Str += augment;

            if (this.Str < 0)
                this.Str = 0;
        }

        public void AugmentDef(int augment)
        {
            this.Def += augment;

            if (this.Def < 0)
                this.Def = 0;
        }

        public void AugmentInt(int augment)
        {
            this.Int += augment;

            if (this.Int < 0)
                this.Int = 0;
        }

        public void AugmentAgl(int augment)
        {
            this.Agl += augment;

            if (this.Agl < 0)
                this.Agl = 0;
        }
         * 
         */
    }
}
