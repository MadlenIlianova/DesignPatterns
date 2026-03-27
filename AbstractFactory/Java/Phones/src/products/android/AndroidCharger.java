package products.android;

import interfaces.ICharger;

public class AndroidCharger implements ICharger {
    @Override
    public String getType() {
        return "USB-C";
    }

    @Override
    public Integer getWatts() {
        return 45;
    }

    @Override
    public void charge() {
        System.out.println("Charging Samsung with USB-C 45W...");
    }
}
