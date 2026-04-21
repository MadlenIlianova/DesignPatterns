using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGame
{
    public class Soldier
    {
        private SoldierType _type;
        private int _x;
        private int _y;

        public Soldier(SoldierType type, int x, int y)
        {
            _type = type;
            _x = x;
            _y = y;
        }

        public void Display() => _type.Display(_x, _y);
    }
}
