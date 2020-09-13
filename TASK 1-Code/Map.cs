using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Create(Tile.TileType.Hero);
            

            for (int i = 0; i < EnemeyArray.Length; i++)
            {
                EnemeyArray[i] = (Enemy)Create(Tile.TileType.Enemey);
            }

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
                    PlaceObject(PlayerObj);
                    return PlayerObj;

                case Tile.TileType.Enemey:
                    Goblin goblin = new Goblin(randomNum.Next(1,MapWidth-1) ,randomNum.Next(1,MapHeight-1));
                    PlaceObject(goblin);
                    return goblin;
                    
                case Tile.TileType.Gold:
                    
                case Tile.TileType.Weapon:
                    
                default:
                    break;
            }
        }

        public Tile PlaceObject(Tile obj)
        {
         return   GameMap[obj.Xvalue, obj.Yvalue];

        }
    }
}
