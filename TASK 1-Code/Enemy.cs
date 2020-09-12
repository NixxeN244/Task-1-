using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_Code
{
    class Enemy : Character
    {
        //commit changes
        protected Random randomobj;

        public Random Randomobj
        {
            get { return randomobj; }
            set { randomobj = value; }
        }

        public Enemy(int Xvalue, int Yvalue, int max_HP, int Enemy_dmage, char symbol) : base(Xvalue, Yvalue, symbol)
        {
            Xvalue = this.Xvalue;
            Yvalue = this.Yvalue;
            max_HP = this.Max_HP;
            Enemy_dmage = this.Damage;
        }

        public override string ToString()
        {
          return string.Format(this.GetType().ToString() + this.Xvalue + this.Yvalue + this.Damage); 
        }
    }
}
