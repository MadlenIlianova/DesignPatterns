public class BaseDecorator implements ICoffee{
    protected ICoffee coffee;

    public BaseDecorator(ICoffee coffee) {
        this.coffee = coffee;
    }

    @Override
    public double getCost() {
        return coffee.getCost();
    }

    @Override
    public String getDescription() {
        return coffee.getDescription();
    }
}
