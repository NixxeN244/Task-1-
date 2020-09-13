using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_Code
{
    class GameEngine 
    {
        private Map map;
        private static readonly char Hero = 'H';
        private static readonly char Goblin= 'G';
        private static readonly char Empty= ' ';
        private static readonly char Obstacle= 'X';


        public GameEngine()
        {
            Map gameMap = new Map(1,11,1,11,3);
            
        }
        public Map Gmap
        {
            get { return map; }
            set { map = value; }
        }

        public bool MovePlayer()
        {
            return true;
        }

        public override string ToString()
        {
            string parseMap;
            for (int i = 0; i < Gmap.GameMap.GetLength(0); i++)
            {
                for (int k = 0; k < Gmap.GameMap.GetLength(1); k++)
                {
                    parseMap = Gmap.GameMap[i, k].ToString();
                }
                parseMap += "\n";
            }

        }

    }
}
