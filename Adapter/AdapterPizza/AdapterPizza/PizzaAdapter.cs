using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPizza
{
    public class PizzaAdapter : IModernPizzaService //Adapter
    {
        private ItalianPizza _italianPizza;

        public PizzaAdapter()
        {
            _italianPizza = new ItalianPizza();
        }

        public string OrderPizza(string pizzaType)
        {
            if (pizzaType == "Margherita") 
            {
            return _italianPizza.MakeMargherita();
            }
            else if (pizzaType == "Pepperoni")
            {
                return _italianPizza.MakePepperoni();
            }
            else
            {
                return $"Извините, {pizzaType} не се поддържа.";
            }
        }
    }
}
