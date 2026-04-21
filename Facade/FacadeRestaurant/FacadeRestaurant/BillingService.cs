using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRestaurant
{
    public class BillingService
    {
        public void ProcessPayment(string pizzaType, decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} euro for {pizzaType}");
        }
    }
}
