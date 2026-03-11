using Logistics.Creators;
using Logistics.Interfaces;

namespace Logistics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изберете тип логистика:");
            Console.WriteLine("1. Road");
            Console.WriteLine("2. Sea");
            Console.WriteLine("3. Plane");

            string choice = Console.ReadLine();

            ILogistics logistics = choice switch
            {
                "1" => new RoadLogistics(),
                "2" => new SeaLogistics(),
                "3" => new AirLogistics(),
                _ => throw new Exception("Невалиден избор")
            };

            logistics.PlanDelivery();
        }
    }
}
