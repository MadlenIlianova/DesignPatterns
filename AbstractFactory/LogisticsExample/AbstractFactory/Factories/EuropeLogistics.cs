using AbstractFactory.interfaces;
using AbstractFactory.products.drivers;
using AbstractFactory.products.routes;
using AbstractFactory.products.transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.factories
{
    public class EuropeLogistics : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }

        public IDriver CreateDriver()
        {
            return new EuropeDriver();
        }

        public IRoute CreateRoute()
        {
            return new EuropeRoute();
        }    
    }
}
