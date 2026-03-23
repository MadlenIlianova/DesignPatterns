using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPizza
{
    public class Director
    {
        private IPizzaBuilder builder;

        public IPizzaBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildMargheritaPizza()
        {
            builder.Reset();
            builder.SetDough("Thin crust");
            builder.SetSauce("Tomato");
            builder.SetCheese("Mozzarella");
            builder.SetTopping("Basil");
            builder.SetSize(30);
        }

        public void BuildPepperoniPizza()
        {
            builder.Reset();
            builder.SetDough("Thick crust");
            builder.SetSauce("Tomato");
            builder.SetCheese("Cheddar");
            builder.SetTopping("Pepperoni");
            builder.SetSize(35);
        }
    }
}
