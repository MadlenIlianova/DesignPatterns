using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRestaurant
{
    public class DeliveryService
    {
        public void DeliverPizza(string address) 
        {
            Console.WriteLine($"Delivering pizza to {address}");
        }
    }
}
