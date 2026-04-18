using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPizza
{
    public interface IModernPizzaService 
    {
        string OrderPizza(string pizzaType);
    }
}
