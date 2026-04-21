using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGame
{
    public class SoldierType
    {
        public string Type { get; }
        public string Color { get; }
        public string Animation { get; }

        public SoldierType(string type, string color, string animation)
        {
            Type = type;
            Color = color;
            Animation = animation;

            Console.WriteLine($"Creating type: {type}");
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Displaying {Type} at ({x}, {y}) with color {Color} and animation {Animation}");
        }
    }
}
