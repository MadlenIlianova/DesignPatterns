using AbstractFactory.Client;
using AbstractFactory.factories;
using AbstractFactory.interfaces;
using AbstractFactory.products.priority;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClientLogistics client = new ClientLogistics(new EuropeLogistics(), new StandartPriority());

            while (true)
            {
                Console.WriteLine("Choose Logistics");
                Console.WriteLine("1 -> Europe");
                Console.WriteLine("2 -> Asia");
                Console.WriteLine();

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Invalid choice");
                }

                ILogisticsFactory factory;

                switch (choice) {
                    case "1":
                        factory = new EuropeLogistics();
                        break;
                    case "2":
                        factory = new AsiaLogistics();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;

                }

                Console.WriteLine("Choose priority:");
                Console.WriteLine("1 -> Express Prioruty (1 day)");
                Console.WriteLine("2 -> Standart Prioruty (5 days)");
                Console.WriteLine();


                IPriority priority;
                switch (Console.ReadLine())
                {
                    case "1": priority = new ExpressPriority(); break;
                    case "2": priority = new StandartPriority(); break;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;
                }
                client.PlanDelivey(factory, priority);
            }
        }
    }
}