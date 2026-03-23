using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.interfaces;

namespace AbstractFactory.products.routes
{
    public class AsiaRoute : IRoute
    {
        public string GetRoute()
        {
            return "Shanghai -> Singapore -> Mumbai -> Dubai";
        }

        public double DistanceKm => 8000;
    }
}
