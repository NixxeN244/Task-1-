using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_Code
{
    class Map
    {
        private char[,] gameMap;    //the char array that will be displayed. IE our map UI.
        private Hero playerobj;
        private Enemy[] enemyArray;
        private int mapwidth;
        private int mpaheight;
        private Random randomNum;


        public char[,] GameMap
        {
            get { return gameMap; }
            set { gameMap = value; }
        }

        public Hero PlayerObj
        {
            get { return playerobj; }
            set { playerobj = value; }
        }

        public Enemy[] EnemeyArray
        {
            get { return enemyArray; }
            set { enemyArray = value; }
        }

        public int MapWidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }
        public int MapHeight
        {
            get { return mpaheight; }
            set { mpaheight = value; }
        }
    }
}
