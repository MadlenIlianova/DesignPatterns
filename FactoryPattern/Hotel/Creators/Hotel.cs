using Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Creators
{
    public abstract class Hotel : IHotel
    {
        public void BookRoom()
        {
            IRoom room = CreateRoom();
            Console.WriteLine("Reservations:");
            Console.WriteLine($"Room type:{room.RoomType}");
            Console.WriteLine($"Room number:{room.RoomNumber}");
            Console.WriteLine($"Price per night:{room.PricePerNight}");
            Console.WriteLine($"Benefits:{room.GetBenefits()}");
            Console.WriteLine();
        }

        public abstract IRoom CreateRoom();
       
    }
}
