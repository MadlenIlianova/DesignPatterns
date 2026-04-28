namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var validation = new ValidationHandler();
            var inventory = new InventoryCheckHandler();
            var payment = new PaymentVerificationHandler();
            var shipping = new ShippingConfirmationHandler();

            validation.SetNextHandler(inventory);
            inventory.SetNextHandler(payment);
            payment.SetNextHandler(shipping);

            var orders = new List<Order> 
            {
                new Order { OrderId = "001", TotalAmount = 150 },
                new Order { OrderId = "002", TotalAmount = 6000 },
                new Order { OrderId = "",    TotalAmount = 150 },
                new Order { OrderId = "003", TotalAmount = 0 },
                new Order { OrderId = "004", TotalAmount = 12000 }
            };
        
            foreach (var order in orders)
            {
                Console.WriteLine($"\nProcessing order: {order.OrderId}");
                validation.DistributeOrderProcessing(order);
            }
        }
    }
}
