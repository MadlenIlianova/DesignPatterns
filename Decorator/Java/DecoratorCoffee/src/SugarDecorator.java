public class SugarDecorator extends BaseDecorator{
    public SugarDecorator(ICoffee coffee) {
        super(coffee);
    }

    @Override
    public double getCost() {
        return super.getCost() + 0.25;
    }

    @Override
    public String getDescription() {
        return super.getDescription() + ", sugar";
    }
}
