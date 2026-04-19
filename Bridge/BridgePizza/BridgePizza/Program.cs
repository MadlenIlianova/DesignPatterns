namespace BridgePizza
{
    public class Program
    {
        static void Main(string[] args)
        {
            var oven = new OvenCooking();
            var grill = new GrillCooking();

            Pizza pizza1 = new Margherita(oven);
            Pizza pizza2 = new Margherita(grill);
            Pizza pizza3 = new Pepperoni(oven);
            Pizza pizza4 = new Pepperoni(grill);

            Console.WriteLine(pizza1.Prepare());
            Console.WriteLine(pizza2.Prepare());
            Console.WriteLine(pizza3.Prepare());
            Console.WriteLine(pizza4.Prepare());
        }
    }
}
