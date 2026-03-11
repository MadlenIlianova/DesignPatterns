using Logistics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Products
{
    public class Ship : ITransport
    {
        public double MaxKg => 1000000;
        public string Deliver() => "Delivering by ship";
    }
}
