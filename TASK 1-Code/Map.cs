using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_Code
{
    class Map
    {
        private Tile[,] gameMap;    //the char array that will be displayed. IE our map UI.
        private Hero playerobj;
        private Enemy[] enemyArray;
        private int mapwidth;
        private int mpaheight;
        private Random randomNum;


        public Tile[,] GameMap
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



        public Map(int minwidth, int maxwidth, int minheight, int maxheight, int numofenemies)
        {
            MapWidth = randomNum.Next(minwidth, maxwidth);
            MapHeight = randomNum.Next(minheight, maxheight);
            GameMap = new  Tile[MapWidth, MapHeight];
            EnemeyArray = new Enemy[numofenemies];
        }


        public void UpdateVision()
        {

        }
        private Tile Create(Tile.TileType type)
        {
            switch (type)
            {
                case Tile.TileType.Hero:
                    PlayerObj.Xvalue = randomNum.Next(1, MapWidth-1);
                    PlayerObj.Yvalue = randomNum.Next(1, MapHeight-1);
                    return PlayerObj;
                    break;
                case Tile.TileType.Enemey:
                    
                    break;
                case Tile.TileType.Gold:
                    break;
                case Tile.TileType.Weapon:
                    break;
                default:
                    break;
            }
        }
    }
}
