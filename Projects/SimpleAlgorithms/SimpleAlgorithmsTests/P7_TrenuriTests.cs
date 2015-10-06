using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P7_TrenuriTests
    {
        [TestMethod]
        public void TestTrenuri1()
        {
            var distantaPasare = P7_Trenuri.CalculeazaDistanta(100);
            Assert.AreEqual(50, distantaPasare);
        }
        
    }
}
