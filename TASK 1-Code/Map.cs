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
        private Random randomNum = new Random();


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
            GameMap = new Tile[MapWidth, MapHeight];
            EnemeyArray = new Enemy[numofenemies];
            Create(Tile.TileType.Hero);
            

            for (int i = 0; i < EnemeyArray.Length; i++)
            {
                EnemeyArray[i] = (Enemy)Create(Tile.TileType.Enemey);
            }

        }


        public void UpdateVision()
        {
            PlayerObj.Char_vision[0] = GameMap[PlayerObj.Xvalue,PlayerObj.Yvalue];  //the pos where the player is at that moment
            PlayerObj.Char_vision[1] = GameMap[PlayerObj.Xvalue + 1, PlayerObj.Yvalue]; //To the right of the player 
            PlayerObj.Char_vision[2] = GameMap[PlayerObj.Xvalue, PlayerObj.Yvalue + 1]; //Down from the player
            PlayerObj.Char_vision[3] = GameMap[PlayerObj.Xvalue - 1, PlayerObj.Yvalue]; //Left of the player
            PlayerObj.Char_vision[4] = GameMap[PlayerObj.Xvalue, PlayerObj.Yvalue - 1]; //top of the player

            for (int k = 0; k < EnemeyArray.Length; k++)
            {
                EnemeyArray[k].Char_vision[0] = GameMap[EnemeyArray[k].Xvalue, EnemeyArray[k].Yvalue]; //the pos where the enemy is
                EnemeyArray[k].Char_vision[1] = GameMap[EnemeyArray[k].Xvalue + 1, EnemeyArray[k].Yvalue]; // the right if the pos of the enemy
                EnemeyArray[k].Char_vision[2] = GameMap[EnemeyArray[k].Xvalue, EnemeyArray[k].Yvalue + 1]; //down from the pos of the enemy
                EnemeyArray[k].Char_vision[3] = GameMap[EnemeyArray[k].Xvalue - 1, EnemeyArray[k].Yvalue]; //the left of the pos of the enenmy
                EnemeyArray[k].Char_vision[4] = GameMap[EnemeyArray[k].Xvalue, EnemeyArray[k].Yvalue - 1]; //the top of the enemy pos
            };
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
                    return null;
                case Tile.TileType.Weapon:
                    return null;
                default:
                    return null;
                    
            }
        }

        public void PlaceObject(Tile obj)
        {
            obj = GameMap[obj.Xvalue, obj.Yvalue];

        }
    }
}
