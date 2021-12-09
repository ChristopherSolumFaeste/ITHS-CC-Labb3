global using HouseF;

HouseFactory factory = new HouseFactory();

House smallHouse = factory.CreateHouse("smallhouse");
Console.WriteLine(smallHouse);
Console.WriteLine("===========================");

House mediumHouse = factory.CreateHouse("mediumHouse");
Console.WriteLine(mediumHouse);
Console.WriteLine("===========================");

House largeHouse = factory.CreateHouse("largehouse");
Console.WriteLine(largeHouse);
Console.WriteLine("===========================");