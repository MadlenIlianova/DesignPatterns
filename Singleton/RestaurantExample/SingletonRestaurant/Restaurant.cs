using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRestaurant
{
    public class Restaurant
    {
        private static Restaurant instance;
        private List<string> orders = new List<string>();

        private Restaurant()
        {
            Console.WriteLine("Restaurant is open!");
            Console.WriteLine();
        }

        public static Restaurant GetInstance()
        {
            if (instance == null)
            {
                instance = new Restaurant();
            }
            return instance;
        }

        public void AddOrder(string waiter, string food) 
        {
            orders.Add($"{waiter}: {food}");
            Console.WriteLine($"{waiter} adds {food}");
        }

        public void ShowOrders()
        {
            Console.WriteLine();
            Console.WriteLine("All orders:");          
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
