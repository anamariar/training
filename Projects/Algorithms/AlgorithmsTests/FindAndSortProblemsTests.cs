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

        [TestMethod]
        public void SortCasesTest()
        {
            uint[] casesPriority = new uint[] { 2, 1, 3, 1, 2, 1, 3, 2, 3, 3, 2, 1, 2, 1, 3, 1, 1, 2, 3, 2, 2 };
            uint[] expected = new uint[] { 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
            FindAndSortProblems.SortCases(casesPriority, 0, (uint)casesPriority.Length - 1, 2);
            CollectionAssert.AreEqual(expected, casesPriority);
        }
    }
}
