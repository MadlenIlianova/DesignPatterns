package products.apple;

import interfaces.IPhone;

public class IPhoneDevice implements IPhone {
    @Override
    public String getModel() {
        return "iPhone 15 Pro";
    }

    @Override
    public String getOS() {
        return "iOS 17";
    }

    @Override
    public void makeCall() {
        System.out.println("Calling with iPhone...");
    }
}
