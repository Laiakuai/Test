using Ex3.Models;
using Ex3.tool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class FrmMain : Form
    {
        List<Hero> heroes = new List<Hero>();
        List<Monster> mones = new List<Monster>();
        List<Person> people = new List<Person>();
        int tempX;
        int tempY;
        Hero hero;
        Monster monster;
        Warrior war;
        Magician mag;
        Minotaur min;
        Necromancer ner;
        int HuiHe;
        Thread thread = null;
        int flag = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        public void init()
        {
            HuiHe = 0;
            flag = 0;

            people.Clear();
            heroes.Clear();
            mones.Clear();

            war = new Warrior("Warrior", 5000, 500, 800, 300, 0, 0);
            mag = new Magician("Magician", 4000, 500, 1000, 200, 0, 0);
            min = new Minotaur("Minotaur", 6000, 2000, 300, 800, 0, 0);
            ner = new Necromancer("Necromancer", 4000, 500, 100, 0, 0, 1000, -1000);
            hero = null;
            monster = null;
            //图片和对象相互联系
            //勇者类
            war.Speed = 200;
            war.Pictture = picWarrior;

            war.totalClac();

            war.LabelCurrentLife = labelWarriorLife;
            war.LabelCurrentLife.Text = "血量:" + war.OriginalLife;

            war.LabelCurrentBlood = lblWarriorCurrentLife; //血条 
            war.LabelOriginalBlood = lblWarriorOriginalLife;
            war.LabelCurrentBlood.Size = war.LabelOriginalBlood.Size;

            war.PositionOriginal_x = picWarrior.Location.X;
            war.PositionOriginal_y = picWarrior.Location.Y;
            war.PositionCurrent_x = war.PositionOriginal_x;
            war.PositionCurrent_y = war.PositionOriginal_y;

            war.CurrentLife = war.OriginalLife;

            //魔法师类
            mag.Speed = 100;
            mag.TechnicalAbility = picTechAbility;//技能
            mag.TimTechAbility = timerability;//Timer控件

            mag.Pictture = picMagician;

            mag.totalClac();

            mag.LabelCurrentLife = labelMagicianLife;
            mag.LabelCurrentLife.Text = "血量:" + mag.OriginalLife;

            mag.LabelOriginalBlood = lblMagicianOriginalLife;
            mag.LabelCurrentBlood = lblMagicianCurrentLife;
            mag.LabelCurrentBlood.Size = mag.LabelOriginalBlood.Size;

            mag.PositionOriginal_x = picMagician.Location.X;
            mag.PositionOriginal_y = picMagician.Location.Y;
            mag.PositionCurrent_x = mag.PositionOriginal_x;
            mag.PositionCurrent_y = mag.PositionOriginal_y;

            mag.CurrentLife = mag.OriginalLife;
            //牛头怪类
            min.Speed = 50;
            min.Picture = picMinotaur;

            min.totalClac();

            min.LabelCurrentBlood = lblMinotaurCurrentLife;
            min.LabelOriginalBlood = lblMagicianOriginalLife;
            min.LabelCurrentBlood.Size = min.LabelOriginalBlood.Size;

            min.PositionOriginal_x = picMinotaur.Location.X;
            min.PositionOriginal_y = picMinotaur.Location.Y;
            min.PositionCurrent_x = min.PositionOriginal_x;
            min.PositionCurrent_y = min.PositionOriginal_y;

            min.CurrentLife = min.OriginalLife;

            min.LabelCurrentLife = labelMinotaurLife;
            min.LabelCurrentLife.Text = "血量:" + min.OriginalLife;
            //亡灵法师类
            ner.Speed = 100;
            ner.TimerAbilityNer = timerAbilityNer;
            ner.PicAbilityNer = picTechAbilityNer;   //技能释放

            ner.Picture = picNecromancer;

            ner.totalClac();

            ner.LabelOriginalBlood = lblNecromancerOriginalLife;
            ner.LabelCurrentBlood = lblNecromancerCurrentLife;
            ner.LabelCurrentBlood.Size = ner.LabelOriginalBlood.Size;

            ner.PositionOriginal_x = picNecromancer.Location.X;
            ner.PositionOriginal_y = picNecromancer.Location.Y;
            ner.PositionCurrent_x = ner.PositionOriginal_x;
            ner.PositionCurrent_y = ner.PositionOriginal_y;

            ner.CurrentLife = ner.OriginalLife;

            ner.LabelCurrentLife = labelNecromancerLife;
            ner.LabelCurrentLife.Text = "血量:" + ner.OriginalLife;


            //List hero 和 List mones
            mag.Lei = 1;
            war.Lei = 1;
            ner.Lei = 2;
            min.Lei = 2;
            //List type
            mag.Type = 1;
            war.Type = 2;
            ner.Type = 3;
            min.Type = 4;
            //相互憎恨
            mag.HatePerson = min;
            min.HatePerson = mag;
            ner.HatePerson = war;
            war.HatePerson = ner;

            people.Add(mag);
            people.Add(war);
            people.Add(ner);
            people.Add(min);
            people.Sort();
            heroes.Add(mag);
            heroes.Add(war);
            mones.Add(min);
            mones.Add(ner);
            heroes.Sort(new HeroCom());
            mones.Sort(new MonCom());
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            init();
            timerability.Interval = 50;
            timerability.Enabled = false;
            timerAbilityNer.Interval = 50;
            timerAbilityNer.Enabled = false;
        }

        private void picMagician_Click(object sender, EventArgs e)
        {
            if (mag.CurrentLife == 0)
            {
                MessageBox.Show(mag.Name + "死了,请选择另一个英雄，如果都死了请重新开始", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                hero = mag;
            }

        }

        private void picWarrior_Click(object sender, EventArgs e)
        {
            if (war.CurrentLife == 0)
            {
                MessageBox.Show(war.Name + "死了,请选择另一个英雄，如果都死了请重新开始", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                hero = war;
            }
        }

        private void picNecromancer_Click(object sender, EventArgs e)
        {
            if (ner.CurrentLife == 0)
            {
                MessageBox.Show(ner.Name + "死了,请选择另一个怪物，如果都死了请重新开始", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                monster = ner;
            }
        }

        private void picMinotaur_Click(object sender, EventArgs e)
        {
            if (min.CurrentLife == 0)
            {
                MessageBox.Show(min.Name + "死了,请选择另一个怪物，如果都死了请重新开始", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                monster = min;
            }
        }

        private void buttonHeroAttack_Click(object sender, EventArgs e)
        {
            if (hero == null || monster == null)
            {
                MessageBox.Show("没有选择英雄或者怪物，请点击图片选择后再打", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tempX = monster.Picture.Location.X - hero.Pictture.Location.X - 50;
            tempY = monster.Picture.Location.Y - hero.Pictture.Location.Y;
            hero.HeroAttack(monster);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            init();
        }

        private void timerability_Tick(object sender, EventArgs e)
        {
            int x = picTechAbility.Location.X + tempX / 30;
            int y = picTechAbility.Location.Y + tempY / 30;
            if (x >= monster.Picture.Location.X - 50)
            {
                picTechAbility.Hide();
                timerability.Stop();
            }
            picTechAbility.Location = new Point(x, y);
            picTechAbility.Refresh();
        }

        private void buttonMonsterAttack_Click(object sender, EventArgs e)
        {
            if (hero == null || monster == null)
            {
                MessageBox.Show("没有选择英雄或者怪物，请点击图片选择后再打", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tempX = hero.Pictture.Location.X - monster.Picture.Location.X + 200;
            tempY = hero.Pictture.Location.Y - monster.Picture.Location.Y;
            monster.MonsterAttack(hero);
        }

        private void timerAbilityNer_Tick(object sender, EventArgs e)
        {
            int x = picTechAbilityNer.Location.X + tempX / 25;
            int y = picTechAbilityNer.Location.Y + tempY / 25;
            if (x <= hero.Pictture.Location.X + 100)
            {
                picTechAbilityNer.Hide();
                timerAbilityNer.Stop();
            }
            picTechAbilityNer.Location = new Point(x, y);
            picTechAbilityNer.Refresh();
        }
        private void attack()
        {
            people.Sort();
            heroes.Sort(new HeroCom());
            mones.Sort(new MonCom());
            while (heroes.Count != 0 && mones.Count != 0)
            {
                while (HuiHe < people.Count && heroes.Count != 0 && mones.Count != 0)
                {
                    if (people[HuiHe].Lei == 1) //1为英雄2为怪物，如果为0则无法攻击也无法被打 
                    {
                        hero = people[HuiHe] as Hero;
                        Random ran = new Random();
                        int n = ran.Next(0, mones.Count);
                        monster = mones[n];
                        if(monster == hero.HatePerson)
                        {
                            hero.Ishated = 1;
                        }
                        hero.ChangeAttack();
                        hero.HeroAttack(monster);
                        hero.BackPower();
                        this.Refresh();
                        Thread.Sleep(1000);
                        //判断怪物是否没血
                        if (monster.CurrentLife <= 0)
                        {
                            mones.Remove(monster);
                            monster.Lei = 0;
                        }
                    }
                    else if (people[HuiHe].Lei == 2)
                    {
                        Monster monster = people[HuiHe] as Monster;
                        Random ran = new Random();
                        int n = ran.Next(0, heroes.Count);
                        hero = heroes[n];
                        if (hero == monster.HatePerson)
                        {
                            monster.Ishated = 1;
                        }
                        monster.ChangeAttack();
                        monster.MonsterAttack(hero);
                        monster.BackPower();
                        this.Refresh();
                        Thread.Sleep(1000);
                        //判断英雄是否没血
                        if (hero.CurrentLife <= 0)
                        {
                            heroes.Remove(hero);
                            hero.Lei = 0;
                        }
                    }
                    HuiHe++;
                }
                HuiHe = 0;
                if (heroes.Count == 0)
                {
                    MessageBox.Show("所有英雄死亡，怪物获胜", "怪物获胜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (mones.Count == 0)
                {
                    MessageBox.Show("所有怪物死亡，英雄获胜", "英雄获胜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e) //自动对打
        {
            thread = new Thread(attack);
            thread.Start();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //personmanager.save(people, huihe);
            PersonManager.Save2(people, HuiHe);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //init();
            //PersonManager.Load(people); //读取数据
            ////四个英雄的血条根据读取之后的当前血量进行改变
            //war.LabelCurrentLife.Text = "血量:" + war.CurrentLife;
            //int Temp = (int)(war.CurrentLife * 1.0 / war.OriginalLife * war.LabelOriginalBlood.Size.Width);
            //war.LabelCurrentBlood.Size = new Size(Temp, war.LabelOriginalBlood.Size.Height);

            //mag.LabelCurrentLife.Text = "血量:" + mag.CurrentLife;
            //Temp = (int)(mag.CurrentLife * 1.0 / mag.OriginalLife * mag.LabelOriginalBlood.Size.Width);
            //mag.LabelCurrentBlood.Size = new Size(Temp, mag.LabelOriginalBlood.Size.Height);

            //ner.LabelCurrentLife.Text = "血量:" + ner.CurrentLife;
            //Temp = (int)(ner.CurrentLife * 1.0 / ner.OriginalLife * ner.LabelOriginalBlood.Size.Width);
            //ner.LabelCurrentBlood.Size = new Size(Temp, ner.LabelOriginalBlood.Size.Height);

            //min.LabelCurrentLife.Text = "血量:" + min.CurrentLife;
            //Temp = (int)(min.CurrentLife * 1.0 / min.OriginalLife * ner.LabelOriginalBlood.Size.Width);
            //min.LabelCurrentBlood.Size = new Size(Temp, min.LabelOriginalBlood.Size.Height);
            //Refresh();

            //heroes.Clear();
            //mones.Clear();
            //foreach (Person p in people)  //如果英雄或者怪物已经死亡则不加入对应被攻击的列表。
            //{
            //    if (p.Lei != 0)
            //    {
            //        if (p.Type == 1 || p.Type == 2)
            //        {
            //            heroes.Add((Hero)p);
            //        }
            //        else if (p.Type == 3 || p.Type == 4)
            //        {
            //            mones.Add((Monster)p);
            //        }
            //    }
            //}
            mag = null;
            war = null;
            min = null;
            ner = null;
            people.Clear();
            heroes.Clear();
            mones.Clear();
            people = PersonManager.Load2(ref HuiHe);
            foreach (Person p in people)
            {
                if (p.Type == 1)
                {
                    mag = (Magician)p;
                    mag.TechnicalAbility = picTechAbility;//技能
                    mag.TimTechAbility = timerability;//Timer控件
                    mag.Pictture = picMagician;
                    mag.LabelCurrentLife = labelMagicianLife;
                    mag.LabelOriginalBlood = lblMagicianOriginalLife;
                    mag.LabelCurrentBlood = lblMagicianCurrentLife;
                    mag.LabelCurrentLife.Text = "血量:" + mag.CurrentLife;
                    int Temp = (int)(mag.CurrentLife * 1.0 / mag.OriginalLife * mag.LabelOriginalBlood.Size.Width);
                    mag.LabelCurrentBlood.Size = new Size(Temp, mag.LabelOriginalBlood.Size.Height);

                }
                else if (p.Type == 2)
                {
                    war = (Warrior)p;
                    war.Pictture = picWarrior;
                    war.LabelCurrentLife = labelWarriorLife;
                    war.LabelCurrentBlood = lblWarriorCurrentLife; //血条 
                    war.LabelOriginalBlood = lblWarriorOriginalLife;
                    war.LabelCurrentLife.Text = "血量:" + war.CurrentLife;
                    int Temp = (int)(war.CurrentLife * 1.0 / war.OriginalLife * war.LabelOriginalBlood.Size.Width);
                    war.LabelCurrentBlood.Size = new Size(Temp, war.LabelOriginalBlood.Size.Height);
                }
                else if (p.Type == 3)
                {
                    ner = (Necromancer)p;

                    ner.TimerAbilityNer = timerAbilityNer;
                    ner.PicAbilityNer = picTechAbilityNer;   //技能释放

                    ner.Picture = picNecromancer;
                    ner.LabelCurrentLife = labelNecromancerLife;
                    ner.LabelCurrentBlood = lblNecromancerCurrentLife;
                    ner.LabelOriginalBlood = lblNecromancerOriginalLife;
                    ner.LabelCurrentLife.Text = "血量:" + ner.CurrentLife;
                    int Temp = (int)(ner.CurrentLife * 1.0 / ner.OriginalLife * ner.LabelOriginalBlood.Size.Width);
                    ner.LabelCurrentBlood.Size = new Size(Temp, ner.LabelOriginalBlood.Size.Height);
                }
                else if (p.Type == 4)
                {
                    min = (Minotaur)p;
                    min.Picture = picMinotaur;
                    min.LabelCurrentLife = labelMinotaurLife;
                    min.LabelCurrentBlood = lblMinotaurCurrentLife;
                    min.LabelOriginalBlood = lblMagicianOriginalLife;
                    min.LabelCurrentLife.Text = "血量:" + min.CurrentLife;
                    int Temp = (int)(min.CurrentLife * 1.0 / min.OriginalLife * ner.LabelOriginalBlood.Size.Width);
                    min.LabelCurrentBlood.Size = new Size(Temp, min.LabelOriginalBlood.Size.Height);
                }
            }
            Refresh();
            foreach (Person p in people)  //如果英雄或者怪物已经死亡则不加入对应被攻击的列表。
            {
                if (p.Lei != 0)
                {
                    if (p.Type == 1 || p.Type == 2)
                    {
                        heroes.Add((Hero)p);
                    }
                    else if (p.Type == 3 || p.Type == 4)
                    {
                        mones.Add((Monster)p);
                    }
                }
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PersonManager.Save2(people, HuiHe);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonManager.Save2(people, HuiHe);
        }
    }
}
