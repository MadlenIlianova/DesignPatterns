public class Soldier {
    private final SoldierType type;
    private final int x;
    private final int y;

    public Soldier(SoldierType type, int x, int y) {
        this.type = type;
        this.x = x;
        this.y = y;
    }

    public void display() {
        type.display(x, y);
    }
}
