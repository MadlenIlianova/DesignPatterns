void main() {
    ICoffee coffee = new SimpleCoffee();
    System.out.println(coffee.getDescription() + " costs " + coffee.getCost() + " euro");

    coffee = new MilkDecorator(new SimpleCoffee());
    System.out.println(coffee.getDescription() + " costs " + coffee.getCost() + " euro");

    coffee = new SugarDecorator(new MilkDecorator(new SimpleCoffee()));
    System.out.println(coffee.getDescription() + " costs " + coffee.getCost() + " euro");

    coffee = new VanillaDecorator(new SugarDecorator(new MilkDecorator(new SimpleCoffee())));
    System.out.println(coffee.getDescription() + " costs " + coffee.getCost() + " euro");
}


