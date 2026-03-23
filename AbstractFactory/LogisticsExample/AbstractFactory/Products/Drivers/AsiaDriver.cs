using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.products.drivers
{
    public class AsiaDriver : IDriver
    {
        public string Drive()
        {
            return "Driving in Asia";
        }
        public string Name => "Plamena Dimitrova";
    }
}
