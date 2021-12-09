global using HouseFB;
global using House = HouseFB.House;

HouseBuilder houseBuilder = new();

House house = houseBuilder
    .SetNoOfRooms(1)
    .SetNoOfWindows(-1)
    .SetAdress("LalatoftsVägen 3")
    .HasSwimmingPool()
    .SetParkingSpotsInGarage(5)
    .Build();

Console.WriteLine(house);

