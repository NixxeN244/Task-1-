using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Retry
{
    class Hero : Character
    {
        public Hero(int X, int Y, int Hero_HP, int Hero_MaxHP) : base(X, Y, 'H')
        {
            this.HP = Hero_HP;
            this.Max_HP = Hero_MaxHP;
            this.Damage = 2;
            this.Xvalue = X;
            this.Yvalue = Y;
        }

        public override Movement ReturnMove(Movement move )
        {
            switch (move)
            {
                case Movement.No_movement:
                    return Movement.No_movement;
                    
                case Movement.Up:
                    return Movement.Up;
                    
                case Movement.Down:
                    return Movement.Down;
                    
                case Movement.Left:
                    return Movement.Left;
                    
                case Movement.Right:
                    return Movement.Right;
                    
                default:
                    return Movement.No_movement;
            }

        }

        public override string ToString()
        {
            return string.Format("Player Stats: \n" + "HP: " + this.HP + "/ " + this.Max_HP + "\n" +
                                    "Damage: " + this.Damage +  "\n" + "[" + this.Xvalue + "," + this.Yvalue + "]");
        }
    }
}
