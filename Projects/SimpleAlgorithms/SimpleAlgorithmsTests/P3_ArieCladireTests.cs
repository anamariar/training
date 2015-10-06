using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P3_ArieCladireTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            P3_ArieCladire.Punct A = new P3_ArieCladire.Punct(0.000000f, 0.000000f);
            P3_ArieCladire.Punct B = new P3_ArieCladire.Punct(1.000000f, 1.000000f);
            P3_ArieCladire.Punct C = new P3_ArieCladire.Punct(0.000000f, 1.000000f);

            var area = P3_ArieCladire.CalculeazaAriaCladirii(A, B, C);
            Assert.AreEqual(1, area);
        }

        [TestMethod]
        public void TestMethod2()
        {
            P3_ArieCladire.Punct A = new P3_ArieCladire.Punct(2.000000f, 4.000000f);
            P3_ArieCladire.Punct B = new P3_ArieCladire.Punct(5.000000f, 7.000000f);
            P3_ArieCladire.Punct C = new P3_ArieCladire.Punct(5.000000f, 1.000000f);

            var area = P3_ArieCladire.CalculeazaAriaCladirii(A, B, C);
            Assert.AreEqual(18, area);
        }

        [TestMethod]
        public void TestMethod3()
        {
            P3_ArieCladire.Punct A = new P3_ArieCladire.Punct(1.000000f, 4.000000f);
            P3_ArieCladire.Punct B = new P3_ArieCladire.Punct(1.000000f, 7.000000f);
            P3_ArieCladire.Punct C = new P3_ArieCladire.Punct(1.000000f, 9.000000f);

            var area = P3_ArieCladire.CalculeazaAriaCladirii(A, B, C);
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TestMethod4()
        {
            P3_ArieCladire.Punct A = new P3_ArieCladire.Punct(1.000000f, 1.000000f);
            P3_ArieCladire.Punct B = new P3_ArieCladire.Punct(-2.000000f, 2.000000f);
            P3_ArieCladire.Punct C = new P3_ArieCladire.Punct(1.000000f, 3.000000f);

            var area = P3_ArieCladire.CalculeazaAriaCladirii(A, B, C);
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TestMethod5()
        {
            P3_ArieCladire.Punct A = new P3_ArieCladire.Punct(-2.000000f, 1.000000f);
            P3_ArieCladire.Punct B = new P3_ArieCladire.Punct(-1.000000f, -3.000000f);
            P3_ArieCladire.Punct C = new P3_ArieCladire.Punct(5.000000f, -5.000000f);

            var area = P3_ArieCladire.CalculeazaAriaCladirii(A, B, C);
            Assert.AreEqual(22, area);
        }
    }
}
