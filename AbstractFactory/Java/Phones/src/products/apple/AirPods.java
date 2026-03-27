package products.apple;

import interfaces.IHeadphones;

public class AirPods implements IHeadphones {
    @Override
    public String getType() {
        return "AirPods Pro";
    }

    @Override
    public void playMusic() {
        System.out.println("Playing music with AirPods Pro...");
    }
}
