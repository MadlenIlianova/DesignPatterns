using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityShop
{
    public class GoldHandler : BaseDiscountHandler
    {
        public override void GetDiscount(string clientType)
        {
            if (clientType == "gold")
            {
                Console.WriteLine("Gold client gets 20% discount.");
            }
            else 
            {
            Next(clientType);
            }
        }
    }
}
