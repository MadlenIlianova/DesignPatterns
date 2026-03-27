package creators;

import interfaces.ITransport;
import products.Ship;
import products.Truck;

public class SeaLogistics extends Logistics {
    @Override
    public ITransport createTransport()
    {
        return new Ship();
    }
}
