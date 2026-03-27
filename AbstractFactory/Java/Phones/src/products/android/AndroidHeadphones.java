package products.android;

import interfaces.IHeadphones;

public class AndroidHeadphones implements IHeadphones {
    @Override
    public String getType() {
        return "Samsung Galaxy Buds";
    }

    @Override
    public void playMusic() {
        System.out.println("Playing music with Galaxy Buds...");
    }
}
