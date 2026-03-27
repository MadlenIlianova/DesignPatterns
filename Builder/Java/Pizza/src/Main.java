void main() {
    Director director = new Director();
    PizzaBuilder builder = new PizzaBuilder();
    director.setBuilder(builder);

    System.out.println("Building Margherita Pizza:");
    director.buildMargheritaPizza();
    System.out.println(builder.getProduct().listParts());

    System.out.println("\nBuilding Pepperoni Pizza:");
    director.buildPepperoniPizza();
    System.out.println(builder.getProduct().listParts());
}
