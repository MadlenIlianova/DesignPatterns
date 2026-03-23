using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public int Year { get; set; }
        public string ListParts()
        {
            return $"Engine: {Engine}, Color: {Color}, " +
                   $"Seats: {Seats}, Wheels: {Wheels}, Year: {Year}";
        }
    }
}
