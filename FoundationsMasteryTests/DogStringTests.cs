using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class DogStringTests
    {
        [TestMethod]
        public void CheckToSeeIfAnInstanceIsCreate()
        {
            char[] myDog = new char[] { 'a', 'b', 'd' };
            DogStrings doggie = new DogStrings(myDog);

            Assert.IsNotNull(doggie);
        }

        [TestMethod]
        public void CheckIfConcatinating()
        {
            char[] myDog = new char[] { 'a', 'b', 'd' };
            DogStrings doggie = new DogStrings(myDog);

            string expectedResult = "abdcba";
            string actualResult = doggie.Concat(new char[] { 'c', 'b', 'a' });

            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod]
        public void CheckToSeeIfInterleaving()
        {
            char[] myDog = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
            DogStrings doggie = new DogStrings(myDog);
            char[] numOfDogs = new char[] { '1', '2', '3', '4', '5', '6'};

            string expectedResult = "a1b2c3d4e5f6";
            string actualResult = doggie.Interleave(numOfDogs);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}