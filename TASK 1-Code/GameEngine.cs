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
        private 

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

        }


    }
}
