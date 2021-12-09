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
        [SetUp]
        public void Setup()
        {
            houseFactory = new HouseFactory();
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

        [TestCase("smallhouse")]
        public void CreateHouse_SmallHouseHasGarageAndSwimmingPool_IsFalse(string houseName)
        {
            House smallHouse = houseFactory.CreateHouse(houseName);
            Assert.That(smallHouse.HasGarage && smallHouse.HasSwimmingPool, Is.False);
        }

        [TestCase("mediumhouse")]
        public void CreateHouse_MediumHouseHasGarageAndNoSwimmingpool_IsTrue(string houseName)
        {
            House mediumHouse = houseFactory.CreateHouse(houseName);
            Assert.That(mediumHouse.HasGarage && !mediumHouse.HasSwimmingPool, Is.True);
        }

        [TestCase("largehouse")]
        public void CreateHouse_LargeHouseHasGarageAndSwimmingPool_IsTrue(string houseName)
        {
            House largeHouse = houseFactory.CreateHouse(houseName);
            Assert.That(largeHouse.HasGarage && largeHouse.HasSwimmingPool, Is.True);
        }
    }
}