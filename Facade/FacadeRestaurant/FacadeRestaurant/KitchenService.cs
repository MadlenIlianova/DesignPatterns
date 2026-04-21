using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRestaurant
{
    public class KitchenService
    {
        public void CookPizza(string pizzaType) 
        {
            Console.WriteLine($"Cooking {pizzaType}");
        }
    }
}
