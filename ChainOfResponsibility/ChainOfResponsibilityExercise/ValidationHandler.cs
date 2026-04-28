using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ValidationHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            if (order == null)
            {
                Console.WriteLine("Order is null!");
                return false;
            }

            if (string.IsNullOrEmpty(order.OrderId))
            {
                Console.WriteLine("OrderId is null!");
                return false;
            }

            if (order.TotalAmount <= 0)
            {
                Console.WriteLine("The sum needs to be bigger than 0");
                return false;
            }
             else
            {
                return true;
            }
            
        }

        protected override void ProcessOrder(Order order)
        {
            Console.WriteLine("Validation completed for order: " + order.OrderId);
        }
    }
}
