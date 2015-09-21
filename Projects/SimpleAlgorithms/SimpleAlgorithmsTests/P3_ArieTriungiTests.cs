using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P3_ArieTriungiTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            P3_ArieTriunghi.Point A = new P3_ArieTriunghi.Point(0.000000f, 0.000000f);
            P3_ArieTriunghi.Point B = new P3_ArieTriunghi.Point(1.000000f, 1.000000f);
            P3_ArieTriunghi.Point C = new P3_ArieTriunghi.Point(0.000000f, 1.000000f);

            var area = P3_ArieTriunghi.GetTriagleArea(A, B, C);
            Assert.AreEqual(0.5, area);
        }

        [TestMethod]
        public void TestMethod2()
        {
            P3_ArieTriunghi.Point A = new P3_ArieTriunghi.Point(2.000000f, 4.000000f);
            P3_ArieTriunghi.Point B = new P3_ArieTriunghi.Point(5.000000f, 7.000000f);
            P3_ArieTriunghi.Point C = new P3_ArieTriunghi.Point(5.000000f, 1.000000f);

            var area = P3_ArieTriunghi.GetTriagleArea(A, B, C);
            Assert.AreEqual(9, area);
        }

        [TestMethod]
        public void TestMethod3()
        {
            P3_ArieTriunghi.Point A = new P3_ArieTriunghi.Point(1.000000f, 4.000000f);
            P3_ArieTriunghi.Point B = new P3_ArieTriunghi.Point(1.000000f, 7.000000f);
            P3_ArieTriunghi.Point C = new P3_ArieTriunghi.Point(1.000000f, 9.000000f);

            var area = P3_ArieTriunghi.GetTriagleArea(A, B, C);
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TestMethod4()
        {
            P3_ArieTriunghi.Point A = new P3_ArieTriunghi.Point(1.000000f, 1.000000f);
            P3_ArieTriunghi.Point B = new P3_ArieTriunghi.Point(-2.000000f, 2.000000f);
            P3_ArieTriunghi.Point C = new P3_ArieTriunghi.Point(1.000000f, 3.000000f);

            var area = P3_ArieTriunghi.GetTriagleArea(A, B, C);
            Assert.AreEqual(3, area);
        }

        [TestMethod]
        public void TestMethod5()
        {
            P3_ArieTriunghi.Point A = new P3_ArieTriunghi.Point(-2.000000f, 1.000000f);
            P3_ArieTriunghi.Point B = new P3_ArieTriunghi.Point(-1.000000f, -3.000000f);
            P3_ArieTriunghi.Point C = new P3_ArieTriunghi.Point(5.000000f, -5.000000f);

            var area = P3_ArieTriunghi.GetTriagleArea(A, B, C);
            Assert.AreEqual(11, area);
        }
    }
}
