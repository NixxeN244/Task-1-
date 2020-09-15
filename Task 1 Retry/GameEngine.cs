using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Retry
{
    class GameEngine
    {
        private Map map;
        private static readonly string Hero = "H";
        private static readonly string Goblin = "G";
        private static readonly string Empty = " ";
        private static readonly string Obstacle = "X";

        

        public GameEngine()
        {
           map = new Map(15, 15, 15, 15, 3);
            

        }
        public string ParseMap { get; set; }
      

        public void MovePlayer(Character.Movement move)
        {
            map.UpdateVision();
            if (map.PlayerObj.ReturnMove(Character.Movement.Up)== move)
            {

            }
            if (map.PlayerObj.Char_vision[1].GetType() == typeof(EmptyTile))    //layer going up
            {
                
            }
            else if (map.PlayerObj.Char_vision[2].GetType() == typeof(EmptyTile))
            {
                
            }
            else if (map.PlayerObj.Char_vision[3].GetType() == typeof(EmptyTile))
            {
                
            }
            else if (map.PlayerObj.Char_vision[4].GetType()== typeof(EmptyTile))
            {
                
            }
            else
            {
                
            }


        }

        public override string ToString()   //A method that will return the Map array into a string so that we can see it on the form
        {
            string returnString = "";
           for (int i = 0; i < map.GameMap.GetLength(0); i++)
            {
                for (int k = 0; k < map.GameMap.GetLength(1); k++)
                {
                    if (map.GameMap[i,k].GetType() == typeof(EmptyTile))
                    {
                        returnString += Empty; 
                    }
                    else if (map.GameMap[i,k].GetType() == typeof(ObstacleSubClass))
                    {
                        returnString += Obstacle;
                    }
                    else if (map.GameMap[i,k].GetType() == typeof(Hero))
                    {
                        returnString += Hero;
                    }
                    else if (map.GameMap[i,k].GetType() == typeof(Goblin))
                    {
                        returnString += Goblin;
                    }
                    
                }
                returnString += "\n";
            }
            return returnString;
        }


        public string EnemyStats()
        {
            string returninfo = " ";
            for (int i = 0; i < map.EnemeyArray.Length; i++)
            {
                returninfo += map.EnemeyArray[i].ToString() + "\n";
            }
            return returninfo;
        }
        public string PlayerStatsString()
        {
             return map.PlayerObj.ToString();

        }

    }
}
