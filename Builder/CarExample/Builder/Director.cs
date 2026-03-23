using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildSportsCar() 
        {
            _builder.SetEngine("V8");
            _builder.SetColor("Red");
            _builder.SetSeats(4);
            _builder.SetWheels(4);
            _builder.SetYear(2022);
        }

        public void BuildFamilyCar()
        {
            _builder.SetEngine("1.6 TDI");
            _builder.SetColor("Blue");
            _builder.SetSeats(5);
            _builder.SetWheels(4);
            _builder.SetYear(2018);
        }
    }
}
