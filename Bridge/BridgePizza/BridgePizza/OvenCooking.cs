using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePizza
{
    public class OvenCooking : ICookingMethod
    {
        public string Cook(string pizzaName)
        {
            return $"{pizzaName} изпечена на фурна при 250°C";
        }
    }
}
