using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Car car;
        public CarBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(string engine) => car.Engine = engine;
        public void SetColor(string color) => car.Color = color;
        public void SetSeats(int seats) => car.Seats = seats;
        public void SetWheels(int wheels) => car.Wheels = wheels;
        public void SetYear(int year) => car.Year = year;

        public Car GetProduct()
        {
            Car result = car;
            Reset();
            return result;
        }

    }
}
