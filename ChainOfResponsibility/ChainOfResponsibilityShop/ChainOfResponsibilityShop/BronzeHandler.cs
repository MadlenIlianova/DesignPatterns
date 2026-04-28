using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityShop
{
    public class BronzeHandler : BaseDiscountHandler
    {
        public override void GetDiscount(string clientType)
        {
            if (clientType == "bronze")
            {
                Console.WriteLine("Bronze client gets 5% discount.");
            }
            else 
            {
            Next(clientType);
            }
        }
    }
}
