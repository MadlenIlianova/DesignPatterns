namespace BuilderPizza
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new PizzaBuilder();
            director.Builder = builder;

            Console.WriteLine("Building Margherita Pizza:");
            director.BuildMargheritaPizza();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("\nBuilding Pepperoni Pizza:");
            director.BuildPepperoniPizza();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
