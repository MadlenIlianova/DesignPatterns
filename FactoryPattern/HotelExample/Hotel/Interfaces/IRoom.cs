using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IRoom
    {
        string RoomType { get; }
        int RoomNumber { get; }
        double PricePerNight { get; }
        string GetBenefits();
    }
}
