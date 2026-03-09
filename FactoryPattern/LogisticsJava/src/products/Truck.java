package products;
import interfaces.ITransport;

public class Truck implements ITransport {
    @Override
    public double getMaxCargoKg() {
        return 20000;
    }

    @Override
    public String deliver() {
        return "Доставка с КАМИОН по шосе";
    }
}
