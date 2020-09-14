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
           map = new Map(10, 10, 10, 10, 2);

        }
        public string ParseMap { get; set; }
        /*  public Map Gmap
          {
              get { return map; }
              set { map = value; }
          }*/

        public bool MovePlayer()
        {
            return true;
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
    }
}
