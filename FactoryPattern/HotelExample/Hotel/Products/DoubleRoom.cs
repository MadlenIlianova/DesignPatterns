using Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Products
{
    public class DoubleRoom : IRoom
    {
        public string RoomType => "Double room";

        public int RoomNumber => 216;

        public double PricePerNight => 65.00;

        public string GetBenefits() => "TV,WiFi,Mini-bar";

    }
}
