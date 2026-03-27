package factories;

import interfaces.ICharger;
import interfaces.IHeadphones;
import interfaces.IPhoneFactory;
import products.android.AndroidDevice;
import products.apple.AirPods;
import products.apple.AppleCharger;
import products.apple.IPhoneDevice;

public class AppleFactory implements IPhoneFactory {
    @Override
    public AndroidDevice createPhone() {
        return new AndroidDevice();
    }

    @Override
    public ICharger createCharger() {
        return new AppleCharger();
    }

    @Override
    public IHeadphones createHeadphones() {
        return new AirPods();
    }
}
