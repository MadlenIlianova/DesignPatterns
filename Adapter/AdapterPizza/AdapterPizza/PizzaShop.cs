using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPizza
{
    public class PizzaShop // Client
    {
        private IModernPizzaService _pizzaService;

        public PizzaShop(IModernPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public void Order(string pizzaType) 
        {
        string result = _pizzaService.OrderPizza(pizzaType);
            Console.WriteLine($"Поръчка: {result}");
        }
    }
}
