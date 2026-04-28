using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityShop
{
    public abstract class BaseDiscountHandler : IDiscountHandler
    {
        private IDiscountHandler? _next;

        public void SetNext(IDiscountHandler next)
        {
            _next = next;
        }

        protected void Next(string clientType)
        {
            if (_next != null)
            {
                _next.GetDiscount(clientType);
            }
            else
            {
                Console.WriteLine("No discount available for this client type.");
            }
        }

        public abstract void GetDiscount(string clientType);
        
    }
}
