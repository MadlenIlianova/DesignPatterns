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
    public class AsiaLogistics : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Ship();
        }

        public IDriver CreateDriver()
        {
            return new AsiaDriver();
        }

        public IRoute CreateRoute()
        {
            return new AsiaRoute();
        }
    }
}
