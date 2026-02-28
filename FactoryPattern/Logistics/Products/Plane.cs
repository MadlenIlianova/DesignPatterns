using Logistics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Products
{
    public class Plane : ITransport
    {
        public double MaxKg => 50000;
        public string Deliver() => "Delivering by plane";
    }
}
