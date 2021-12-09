using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class LargeHouse : House
    {
        public LargeHouse()
        {
            NoOfRooms = 15;
            NoOfWindows = 30;
            StreetAdress = "LargeHouse street 1";
            HasSwimmingPool = true;
            ParkingSpotsInGarage = 5;
        }
    }
}
