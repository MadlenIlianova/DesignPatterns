package products.apple;

import interfaces.ICharger;

public class AppleCharger implements ICharger {
    @Override
    public String getType() {
        return "USB-C";
    }

    @Override
    public Integer getWatts() {
        return 20;
    }

    @Override
    public void charge() {
        System.out.println("Charging iPhone with USB-C 20W...");
    }
}
