using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPizza
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public string Topping { get; set; }
        public int Size { get; set; }

        public string ListParts()
        {
            return $"Dough: {Dough}, Sauce: {Sauce}, " +
                   $"Cheese: {Cheese}, Topping: {Topping}, Size: {Size} см";
        }
    }
}
