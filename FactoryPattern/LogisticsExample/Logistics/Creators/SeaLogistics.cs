using Logistics.Interfaces;
using Logistics.Products;

namespace Logistics.Creators
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Ship();
    }
}
