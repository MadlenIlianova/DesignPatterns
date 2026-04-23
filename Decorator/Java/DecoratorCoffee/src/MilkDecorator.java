public class MilkDecorator extends BaseDecorator{
    public MilkDecorator(ICoffee coffee) {
        super(coffee);
    }

    @Override
    public double getCost() {
        return super.getCost() + 0.50;
    }

    @Override
    public String getDescription() {
        return super.getDescription() + ", milk";
    }
}
