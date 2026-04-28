using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class PaymentVerificationHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            if (order.TotalAmount > 5000)
            {
                Console.WriteLine("Payment verification failed for order: " + order.OrderId);
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void ProcessOrder(Order order)
        {
            Console.WriteLine("Payment verification completed for order: " + order.OrderId);
        }
    }
}
