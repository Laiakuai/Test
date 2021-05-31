using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Models
{
    //勇士类  有额外的物理攻击力
    [Serializable]
    class Warrior:Hero
    {
        private int extraAttackPower;

        public Warrior(string name, int originalLife, int attrackPower, int extraAttackPower,int defencePower, int origianl_x, int original_y) :
            base(name, originalLife, attrackPower,defencePower, origianl_x, original_y)
        {
            this.extraAttackPower = extraAttackPower;
        }
        public int ExtraAttackPower { get => extraAttackPower; set => extraAttackPower = value; }
        
        public void totalClac()
        {
            if (this.Weapon != null)
            {
                this.Attackpower = this.Attackpower + this.extraAttackPower + this.Weapon.AttackPower;
                this.DefencePower = this.DefencePower + this.Weapon.DefensePower;
            }
            else
            {
                this.Attackpower = this.Attackpower + this.extraAttackPower;
                this.DefencePower = this.DefencePower;
            }
        }
    }
}
