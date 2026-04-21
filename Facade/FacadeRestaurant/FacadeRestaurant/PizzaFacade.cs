using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRestaurant
{
    public class PizzaFacade
    {
        private InventoryService _inventoryService;
        private KitchenService _kitchenService;
        private BillingService _billingService;
        private DeliveryService _deliveryService;

        public PizzaFacade()
        {
            _inventoryService = new InventoryService();
            _kitchenService = new KitchenService();
            _billingService = new BillingService();
            _deliveryService = new DeliveryService();
        }

        public void OrderPizza(string pizzaType, string address, decimal amount) 
        {
            Console.WriteLine("Starting order...");
            if (!_inventoryService.CheckIngredients(pizzaType)) 
            {
                Console.WriteLine("No ingredients available!");
                return;
            }

            _kitchenService.CookPizza(pizzaType);
            _billingService.ProcessPayment(pizzaType, amount);
            _deliveryService.DeliverPizza(address);

            Console.WriteLine("Order completed!");
        }
    }
}
