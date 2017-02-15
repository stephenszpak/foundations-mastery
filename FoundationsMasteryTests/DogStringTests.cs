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
    }
}