using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.interfaces
{
    public class IPriority
    {
        string PriorityLevel { get; }
        int DeliveryDays { get; }
    }
}
