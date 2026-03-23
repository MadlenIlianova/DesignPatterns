using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.products.transports
{
    public class Truck : ITransport
    {
        public double Maxkg => 20000;

        public string Deliver()
        {
            return "Delivering by truck.";
        }
    }
}
