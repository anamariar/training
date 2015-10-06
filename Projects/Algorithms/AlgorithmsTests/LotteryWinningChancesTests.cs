using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class LotteryWinningChancesTests
    {
        [TestMethod]
        public void LotteryExtractionTest1()
        {
            Assert.AreEqual(0.00000007d, LotteryWinningChances.GetWinningChances(6, 49, 1), 0.000000002d);
        }

        [TestMethod]
        public void LotteryExtractionTest2()
        {
            Assert.AreEqual(1, LotteryWinningChances.GetWinningChances(1, 1, 1));
        }

        [TestMethod]
        public void LotteryExtractionTest3()
        {
            Assert.AreEqual(0.5, LotteryWinningChances.GetWinningChances(1, 2, 1));
        }

        [TestMethod]
        public void LotteryExtractionTest4()
        {
            Assert.AreEqual(0.000018d, LotteryWinningChances.GetWinningChances(6, 49, 2), 0.000001d);
        }


        [TestMethod]
        public void LotteryExtractionTest5()
        {
            Assert.AreEqual(0.00096d, LotteryWinningChances.GetWinningChances(6, 49, 3), 0.00001d);
        }

        [TestMethod]
        public void LotteryExtractionTest6()
        {
            Assert.AreEqual(0, LotteryWinningChances.GetWinningChances(0, 2, 1));
        }

        [TestMethod]
        public void LotteryExtractionTest7()
        {
            Assert.AreEqual(0, LotteryWinningChances.GetWinningChances(1, 0, 1));
        }

        [TestMethod]
        public void LotteryExtractionTest8()
        {
            Assert.AreEqual(0, LotteryWinningChances.GetWinningChances(1, 2, 0));
        }
    }
}
