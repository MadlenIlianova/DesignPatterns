public class Director {
    private IPizzaBuilder builder;

    public void setBuilder(IPizzaBuilder builder) {
        this.builder = builder;
    }

    public void buildMargheritaPizza() {
        builder.reset();
        builder.setDough("Thin crust");
        builder.setSauce("Tomato");
        builder.setCheese("Mozzarella");
        builder.setTopping("Basil");
        builder.setSize(30);
    }

    public void buildPepperoniPizza() {
        builder.reset();
        builder.setDough("Thick crust");
        builder.setSauce("Tomato");
        builder.setCheese("Cheddar");
        builder.setTopping("Pepperoni");
        builder.setSize(35);
    }
}
