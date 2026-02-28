using Logistics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Creators
{
    public abstract class Logistics : ILogistics
    {
        public abstract ITransport CreateTransport();
        public void PlanDelivery() 
        {
        ITransport transport = CreateTransport();
            Console.WriteLine(transport.Deliver());
        }
    }
}
