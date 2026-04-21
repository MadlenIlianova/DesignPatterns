using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRestaurant
{
    public class InventoryService
    {
        public bool CheckIngredients(string pizzaType) 
        {
            Console.WriteLine($"Checking ingredients for {pizzaType}");
            return true;
        }
    }
}
