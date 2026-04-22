void main() {
    PizzaFacade pizzaFacade = new PizzaFacade();
    pizzaFacade.orderPizza("Margherita", "123 Main St", new BigDecimal("9.99"));

    System.out.println();

    pizzaFacade.orderPizza("Pepperoni", "456 Elm St", new BigDecimal("12.99"));
}

