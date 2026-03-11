using Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Products
{
    public class SingleRoom : IRoom
    {
        public string RoomType => "Single room";

        public int RoomNumber => 215;

        public double PricePerNight => 45.00;

        public string GetBenefits() => "TV,WiFi";


    }
}
