public class PizzaBuilder implements IPizzaBuilder {
    private Pizza pizza;

    public PizzaBuilder() {
        reset();
    }

    @Override
    public void reset() {
        this.pizza = new Pizza();
    }

    @Override
    public void setDough(String dough) {
        pizza.setDough(dough);
    }

    @Override
    public void setSauce(String sauce) {
        pizza.setSauce(sauce);
    }

    @Override
    public void setCheese(String cheese) {
        pizza.setCheese(cheese);
    }

    @Override
    public void setTopping(String topping) {
        pizza.setTopping(topping);
    }

    @Override
    public void setSize(Integer size) {
        pizza.setSize(size);
    }

    @Override
    public Pizza getProduct() {
        Pizza result = this.pizza;
        reset();
        return result;
    }
}