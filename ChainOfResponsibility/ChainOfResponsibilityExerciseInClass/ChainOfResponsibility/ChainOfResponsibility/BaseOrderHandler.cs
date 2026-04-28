using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class BaseOrderHandler : IOrderHandler
    {
        private IOrderHandler nextOrderHandler;

        public void SetNextHandler(IOrderHandler nextOrderHandler)
        {
            this.nextOrderHandler = nextOrderHandler;
        }

        public virtual void DistributeOrderProcessing(Order order)
        {
            if (CanProcessOrder(order))
            {
                ProcessOrder(order);

               if (nextOrderHandler != null)
                    nextOrderHandler.DistributeOrderProcessing(order);
            }
            else
            {
                Console.WriteLine("Order cannot be processed: " + order.OrderId);
            }
        }

        protected abstract bool CanProcessOrder(Order order);
        protected abstract void ProcessOrder(Order order);
    }
}