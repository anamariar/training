using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class FindAndSortProblemsTests
    {
        [TestMethod]
        public void SortLotteryNumbersTest()
        {
            uint[] loterryNumbers = new uint[] { 33, 3, 49, 16, 17, 44};
            uint[] expected = new uint[] { 3, 16, 17, 33, 44, 49 };
            var sorted = FindAndSortProblems.SortLotteryNumbers(loterryNumbers);
            CollectionAssert.AreEqual(expected, sorted);
        }
    }
}
