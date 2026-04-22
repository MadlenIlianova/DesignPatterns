public class SoldierType {
    private final String type;
    private final String color;
    private final String animation;

    public SoldierType(String type, String color, String animation) {
        this.type = type;
        this.color = color;
        this.animation = animation;
        System.out.println("Creating type: " + type + " [" + color + "]");
    }

    public void display(int x, int y) {
        System.out.println("Displaying " + type + " at (" + x + ", " + y +
                ") with color " + color + " and animation " + animation);
    }
}
