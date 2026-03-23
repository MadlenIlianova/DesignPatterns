using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Client
{
    public class ClientLogistics
    {
        private ILogisticsFactory _factory;
        private IPriority _priority;

        public ClientLogistics(ILogisticsFactory factory, IPriority priority)
        {
            _factory = factory;
            _priority = priority;
        }

        public void SetFactory(ILogisticsFactory factory)
        {
            _factory = factory;
        }

        public void SetPriority(IPriority priority)
        {
            _priority = priority;
        }

        public void PlanDelivey(ILogisticsFactory factory, IPriority priority)
        {
            ITransport transport = factory.CreateTransport();
            IDriver driver = factory.CreateDriver();
            IRoute route = factory.CreateRoute();

            Console.WriteLine("Planning delivey....");
            Console.WriteLine($"Transport:{transport.Deliver()}");
            Console.WriteLine($"MaxKg:{transport.Maxkg}");
            Console.WriteLine($"Driver:{driver.Name}");
            Console.WriteLine($"Drive:{driver.Drive()}");
            Console.WriteLine($"Route:{route.GetRoute()}");
            Console.WriteLine($"Km:{route.DistanceKm}km");
            Console.WriteLine();
        }
    }
}
