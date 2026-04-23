public class VanillaDecorator extends BaseDecorator{
    public VanillaDecorator(ICoffee coffee) {
        super(coffee);
    }

    @Override
    public double getCost() {
        return super.getCost() + 0.75;
    }

    @Override
    public String getDescription() {
        return super.getDescription() + ", vanilla";
    }
}
