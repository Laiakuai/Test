using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Models
{
    [Serializable]
    class Person:IComparable<Person>,ISuperAttack
    {
        private int positionOriginal_x;
        private int positionOriginal_y;
        private int positionCurrent_x;
        private int positionCurrent_y;
        private string name;
        private int currentLife;
        private int originalLife;
        private Weapon weapon;
        private int attackpower;
        private int defencePower;
        private int lucky;
        private int speed;
        private int lei;
        private int type;
        private int isSupperAttack;
        private Person hatePerson;
        private int ishated;
        public Person()
        {
        }

        public Person(string name, int originalLife, int positionOriginal_x, int positionOriginal_y)
        {
            this.positionOriginal_x = positionOriginal_x;
            this.positionOriginal_y = positionOriginal_y;
            this.name = name;
            this.originalLife = originalLife;
        }

        public int PositionOriginal_x { get => positionOriginal_x; set => positionOriginal_x = value; }
        public int PositionOriginal_y { get => positionOriginal_y; set => positionOriginal_y = value; }
        public int PositionCurrent_x { get => positionCurrent_x; set => positionCurrent_x = value; }
        public int PositionCurrent_y { get => positionCurrent_y; set => positionCurrent_y = value; }
        public string Name { get => name; set => name = value; }
        public int CurrentLife { get => currentLife; set => currentLife = value; }
        public int OriginalLife { get => originalLife; set => originalLife = value; }
        public int Attackpower { get => attackpower; set => attackpower = value; }
        public int DefencePower { get => defencePower; set => defencePower = value; }
        public int Lucky { get => lucky; set => lucky = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Lei { get => lei; set => lei = value; }
        public int Type { get => type; set => type = value; }
        public int IsSupperAttack { get => isSupperAttack; set => isSupperAttack = value; }
        public int Ishated { get => ishated; set => ishated = value; }
        internal Weapon Weapon { get => weapon; set => weapon = value; }
        internal Person HatePerson { get => hatePerson; set => hatePerson = value; }

        public void BackPower()
        {
            if(this.isSupperAttack == 1 &&ishated ==0) //暴击而且不憎恨 必须有武器
            {
                this.attackpower = (int)(this.attackpower * 2.0/3);
                this.weapon.AttackPower = (int)(this.weapon.AttackPower * 2.0/3);
                this.isSupperAttack = 0;
            }
            else if(this.isSupperAttack == 1 && ishated == 1)  //暴击不憎恨 可以没有武器可以有武器 分两种情况
            {
                if (this.weapon != null)
                {
                    this.attackpower = (int)(this.attackpower * 2);
                    this.weapon.AttackPower = (int)(this.weapon.AttackPower * 2);
                    this.isSupperAttack = 0;
                }
                else
                {
                    this.attackpower = (int)(this.attackpower * 2);
                    this.isSupperAttack = 0;
                }
            }
        }

        public void ChangeAttack()
        {
            if (this.weapon!=null&&this.weapon.Lucky!=0 && this.ishated ==0)   //武器不为空，武器攻击力不为空，而且不处于憎恨状态
            {
                int lucky0 = this.weapon.Lucky;
                Random ran = new Random();
                int n = ran.Next(0, 100);
                if (n <= lucky0)
                {
                    this.isSupperAttack = 1;
                    this.attackpower = (int)(this.attackpower * 3.0/2);
                    this.weapon.AttackPower = (int)(this.weapon.AttackPower * 3.0/2);
                }
            }
            else if(this.ishated == 1)  // 处于憎恨状态
            {
                int lucky0 = 0;
                if (this.weapon == null) {   //武器为空
                    lucky0 = 50;
                    Random ran = new Random();
                    int n = ran.Next(0, 100);
                    if (n <= lucky0)
                    {
                        this.isSupperAttack = 1;
                        this.attackpower = (int)(this.attackpower * 2);
                    }
                }
                else    //武器不为空
                {
                    lucky0 = this.weapon.AttackPower + 50;
                    Random ran = new Random();
                    int n = ran.Next(0, 100);
                    if (n <= lucky0)
                    {
                        this.isSupperAttack = 1;
                        this.attackpower = (int)(this.attackpower * 2);
                        this.weapon.AttackPower = (int)(this.weapon.AttackPower * 2);
                    }
                }
            }
        }

        public int CompareTo(object obj)
        {
            return speed.CompareTo(obj);
        }

        public int CompareTo(Person other)
        {
            if (this.speed > other.speed)
                return -1;
            else if (this.speed == other.speed)
                return 0;
            else
                return 1;
        }
    }
}
