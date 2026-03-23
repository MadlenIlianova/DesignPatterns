using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.products.priority
{
    public class StandartPriority : IPriority
    {
        public string PriorityLevel => "Standart";
        public int DeliveryDays => 5;
    }
}
