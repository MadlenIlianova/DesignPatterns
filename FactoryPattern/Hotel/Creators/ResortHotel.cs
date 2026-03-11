using Hotel.Interfaces;
using Hotel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Creators
{
    public class ResortHotel : Hotel
    {
        public override IRoom CreateRoom() => new DoubleRoom();
    }
}
