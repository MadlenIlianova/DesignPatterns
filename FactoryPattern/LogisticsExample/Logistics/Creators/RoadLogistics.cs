using Logistics.Interfaces;
using Logistics.Products;

namespace Logistics.Creators
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Truck();     
    }
}
