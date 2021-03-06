﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            FactorialModel factorial = new FactorialModel();

            Assert.IsNotNull(factorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            FactorialModel factorial = new FactorialModel();

            int expectedResult = 24;
            int actualResult = factorial.Iterative(4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            FactorialModel factorial = new FactorialModel();

            int expectedResult = 24;
            int actualResult = factorial.Recursive(4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            FactorialModel factorial = new FactorialModel();

            int actualResult = factorial.Recursive(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            FactorialModel factorial = new FactorialModel();

            int actualResult = factorial.Iterative(0);
        }
    }
}
