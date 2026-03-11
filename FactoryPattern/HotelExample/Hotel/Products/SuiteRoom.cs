using Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Products
{
    public class SuiteRoom : IRoom
    {
        public string RoomType => "Suite room";

        public int RoomNumber => 317;

        public double PricePerNight => 120.00;

        public string GetBenefits() => "TV,WiFi,Mini-bar,Jacuzzi";
    }
}
