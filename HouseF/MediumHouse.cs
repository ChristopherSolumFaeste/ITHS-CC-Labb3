using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class MediumHouse : House
    {
        public MediumHouse()
        {
            NoOfRooms = 4;
            NoOfWindows = 8;
            StreetAdress = "MediumHouse street 1";
            ParkingSpotsInGarage = 1;
        }
    }
}
