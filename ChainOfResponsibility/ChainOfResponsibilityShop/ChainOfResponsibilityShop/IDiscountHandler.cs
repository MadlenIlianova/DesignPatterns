using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityShop
{
    public interface IDiscountHandler
    {
        void SetNext(IDiscountHandler next);
        void GetDiscount(string clientType);
    }
}
