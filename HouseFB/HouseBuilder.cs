using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class HouseBuilder
    {
        private House _house;
        public HouseBuilder()
        {
            _house = new House();
        }

        public HouseBuilder SetNoOfRooms(int noOfRooms)
        {
            _house.NoOfRooms = noOfRooms;
            return this;
        }
        public HouseBuilder SetNoOfWindows(int noOfWindows)
        {
            _house.NoOfWindows = noOfWindows;
            return this;
        }
        public HouseBuilder SetAdress(string streetAdress)
        {
            _house.StreetAdress = streetAdress;
            return this;
        }
        public HouseBuilder HasSwimmingPool()
        {
            _house.HasSwimmingPool = true;
            return this;
        }
        public HouseBuilder SetParkingSpotsInGarage(int noOfParkingSpots)
        {
            _house.ParkingSpotsInGarage = noOfParkingSpots;
            return this;
        }

        public House Build()
        {
            if (_house.NoOfRooms < 1)
            {
                throw new ArgumentException("The house cannot have less than 1 room.");
            }

            if (_house.NoOfWindows < 0 || _house.ParkingSpotsInGarage < 0)
            {
                throw new ArgumentException("Number of parking spots and windows cannot be a negative number.");
            }
            return _house;
        }
    }
}
