using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P4_RataDescendentaTests
    {
        [TestMethod]
        public void TestRata1()
        {
            var rata = P4_RataDescendenta.CalculeazaRata(40000, 7.57f, 20*12, 12*3+3);
            Assert.AreEqual(379.04, rata, 0.1);
        }

        [TestMethod]
        public void TestRata2()
        {
            var rata = P4_RataDescendenta.CalculeazaRata(40000, 7.57f, 20 * 12, 1);
            Assert.AreEqual(418.93, rata, 0.1);
        }

        [TestMethod]
        public void TestRata3()
        {
            var rata = P4_RataDescendenta.CalculeazaRata(40000, 7.57f, 20 * 12, 20*12);
            Assert.AreEqual(167.71, rata, 0.1);
        }

        [TestMethod]
        public void TestRata4()
        {
            var rata = P4_RataDescendenta.CalculeazaRata(10000, 10f, 1 * 12, 1);
            Assert.AreEqual(916.66, rata, 0.1);
        }

        [TestMethod]
        public void TestRata5()
        {
            var rata = P4_RataDescendenta.CalculeazaRata(10000, 10f, 1 * 12, 6);
            Assert.AreEqual(881.94, rata, 0.1);
        }

        [TestMethod]
        public void TestRata6()
        {
            var rata = P4_RataDescendenta.CalculeazaRata(10000, 10f, 1 * 12, 12);
            Assert.AreEqual(840.27, rata, 0.1);
        }
    }
}
