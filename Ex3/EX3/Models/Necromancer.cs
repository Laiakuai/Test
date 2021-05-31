using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.Models
{
    //亡灵巫师类  低血量，有魔法伤害 有高额魔法伤害
    [Serializable]
    class Necromancer:Monster
    {
        private int abilityPower;
        private int extraLife;   // 这个值要为负值因为亡灵巫师血量比普通怪物少

        [NonSerialized] private PictureBox picAbilityNer;
        [NonSerialized] private Timer timerAbilityNer;
        public Necromancer(string name, int originalLife,int attackPower, int defencePower, int positionOriginal_x, int positionOriginal_y,int abilityPower,int extraLife) 
            :base(name,originalLife,attackPower,defencePower,positionOriginal_x,positionOriginal_y)

        {   
            this.abilityPower = abilityPower;
            this.extraLife = extraLife;
        }

        public int ExtraLife { get => extraLife; set => extraLife = value; }
        public int AbilityPower { get => abilityPower; set => abilityPower = value; }
        public PictureBox PicAbilityNer { get => picAbilityNer; set => picAbilityNer = value; }
        public Timer TimerAbilityNer { get => timerAbilityNer; set => timerAbilityNer = value; }

        public void totalClac()
        {
            if (this.Weapon != null)
            {
                this.Attackpower = this.abilityPower + this.Attackpower + this.Weapon.DefensePower;
                this.DefencePower = this.DefencePower + this.Weapon.DefensePower;
                this.OriginalLife = this.OriginalLife + this.extraLife;
            }
            else
            {
                this.Attackpower = this.abilityPower + this.Attackpower;
                this.DefencePower = this.DefencePower;
                this.OriginalLife = this.OriginalLife + this.extraLife;
            }
        }
        public void AblityMove()
        {
            this.picAbilityNer.Location = new Point(this.Picture.Location.X -100, this.Picture.Location.Y);
            this.picAbilityNer.Show();
            this.picAbilityNer.Refresh();
            System.Threading.Thread.Sleep(20);
            this.timerAbilityNer.Start();
        }
        public void AblityMove2(Hero hero)
        {
            this.picAbilityNer.Location = new Point(this.Picture.Location.X - 100, this.Picture.Location.Y);
            this.picAbilityNer.Show();
            int tempX = hero.Pictture.Location.X - this.Picture.Location.X + 200;
            int tempY = hero.Pictture.Location.Y - this.Picture.Location.Y;
            while (this.picAbilityNer.Location.X > hero.Pictture.Location.X + 100)
            {
                this.picAbilityNer.Location = new Point(this.picAbilityNer.Location.X + tempX / 20, this.picAbilityNer.Location.Y + tempY / 20);
                this.picAbilityNer.Refresh();
                System.Threading.Thread.Sleep(20);
            }
            this.picAbilityNer.Hide();
        }
        public override void MonsterAttack(Hero hero)
        {
            if (hero.CurrentLife == 0)
            {
                MessageBox.Show(hero.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.AblityMove2(hero);
            int tempLife = this.attack(hero); //怪物掉血
            //血条减少长度
            int monsterLifeReduce = (int)(tempLife * 1.0 / hero.OriginalLife * hero.LabelOriginalBlood.Size.Width);
            //设置血条长度
            hero.LabelCurrentBlood.Size = new Size(hero.LabelCurrentBlood.Width - monsterLifeReduce, hero.LabelCurrentBlood.Height);
            //血量文字
            hero.LabelCurrentLife.Text = "血量:" + hero.CurrentLife;
            hero.LabelCurrentLife.Refresh();
            /*            if (hero.CurrentLife == 0)
                        {
                            MessageBox.Show(hero.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
            System.Threading.Thread.Sleep(500);
        }
    }
}
