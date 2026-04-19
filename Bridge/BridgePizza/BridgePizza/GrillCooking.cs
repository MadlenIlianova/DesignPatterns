using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePizza
{
    public class GrillCooking : ICookingMethod
    {
        public string Cook(string pizzaName)
        {
            return $"{pizzaName} изпечена на грил при 300°C";
        }   
    }
}
