using Logistics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Logistics.Products
{
    public class Truck : ITransport
    {
        public double MaxKg => 20000;
        public string Deliver() => "Delivering by truck";
    }
}
