using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public Car Build()
        {
            return car;
        }
        public ICarBuilder SetName(string name)
        {
            car.Name = name;
            return this;
        }
        public ICarBuilder SetModel(string model)
        {
            car.Model = model;
            return this;
        }
        public ICarBuilder SetColor(string color)
        {
            car.Color = color;
            return this;
        }

        public ICarBuilder SetEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }

        public ICarBuilder SetSeats(int seats)
        {
           car.Seats = seats;
            return this;
        }

        public ICarBuilder SetWheels(int wheels)
        {
            car.Wheels = wheels;
            return this;
        }

        public ICarBuilder SetYear(int year)
        {
            car.Year = year;
            return this;
        }
    }
}
