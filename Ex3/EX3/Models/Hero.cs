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
    class Hero :Person
    {
        [NonSerialized]private PictureBox pictture;
        [NonSerialized] private Label labelCurrentLife; //血量显示

        [NonSerialized] private Label labelCurrentBlood; //血条
        [NonSerialized] private Label labelOriginalBlood;
        public Hero(string name, int originalLife, int attrackPower,int defencePower,int origianl_x, int original_y ) :
            base(name, originalLife, origianl_x, original_y)
        {
            this.Attackpower = attrackPower;
            this.DefencePower = defencePower;
        }
        public Hero()
        {

        }
        public PictureBox Pictture { get => pictture; set => pictture = value; }
        public Label LabelCurrentLife { get => labelCurrentLife; set => labelCurrentLife = value; }
        public Label LabelCurrentBlood { get => labelCurrentBlood; set => labelCurrentBlood = value; }
        public Label LabelOriginalBlood { get => labelOriginalBlood; set => labelOriginalBlood = value; }

        public void Move()
        {
            this.PositionCurrent_x = this.PositionOriginal_x;
            this.PositionCurrent_y = this.PositionOriginal_y;
            this.pictture.Location = new Point(this.PositionOriginal_x, this.PositionOriginal_y);
            this.pictture.Refresh();
        }
        public void Move(Monster mon)
        {
            this.PositionCurrent_x = mon.PositionCurrent_x - 150;
            this.PositionCurrent_y = mon.PositionCurrent_y;
            this.pictture.Location = new Point(this.PositionCurrent_x, this.PositionCurrent_y);
            this.pictture.Refresh();
        }
        public  int attack(Monster mno)
        {
            if (mno.CurrentLife > this.Attackpower - mno.DefencePower)
            {
                mno.CurrentLife = mno.CurrentLife - this.Attackpower + mno.DefencePower;
                return this.Attackpower - mno.DefencePower;
            }
            else
            {
                int temp = mno.CurrentLife;
                mno.CurrentLife = 0;
                return temp;
            }
        }
        public virtual void  HeroAttack(Monster monster)
        {
            if (monster.CurrentLife == 0)
            {
                MessageBox.Show(monster.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Move(monster);
            int tempLife = this.attack(monster); //怪物掉血
            //血条减少长度
            int monsterLifeReduce = (int)(tempLife * 1.0 / monster.OriginalLife * monster.LabelOriginalBlood.Size.Width);
            //设置血条长度
            monster.LabelCurrentBlood.Size = new Size(monster.LabelCurrentBlood.Width - monsterLifeReduce, monster.LabelCurrentBlood.Height);
            //血量文字
            monster.LabelCurrentLife.Text = "血量:" + monster.CurrentLife;
            Thread.Sleep(500);
            this.Move();
            this.pictture.Refresh();
/*            if(monster.CurrentLife == 0)
            {
                MessageBox.Show(monster.Name + "死了", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

    }
}
