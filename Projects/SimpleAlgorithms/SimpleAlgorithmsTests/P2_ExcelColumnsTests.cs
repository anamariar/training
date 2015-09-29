using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P2_ExcelColumnsTests
    {
        [TestMethod]
        public void TestExcelColumns1()
        {
            string result = P2_ExcelColumns.GetColumn(1);
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void TestExcelColumns2()
        {
            string result = P2_ExcelColumns.GetColumn(26);
            Assert.AreEqual("Z", result);
        }

        [TestMethod]
        public void TestExcelColumns3()
        {
            string result = P2_ExcelColumns.GetColumn(100);
            Assert.AreEqual("CV", result);
        }

        [TestMethod]
        public void TestExcelColumns4()
        {
            string result = P2_ExcelColumns.GetColumn(260);
            Assert.AreEqual("IZ", result);
        }

        [TestMethod]
        public void TestExcelColumns5()
        {
            string result = P2_ExcelColumns.GetColumn(1001);
            Assert.AreEqual("ALM", result);
        }

        [TestMethod]
        public void TestExcelColumns6()
        {
            string result = P2_ExcelColumns.GetColumn(2600);
            Assert.AreEqual("CUZ", result);
        }

        [TestMethod]
        public void TestExcelColumns7()
        {
            string result = P2_ExcelColumns.GetColumn(130);
            Assert.AreEqual("DZ", result);
        }

        [TestMethod]
        public void TestExcelColumns8()
        {
            string result = P2_ExcelColumns.GetColumn(676);
            Assert.AreEqual("YZ", result);
        }

        [TestMethod]
        public void TestExcelColumns9()
        {
            string result = P2_ExcelColumns.GetColumn(702);
            Assert.AreEqual("ZZ", result);
        }

        [TestMethod]
        public void TestExcelColumns10()
        {
            string result = P2_ExcelColumns.GetColumn(703);
            Assert.AreEqual("AAA", result);
        }
    }
}
