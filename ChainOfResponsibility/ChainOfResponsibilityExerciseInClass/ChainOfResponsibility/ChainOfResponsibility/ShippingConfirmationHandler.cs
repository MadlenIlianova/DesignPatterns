using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ShippingConfirmationHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            return true;
        }

        protected override void ProcessOrder(Order order)
        {
            Console.WriteLine("Shipping confirmation sent for order: " + order.OrderId);
        }
    }
}
