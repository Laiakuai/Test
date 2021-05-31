using Ex3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.tool
{
    class MonCom : IComparer<Monster>
    {
        public int Compare(Monster x, Monster y)
        {
            if (x.Speed > y.Speed)
                return -1;
            else if (x.Speed == y.Speed)
                return 0;
            else
                return 1;
        }
    }
}
