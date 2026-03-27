package interfaces;

import products.android.AndroidDevice;

public interface IPhoneFactory {
    AndroidDevice createPhone();
    ICharger createCharger();
    IHeadphones createHeadphones();
}
