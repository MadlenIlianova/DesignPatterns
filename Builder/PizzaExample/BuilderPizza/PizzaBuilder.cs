using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPizza
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            pizza = new Pizza();
        }

        public void SetDough(string dough) => pizza.Dough = dough;
        public void SetSauce(string sauce) => pizza.Sauce = sauce;
        public void SetCheese(string cheese) => pizza.Cheese = cheese;
        public void SetTopping(string topping) => pizza.Topping = topping;
        public void SetSize(int size) =>    pizza.Size = size;
        public Pizza GetProduct()
        {
            Pizza result = pizza;
            Reset();
            return result;
        }
    }
}
