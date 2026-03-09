package creators;

import interfaces.ILogistics;
import interfaces.ITransport;

public abstract class Logistics implements ILogistics {
    public abstract ITransport createTransport();

    @Override
    public void planDelivery() {
        ITransport transport = createTransport();
        System.out.println("Планиране на доставка...");
        System.out.println("Максимален товар: " + transport.getMaxCargoKg() + " кг");
        System.out.println(transport.deliver());
    }
}
