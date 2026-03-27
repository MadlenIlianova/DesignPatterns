package client;

import interfaces.ICharger;
import interfaces.IHeadphones;
import interfaces.IPhone;
import interfaces.IPhoneFactory;

public class Client {
    private IPhoneFactory _factory;

    public Client(IPhoneFactory factory) {
        _factory = factory;
    }

    public void setFactory(IPhoneFactory factory) {
        _factory = factory;
    }

    public void showPhoneSetup() {
        IPhone phone           = _factory.createPhone();
        ICharger charger       = _factory.createCharger();
        IHeadphones headphones = _factory.createHeadphones();

        System.out.println("Model      : " + phone.getModel());
        System.out.println("OS         : " + phone.getOS());
        System.out.println("Charger    : " + charger.getType());
        System.out.println("Watts       : " + charger.getWatts() + "W");
        System.out.println("Headphones   : " + headphones.getType());

        phone.makeCall();
        charger.charge();
        headphones.playMusic();
    }
}
