using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex3.Models
{
    //魔法师类  总攻击力等于 魔法攻击 +物理攻击 
    [Serializable]
    class Magician:Hero
    {
        private int abilityPower;
        [NonSerialized] private PictureBox technicalAbility;
        [NonSerialized] private Timer timTechAbility;
        public Magician(string name, int originalLife, int attrackPower,int abilityPower,int defencePower, int origianl_x, int original_y) :
            base(name,originalLife,attrackPower,defencePower,origianl_x,original_y)
        {
            this.abilityPower = abilityPower;
        }
        public int AbilityPower { get => abilityPower; set => abilityPower = value; }
        public Timer TimTechAbility { get => timTechAbility; set => timTechAbility = value; }
        public PictureBox TechnicalAbility { get => technicalAbility; set => technicalAbility = value; }

        public void totalClac()
        {
            if (this.Weapon != null)
            {
                this.Attackpower = this.Attackpower + this.Weapon.AttackPower + this.AbilityPower;
                this.DefencePower = this.DefencePower + this.Weapon.DefensePower;
            }
            else
            {
                this.Attackpower = this.Attackpower  + this.AbilityPower;
                this.DefencePower = this.DefencePower;
            }
        }
        public void AblityMove()
        {
            this.technicalAbility.Location = new Point(this.Pictture.Location.X + 100, this.Pictture.Location.Y);
            this.technicalAbility.Show();
            this.technicalAbility.Refresh();
            System.Threading.Thread.Sleep(20);
            this.timTechAbility.Start();
        }
        public void AblityMove2(Monster monster)
        {
            this.technicalAbility.Location = new Point(this.Pictture.Location.X + 100, this.Pictture.Location.Y);
            this.technicalAbility.Show();
            int tempX = monster.Picture.Location.X - this.Pictture.Location.X - 50;
            int tempY = monster.Picture.Location.Y - this.Pictture.Location.Y;
            while(this.technicalAbility.Location.X < monster.Picture.Location.X - 50)
            {
                this.technicalAbility.Location = new Point(this.technicalAbility.Location.X + tempX / 20, this.technicalAbility.Location.Y + tempY / 20);
                System.Threading.Thread.Sleep(20);
                this.technicalAbility.Refresh();
            }
            this.technicalAbility.Hide();
        }
        public override void HeroAttack(Monster monster)
        {
            if (monster.CurrentLife == 0)
            {
                MessageBox.Show(monster.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.AblityMove2(monster);
            int tempLife = this.attack(monster); //怪物掉血
            //血条减少长度
            int monsterLifeReduce = (int)(tempLife * 1.0 / monster.OriginalLife * monster.LabelOriginalBlood.Size.Width);
            //设置血条长度
            monster.LabelCurrentBlood.Size = new Size(monster.LabelCurrentBlood.Width - monsterLifeReduce, monster.LabelCurrentBlood.Height);
            //血量文字
            monster.LabelCurrentLife.Text = "血量:" + monster.CurrentLife;
            /*            if (monster.CurrentLife == 0)
                        {
                            MessageBox.Show(monster.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
            monster.LabelCurrentLife.Refresh();
            System.Threading.Thread.Sleep(500);
        }

    }
}
