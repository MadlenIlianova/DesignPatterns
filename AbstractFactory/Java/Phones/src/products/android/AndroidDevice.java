package products.android;

import interfaces.IPhone;

public class AndroidDevice implements IPhone {
    @Override
    public String getModel() {
        return "Samsung Galaxy S24";
    }

    @Override
    public String getOS() {
        return "Android 14";
    }

    @Override
    public void makeCall() {
        System.out.println("Calling with Samsung Galaxy...");
    }
}
