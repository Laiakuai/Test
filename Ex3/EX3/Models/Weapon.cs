using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Models
{
    [Serializable]
    class Weapon
    {
        private int attackPower;

        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }
        private int defensePower;

        public int DefensePower
        {
            get { return defensePower; }
            set { defensePower = value; }
        }
        private int lucky;

        public int Lucky
        {
            get { return lucky; }
            set { lucky = value; }
        }
    }
}
