package creators;

import interfaces.ITransport;
import products.Drone;
import products.Ship;

public class AirLogistics extends Logistics {
    @Override
    public ITransport createTransport()
    {
        return new Drone();
    }
}
