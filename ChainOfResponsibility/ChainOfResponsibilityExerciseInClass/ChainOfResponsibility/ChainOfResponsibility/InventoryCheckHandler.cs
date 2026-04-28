using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class InventoryCheckHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            if (order.TotalAmount > 10000)
            {
                Console.WriteLine("Not enough stock to order: " + order.OrderId);
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void ProcessOrder(Order order)
        {
            Console.WriteLine("Inventory check completed for order: " + order.OrderId);
        }
    }
}
