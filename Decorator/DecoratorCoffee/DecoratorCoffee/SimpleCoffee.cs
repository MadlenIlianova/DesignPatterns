namespace DecoratorCoffee
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost() => 1.00;       
        public string GetDescription() => "Simple coffee";
    }
}
