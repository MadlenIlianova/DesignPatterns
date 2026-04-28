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

            Console.WriteLine("\nNormal order:");
            validation.DistributeOrderProcessing(new Order { OrderId = "001", TotalAmount = 150 });

            Console.WriteLine("\nOrder over payment limit");
            validation.DistributeOrderProcessing(new Order { OrderId = "002", TotalAmount = 6000 });

            Console.WriteLine("\nInvalid order");
            validation.DistributeOrderProcessing(new Order { OrderId = "", TotalAmount = 150 });

            Console.WriteLine("\nInvalid order");
            validation.DistributeOrderProcessing(new Order { OrderId = "003", TotalAmount = 0 });
        }
    }
}
