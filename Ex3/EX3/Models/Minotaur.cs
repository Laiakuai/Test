using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Models
{
    //牛头怪类   高血量，低攻击就是普通攻击力，只有物理攻击
    [Serializable]
    class Minotaur : Monster
    {
        private int extraLife;
        public Minotaur(string name, int originalLife, int extraLife, int defencePower, int attackPower, int positionOriginal_x, int positionOriginal_y) :
            base(name, originalLife, attackPower, defencePower, positionOriginal_x, positionOriginal_y)
        {
            this.extraLife = extraLife;
        }

        public int ExtraLife { get => extraLife; set => extraLife = value; }
        public void totalClac()
        {
            if (this.Weapon != null)
            {
                this.Attackpower = this.Attackpower + this.Weapon.AttackPower;
                this.DefencePower = this.DefencePower + this.Weapon.DefensePower;
                this.OriginalLife = this.extraLife + this.OriginalLife;
            }
            else
            {
                this.Attackpower = this.Attackpower;
                this.DefencePower = this.DefencePower;
                this.OriginalLife = this.extraLife + this.OriginalLife;
            }
        }
    }
}
