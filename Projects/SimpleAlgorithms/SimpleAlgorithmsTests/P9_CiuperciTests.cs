using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P9_CiuperciTests
    {
        [TestMethod]
        public void TestCiuperci1()
        {
            Assert.AreEqual(new Tuple<int, int>(3, 9), P9_Ciuperci.CalculeazaCiuperci(12, 3));
        }

        [TestMethod]
        public void TestCiuperci2()
        {
            Assert.AreEqual(new Tuple<int, int>(-1, -1), P9_Ciuperci.CalculeazaCiuperci(10, 3));
        }

        [TestMethod]
        public void TestCiuperci3()
        {
            Assert.AreEqual(new Tuple<int, int>(2, 8), P9_Ciuperci.CalculeazaCiuperci(10, 4));
        }

        [TestMethod]
        public void TestCiuperci4()
        {
            Assert.AreEqual(new Tuple<int, int>(6, 0), P9_Ciuperci.CalculeazaCiuperci(6, 0));
        }

        [TestMethod]
        public void TestCiuperci5()
        {
            Assert.AreEqual(new Tuple<int, int>(1, 5), P9_Ciuperci.CalculeazaCiuperci(6, 5));
        }

        [TestMethod]
        public void TestCiuperci6()
        {
            Assert.AreEqual(new Tuple<int, int>(-1, -1), P9_Ciuperci.CalculeazaCiuperci(6, 6));
        }

        [TestMethod]
        public void TestCiuperci7()
        {
            Assert.AreEqual(new Tuple<int, int>(0, 0), P9_Ciuperci.CalculeazaCiuperci(0, 2));
        }
    }
}
