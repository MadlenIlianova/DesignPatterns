using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.products.priority
{
    public class ExpressPriority : IPriority
    {
        public string PriorityLevel => "Express";
        public int DeliveryDays => 1;
    }
}
