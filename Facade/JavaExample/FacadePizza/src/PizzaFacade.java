import java.math.BigDecimal;

public class PizzaFacade {
    private InventoryService inventoryService;
    private KitchenService kitchenService;
    private BillingService billingService;
    private DeliveryService deliveryService;

    public PizzaFacade() {
        this.inventoryService = new InventoryService();
        this.kitchenService = new KitchenService();
        this.billingService = new BillingService();
        this.deliveryService = new DeliveryService();
    }

    public void orderPizza(String pizzaType, String address, BigDecimal amount) {
        System.out.println("Starting order...");

        if (!inventoryService.checkIngredients(pizzaType)) {
            System.out.println("No ingredients available!");
            return;
        }

        kitchenService.cookPizza(pizzaType);
        billingService.processPayment(pizzaType, amount);
        deliveryService.deliverPizza(address);

        System.out.println("Order completed!");
    }
}
