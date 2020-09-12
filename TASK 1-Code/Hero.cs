using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_Code
{
    class Hero : Character
    {

        public Hero(int X, int Y, int Hero_HP, int Hero_MaxHP) :base(X,Y,'H')
        {
            this.Damage = 2;
        }
    }
}
