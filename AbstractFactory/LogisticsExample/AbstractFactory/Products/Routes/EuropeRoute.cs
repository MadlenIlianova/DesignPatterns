using AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.products.routes
{
    public class EuropeRoute : IRoute
    {
        public string GetRoute()
        {
            return "Sofia -> Viena -> Berlin -> Paris";
        }

        public double DistanceKm => 5000; 
    }
}
