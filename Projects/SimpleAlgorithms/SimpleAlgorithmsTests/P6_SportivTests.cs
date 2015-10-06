using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P6_SportivTests
    {
        [TestMethod]
        public void TestSportiv1()
        {
            Assert.AreEqual(1, P6_Sportiv.GetWorkingRepetitions(1));
        }

        [TestMethod]
        public void TestSportiv2()
        {
            Assert.AreEqual(4, P6_Sportiv.GetWorkingRepetitions(2));
        }

        [TestMethod]
        public void TestSportiv3()
        {
            Assert.AreEqual(9, P6_Sportiv.GetWorkingRepetitions(3));
        }

        [TestMethod]
        public void TestSportiv4()
        {
            Assert.AreEqual(100, P6_Sportiv.GetWorkingRepetitions(10));
        }


        [TestMethod]
        public void TestSportiv5()
        {
            Assert.AreEqual(0, P6_Sportiv.GetWorkingRepetitions(0));
        }
    }
}
