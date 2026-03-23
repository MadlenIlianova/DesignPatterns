using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICarBuilder
    {
        void Reset();
        void SetEngine(string engine);
        void SetColor(string color);
        void SetSeats(int seats);
        void SetWheels(int wheels);
        void SetYear(int year);
    }
}
