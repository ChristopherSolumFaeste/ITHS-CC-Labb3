using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class SmallHouse : House
    {
        public SmallHouse()
        {
            NoOfRooms = 1;
            NoOfWindows = 3;
            StreetAdress = "SmallHouse street 1";
        }
    }
}
