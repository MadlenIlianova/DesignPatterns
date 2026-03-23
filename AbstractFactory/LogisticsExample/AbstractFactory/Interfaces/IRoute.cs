using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.interfaces;

namespace AbstractFactory.interfaces
{
    public interface IRoute
    {
        string GetRoute();
        double DistanceKm { get; }
    }
}
