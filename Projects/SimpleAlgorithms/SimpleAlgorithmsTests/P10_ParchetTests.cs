using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P10_ParchetTests
    {
        [TestMethod]
        public void TestParchet1()
        {
            var rezultat = P10_Parchet.CalculeazaParchet(5, 7, 2, 3, 15);
            Assert.AreEqual(7, rezultat);
        }

        [TestMethod]
        public void TestParchet2()
        {
            var rezultat = P10_Parchet.CalculeazaParchet(10, 10, 1, 1, 0);
            Assert.AreEqual(100, rezultat);
        }

        [TestMethod]
        public void TestParchet3()
        {
            var rezultat = P10_Parchet.CalculeazaParchet(5, 6, 2, 4, 15);
            Assert.AreEqual(5, rezultat);
        }
    }
}
