using Logistics.Interfaces;
using Logistics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Creators
{
    public class AirLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Plane();
    }
}
