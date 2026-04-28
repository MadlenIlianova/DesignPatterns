namespace ChainOfResponsibilityShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bronzeHandler = new BronzeHandler();
            var silverHandler = new SilverHandler();
            var goldHandler = new GoldHandler();

            bronzeHandler.SetNext(silverHandler);
            silverHandler.SetNext(goldHandler);

            Console.WriteLine("Checking discounts:");
            bronzeHandler.GetDiscount("bronze");
            bronzeHandler.GetDiscount("silver");
            bronzeHandler.GetDiscount("gold");
            bronzeHandler.GetDiscount("platinum");
        }
    }
}
