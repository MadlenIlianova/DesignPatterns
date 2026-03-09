package products;

import interfaces.ITransport;

public class Drone implements ITransport {

    @Override
    public double getMaxCargoKg() {
        return 5;
    }

    @Override
    public String deliver() {
        return "Доставка с ДРОН по въздух";
    }
}
