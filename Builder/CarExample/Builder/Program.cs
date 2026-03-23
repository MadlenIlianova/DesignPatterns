namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CarBuilder();
            director.Builder = builder;

            Console.WriteLine("Sports car:");
            director.BuildSportsCar();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("\nFamily car:");
            director.BuildFamilyCar();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
