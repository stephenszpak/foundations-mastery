using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString cString = new CustomString();

            Assert.IsNotNull(cString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] myChar = new char[] { 'a', 'b', 'd' };
            CustomString newString = new CustomString(myChar);

            int expectedLength = 3;
            int actualLength = newString.RetrieveChars().Length;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] myChar = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(myChar);

            // 1. Assert that the Contents property is the correct 'type'
            var actualType = myString.ConvertCharToString().GetType();
            Assert.AreEqual(actualType, typeof(string));

            // 2. Assert that the returned Contents is the coorect length
            int expectedLength = 3;
            int actualLength = myString.ConvertCharToString().Length;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] myChar = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(myChar);

            myString.Clear();

            // How do you ensure your clear function works?
            var newStuff = myString.RetrieveChars();
            Assert.IsNull(myString.RetrieveChars());
        }
    }
}
