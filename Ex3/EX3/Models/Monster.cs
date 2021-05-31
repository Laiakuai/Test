using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.Models
{
    [Serializable]
    class Monster : Person
    {
       [NonSerialized] private PictureBox picture;
        [NonSerialized] private Label labelCurrentLife;
        [NonSerialized] private Label labelCurrentBlood; //血条
        [NonSerialized] private Label labelOriginalBlood;
        public Monster(string name, int originalLife, int attackPower, int defencePower, int positionOriginal_x, int positionOriginal_y) :
            base(name, originalLife, positionOriginal_x, positionOriginal_y)
        {
            this.Attackpower = attackPower;
            this.DefencePower = defencePower;
        }
        public Monster()
        {

        }
        public PictureBox Picture { get => picture; set => picture = value; }
        public Label LabelCurrentLife { get => labelCurrentLife; set => labelCurrentLife = value; }
        public Label LabelCurrentBlood { get => labelCurrentBlood; set => labelCurrentBlood = value; }
        public Label LabelOriginalBlood { get => labelOriginalBlood; set => labelOriginalBlood = value; }

        public void Move()
        {
            this.PositionCurrent_x = this.PositionOriginal_x;
            this.PositionCurrent_y = this.PositionOriginal_y;
            this.picture.Location = new Point(this.PositionCurrent_x, PositionCurrent_y);
        }
        public void Move(Hero hero)
        {
            this.PositionCurrent_x = hero.PositionCurrent_x + 150;
            this.PositionCurrent_y = hero.PositionCurrent_y; 
            this.picture.Refresh();
            this.picture.Location = new Point(this.PositionCurrent_x, PositionCurrent_y);
        }
        public virtual int attack(Hero hero)
        {
            if (hero.CurrentLife > this.Attackpower - hero.DefencePower)
            {
                hero.CurrentLife = hero.CurrentLife - this.Attackpower + hero.DefencePower;
                return this.Attackpower - hero.DefencePower;
            }
            else
            {
                int temp = hero.CurrentLife;
                hero.CurrentLife = 0;
                return temp;
            }
        }
        public virtual void MonsterAttack(Hero hero)
        {
            if (hero.CurrentLife == 0)
            {
                MessageBox.Show(hero.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Move(hero);
            int tempLife = this.attack(hero); //怪物掉血
            //血条减少长度
            int monsterLifeReduce = (int)(tempLife * 1.0 / hero.OriginalLife * hero.LabelOriginalBlood.Size.Width);
            //设置血条长度
            hero.LabelCurrentBlood.Size = new Size(hero.LabelCurrentBlood.Width - monsterLifeReduce, hero.LabelCurrentBlood.Height);
            hero.LabelCurrentBlood.Refresh();
            Thread.Sleep(20);
            hero.LabelCurrentBlood.Refresh();
            //血量文字
            hero.LabelCurrentLife.Text = "血量:" + hero.CurrentLife;
            hero.LabelCurrentLife.Refresh();
            Thread.Sleep(500);
            this.Move();
            this.picture.Refresh();
/*            if (hero.CurrentLife == 0)
            {
                MessageBox.Show(hero.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
