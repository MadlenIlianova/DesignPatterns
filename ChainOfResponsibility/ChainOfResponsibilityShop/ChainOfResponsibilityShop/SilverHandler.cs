using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityShop
{
    public class SilverHandler : BaseDiscountHandler 
    {
        public override void GetDiscount(string clientType)
        {
            if (clientType == "silver" )
            {
                Console.WriteLine("Silver client gets 10% discount.");
            }
            else 
            {
                Next(clientType);
            }
        }
    }
}
