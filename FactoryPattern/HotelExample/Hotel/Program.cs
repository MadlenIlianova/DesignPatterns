using Hotel.Interfaces;

namespace Hotel
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Choose hotel:");
                Console.WriteLine("1 - Budget Hotel  (Single Room)");
                Console.WriteLine("2 - Resort Hotel  (Double Room)");
                Console.WriteLine("3 - Luxury Hotel  (Suite Room)");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Invalid choice.");
                    break;
                }

                IHotel hotel;
                switch (choice)
                {
                    case "1":
                        hotel = new Creators.BudgetHotel();
                        break;
                    case "2":
                        hotel = new Creators.ResortHotel();
                        break;
                    case "3":
                        hotel = new Creators.LuxuryHotel();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue; 
                }
                hotel.BookRoom();
            }
        }
    }
}
