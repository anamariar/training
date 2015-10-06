using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P1_PavajTests
    {
        [TestMethod]
        public void TestPavaj1()
        {
            Assert.AreEqual(4, P1_Pavaj.GetStonesNumber(6, 6, 4));
        }

        [TestMethod]
        public void TestPavaj2()
        {
            Assert.AreEqual(100, P1_Pavaj.GetStonesNumber(10, 10, 1));
        }

        [TestMethod]
        public void TestPavaj3()
        {
            Assert.AreEqual(2, P1_Pavaj.GetStonesNumber(6, 3, 4));
        }

        [TestMethod]
        public void TestPavaj4()
        {
            Assert.AreEqual(20, P1_Pavaj.GetStonesNumber(9, 7, 2));
        }

        [TestMethod]
        public void TestPavaj5()
        {
            Assert.AreEqual(1, P1_Pavaj.GetStonesNumber(1, 1, 1));
        }

        [TestMethod]
        public void TestPavaj6()
        {
            Assert.AreEqual(1, P1_Pavaj.GetStonesNumber(3, 3, 4));
        }

        [TestMethod]
        public void TestPavaj7()
        {
            Assert.AreEqual(4, P1_Pavaj.GetStonesNumber(4, 4, 2));
        }
    }
}
