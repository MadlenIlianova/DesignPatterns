using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICarBuilder
    {
        ICarBuilder SetName(string name);
        ICarBuilder SetModel(string model);
        ICarBuilder SetEngine(string engine);
        ICarBuilder SetWheels(int wheels);
        ICarBuilder SetColor(string color);
        ICarBuilder SetSeats(int seats);
        ICarBuilder SetYear(int year);
        Car Build();
    }
}
