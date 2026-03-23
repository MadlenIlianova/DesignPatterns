using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPizza
{
    public interface IPizzaBuilder
    {
        void Reset();
        void SetDough(string dough);
        void SetSauce(string sauce);
        void SetCheese(string cheese);
        void SetTopping(string topping);
        void SetSize(int size);
    }
}
