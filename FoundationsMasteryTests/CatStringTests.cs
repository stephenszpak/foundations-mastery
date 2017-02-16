using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CatStringTests
    {
        [TestMethod]
        public void CheckToSeeIfAnInstanceIsCreate()
        {
            char[] myCat = new char[] { 'a', 'b', 'd' };
            CatStrings kitty = new CatStrings(myCat);

            Assert.IsNotNull(kitty);
        }

        [TestMethod]
        public void CheckIfConcatinating()
        {
            char[] myCat = new char[] { 'a', 'b', 'd' };
            CatStrings kitty = new CatStrings(myCat);

            string expectedResult = "abdcba";
            string actualResult = kitty.Concat(new char[] { 'c', 'b', 'a' });

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckToSeeIfInterleaving()
        {
            char[] myCat = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
            CatStrings kitty = new CatStrings(myCat);
            char[] numOfDogs = new char[] { '1', '2', '3', '4', '5', '6' };

            string expectedResult = "a1b2c3d4e5f6";
            string actualResult = kitty.Interleave(numOfDogs);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
