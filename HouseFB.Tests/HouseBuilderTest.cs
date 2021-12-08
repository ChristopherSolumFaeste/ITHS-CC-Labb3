using NUnit.Framework;
using System;

namespace HouseFB.Tests
{
    public class HouseBuilderTest
    {
        private HouseBuilder houseBuilder;

        [SetUp]
        public void SetUp()
        {
            houseBuilder = new HouseBuilder();
        }


        [TestCase(1)]
        [TestCase(10)]
        public void SetNumberOfRooms_GivenPositiveNo_IsEqualToGivenNo(int rooms)
        {
            House house = houseBuilder.SetNoOfRooms(rooms).Build();

            Assert.That(house.NoOfRooms, Is.EqualTo(rooms));
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void SetNumberOfRooms_GivenNegativeNo_ThrowsException(int rooms)
        {
            Assert.Throws<ArgumentException>(() => houseBuilder.SetNoOfRooms(rooms).Build());
        }

        [TestCase(1)]
        [TestCase(10)]
        public void SetNumberOfWindows_GivenPositiveNo_IsEqualToGivenNo(int windows)
        {
            House house = houseBuilder.SetNoOfWindows(windows).Build();

            Assert.That(house.NoOfWindows, Is.EqualTo(windows));
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void SetNumberOfWindows_GivenNegativeNo_ThrowsException(int windows)
        {
            Assert.Throws<ArgumentException>(() => houseBuilder.SetNoOfWindows(windows).Build());
        }

        [TestCase(1)]
        [TestCase(10)]
        public void SetParkingSpotsInGarage_GivenPositiveNo_IsEqualToGivenNo(int parkingSpot)
        {
            House house = houseBuilder.SetParkingSpotsInGarage(parkingSpot).Build();

            Assert.That(house.ParkingSpotsInGarage, Is.EqualTo(parkingSpot));
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void SetParkingSpotsInGarage_GivenNegativeNo_ThrowsException(int parkingSpot)
        {
            Assert.Throws<ArgumentException>(() => houseBuilder.SetParkingSpotsInGarage(parkingSpot).Build());
        }

        [TestCase(1)]
        [TestCase(10)]
        public void SetParkingSpotsInGarage_GivenPositiveNo_HasGarageIsTrue(int parkingSpot)
        {
            House house = houseBuilder.SetParkingSpotsInGarage(parkingSpot).Build();

            Assert.That(house.HasGarage, Is.True);
        }

        [TestCase("Testvägen 3")]
        public void SetAdress_GivenString_IsEqualToGivenString(string adress)
        {
            House house = houseBuilder.SetAdress(adress).Build();

            Assert.That(house.StreetAdress, Is.EqualTo(adress));
        }

        [Test]
        public void HasSwimmingPool_GivenTrue_HasSwimmingPoolIsEqualTrue()
        {
            House house = houseBuilder.HasSwimmingPool().Build();

            Assert.That(house.HasSwimmingPool, Is.True);
        }

        [Test]
        public void Build_ReturnsTypeOfHouse()
        {
            Assert.That(houseBuilder.Build(), Is.TypeOf<House>());
        }

    }
}