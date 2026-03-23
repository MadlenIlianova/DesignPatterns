using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.products.drivers
{
    public class EuropeDriver : IDriver
    {
        public string Drive()
        {
            return "Driving in Europe";
        }
        public string Name => "Pavel Petrov";
    }
}
