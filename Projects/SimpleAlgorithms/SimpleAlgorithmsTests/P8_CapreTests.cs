using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P8_CapreTests
    {
        [TestMethod]
        public void TestCapre1()
        {
            var kg = P8_Capre.CalculeazaKilograme(1, 1, 1, 2, 1);
            Assert.AreEqual(2, kg);
        }

        [TestMethod]
        public void TestCapre2()
        {
            var kg = P8_Capre.CalculeazaKilograme(1, 1, 1, 2, 3);
            Assert.AreEqual(6, kg);
        }

        [TestMethod]
        public void TestCapre3()
        {
            var kg = P8_Capre.CalculeazaKilograme(2, 3, 8, 5, 10);
            Assert.AreEqual(66.66, kg, 0.01);
        }

        [TestMethod]
        public void TestCapre4()
        {
            var kg = P8_Capre.CalculeazaKilograme(2, 3, 0, 5, 10);
            Assert.AreEqual(0, kg);
        }
    }
}
