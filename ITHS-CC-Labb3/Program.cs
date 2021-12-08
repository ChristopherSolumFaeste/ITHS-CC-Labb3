global using HouseFB;
global using House = HouseFB.House;
using ITHS_CC_Labb3;

HouseBuilder houseBuilder = new HouseBuilder();

House house = houseBuilder
    //.SetNoOfRooms(1)
    //.SetNoOfWindows(-1)
    //.SetAdress("LalatoftsVägen 3")
    //.HasSwimmingPool()
    //.SetParkingSpotsInGarage(5)
    .Build();

Console.WriteLine(house);

