using NUnit.Framework;
using HouseF;
using HouseFB;
using System;
using System.Collections.Generic;

namespace HouseF.Tests
{
    public class HouseFactoryTest
    {
        HouseFactory houseFactory;
        House smallHouse;
        House mediumHouse;
        House largeHouse;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            houseFactory = new HouseFactory();
            smallHouse = houseFactory.CreateHouse("smallhouse");
            mediumHouse = houseFactory.CreateHouse("mediumhouse");
            largeHouse = houseFactory.CreateHouse("largehouse");
        }

        [TestCase("smallhouse")]
        public void CreateHouse_GivenString_smallhouse_ReturnTypeSmallHouse(string houseName)
        {
            Assert.That(houseFactory.CreateHouse(houseName), Is.TypeOf<SmallHouse>());
        }

        [TestCase("mediumhouse")]
        public void CreateHouse_GivenString_mediumhouse_ReturnTypeMediumHouse(string houseName)
        {
            Assert.That(houseFactory.CreateHouse(houseName), Is.TypeOf<MediumHouse>());
        }

        [TestCase("largehouse")]
        public void CreateHouse_GivenString_largehouse_ReturnTypeLargeHouse(string houseName)
        {
            Assert.That(houseFactory.CreateHouse(houseName), Is.TypeOf<LargeHouse>());
        }

        [TestCase("faultyKey")]
        public void CreateHouse_GivenFaultyKey_ThrowsKeyNotFoundException(string houseName)
        {
            Assert.Throws<KeyNotFoundException>(() => houseFactory.CreateHouse(houseName));
        }

        [Test]
        public void CreateHouse_SmallHouseHasGarageAndSwimmingPool_IsFalse()
        {
            Assert.That(smallHouse.HasGarage && smallHouse.HasSwimmingPool, Is.False);
        }

        [Test]
        public void CreateHouse_MediumHouseHasGarageAndNoSwimmingpool_IsTrue()
        {
            Assert.That(mediumHouse.HasGarage && !mediumHouse.HasSwimmingPool, Is.True);
        }

        [Test]
        public void CreateHouse_LargeHouseHasGarageAndSwimmingPool_IsTrue()
        {
            Assert.That(largeHouse.HasGarage && largeHouse.HasSwimmingPool, Is.True);
        }

        [Test]
        public void CreateHouse_GivenSmallHouse_NoOfRoomsIsEqualToOne()
        {
            Assert.That(smallHouse.NoOfRooms, Is.EqualTo(1));
        }

        [Test]
        public void CreateHouse_GivenMediumHouse_NoOfRoomsIsEqualToFour()
        {
            Assert.That(mediumHouse.NoOfRooms, Is.EqualTo(4));
        }

        [Test]
        public void CreateHouse_GivenLargeHouse_NoOfRoomsIsEqualToFifteen()
        {
            Assert.That(largeHouse.NoOfRooms, Is.EqualTo(15));
        }

        [Test]
        public void CreateHouse_GivenSmallHouse_NoOfWindowsIsEqualToThree()
        {
            Assert.That(smallHouse.NoOfWindows, Is.EqualTo(3));
        }

        [Test]
        public void CreateHouse_GivenMediumHouse_NoOfWindowsIsEqualToEight()
        {
            Assert.That(mediumHouse.NoOfWindows, Is.EqualTo(8));
        }

        [Test]
        public void CreateHouse_GivenLargeHouse_NoOfWindowsIsEqualToThirty()
        {
            Assert.That(largeHouse.NoOfWindows, Is.EqualTo(30));
        }

        [Test]
        public void CreateHouse_GivenSmallHouse_ParkingSpotsInGarageIsEqualToZero()
        {
            Assert.That(smallHouse.ParkingSpotsInGarage, Is.EqualTo(0));
        }

        [Test]
        public void CreateHouse_GivenMediumHouse_ParkingSpotsInGarageIsEqualToOne()
        {
            Assert.That(mediumHouse.ParkingSpotsInGarage, Is.EqualTo(1));
        }

        [Test]
        public void CreateHouse_GivenLargeHouse_ParkingSpotsInGarageIsEqualToFive()
        {
            Assert.That(largeHouse.ParkingSpotsInGarage, Is.EqualTo(5));
        }
    }
}