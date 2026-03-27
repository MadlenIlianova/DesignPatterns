package factories;

import interfaces.ICharger;
import interfaces.IHeadphones;
import interfaces.IPhoneFactory;
import products.android.AndroidCharger;
import products.android.AndroidDevice;
import products.android.AndroidHeadphones;

public class AndroidFactory implements IPhoneFactory {
    @Override
    public AndroidDevice createPhone() {
        return new AndroidDevice();
    }

    @Override
    public ICharger createCharger() {
        return new AndroidCharger();
    }

    @Override
    public IHeadphones createHeadphones() {
        return new AndroidHeadphones();
    }
}
