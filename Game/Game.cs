using System;
using TreehouseDefence;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower();
            Map map = new Map();
            map.width = 8;
            map.height = 5;

            int area = map.width * map.height;
        }
    }
}
