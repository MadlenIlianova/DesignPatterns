namespace DecoratorCoffee
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()} euro");

            coffee = new MilkDecorator(new SimpleCoffee());
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()} euro");

            coffee = new SugarDecorator(new MilkDecorator(new SimpleCoffee()));
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()} euro");

            coffee = new VanillaDecorator(new SugarDecorator(new MilkDecorator(new SimpleCoffee())));
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()} euro");
        }
    }
}
