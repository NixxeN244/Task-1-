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
        
        }

        public override string ToString()   //override method that returns a string that shows the enemy type, it X and Y values as well as it's damage
        {
          return string.Format(this.GetType() + " at " + "[" + this.Xvalue + ", " + this.Yvalue + "]" + "("+ this.Damage +")"); 
        }
    }

    class Goblin : Enemy
    {

        public Goblin(int Xvalue, int Yvalue):base(Xvalue,Yvalue,10,1,'G')
        {


        }

        public override Movement ReturnMove(Movement move )
        {
        
        }





    }
}
