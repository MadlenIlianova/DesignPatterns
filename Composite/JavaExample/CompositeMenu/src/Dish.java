public class Dish extends MenuComponent{
    private double price;

    public Dish(String name, double price) {
        super(name);
        this.price = price;
    }

    @Override
    public void show(int indent) {
        String spacing = "  ".repeat(indent);
        System.out.println(spacing + "- " + name + " (" + price + " euro)");
    }
}
