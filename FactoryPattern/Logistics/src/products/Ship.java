package products;
import interfaces.ITransport;

public class Ship implements ITransport {
    @Override
    public double getMaxCargoKg() {
        return 500000;
    }

    @Override
    public String deliver() {
        return "Доставка с КОРАБ по море";
    }
}
