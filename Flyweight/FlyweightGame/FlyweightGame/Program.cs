namespace FlyweightGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new SoldierFactory();
            var soilders = new List<Soldier>();
            var random = new Random();

            string[] types = { "Infantry", "Archer", "Cavalry" };
            string[] colors = { "Red", "Blue", "Green" };
            string[] animations = { "Walk", "Run", "Attack" };

            for (int i = 0; i < 10000; i++) 
            {
                int index = random.Next(0, 3);

                SoldierType type = factory.GetSoldierType(types[index], colors[index], animations[index]);

                soilders.Add(new Soldier(type, random.Next(0, 1000), random.Next(0, 1000)));
            }

            Console.WriteLine();
            Console.WriteLine("The first 5:");
            for (int i = 0; i < 5; i++) 
            {
            soilders[i].Display();
            }

            Console.WriteLine();
            Console.WriteLine($"All soldiers: {soilders.Count}");
            Console.WriteLine();
            Console.WriteLine($"Unique types created: {factory.TotalTypes}");
        }
    }
}
