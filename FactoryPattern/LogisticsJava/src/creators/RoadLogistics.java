package creators;

import interfaces.ITransport;
import products.Truck;

public class RoadLogistics extends Logistics{
    @Override
    public ITransport createTransport()
    {
        return new Truck();
    }
}
