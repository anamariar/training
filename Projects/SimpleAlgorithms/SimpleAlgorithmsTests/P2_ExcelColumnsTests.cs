using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P2_ExcelColumnsTests
    {
        [TestMethod]
        public void TestExcelComlumns1()
        {
            string result = P2_ExcelColumns.GetColumn(1);
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void TestExcelComlumns2()
        {
            string result = P2_ExcelColumns.GetColumn(26);
            Assert.AreEqual("Z", result);
        }

        [TestMethod]
        public void TestExcelComlumns3()
        {
            string result = P2_ExcelColumns.GetColumn(100);
            Assert.AreEqual("CV", result);
        }

        [TestMethod]
        public void TestExcelComlumns4()
        {
            string result = P2_ExcelColumns.GetColumn(260);
            Assert.AreEqual("JZ", result);
        }

        [TestMethod]
        public void TestExcelComlumns5()
        {
            string result = P2_ExcelColumns.GetColumn(1001);
            Assert.AreEqual("ALM", result);
        }

        [TestMethod]
        public void TestExcelComlumns6()
        {
            string result = P2_ExcelColumns.GetColumn(2600);
            Assert.AreEqual("CVZ", result);
        }

        [TestMethod]
        public void TestExcelComlumns7()
        {
            string result = P2_ExcelColumns.GetColumn(130);
            Assert.AreEqual("DZ", result);
        }

        [TestMethod]
        public void TestExcelComlumns8()
        {
            string result = P2_ExcelColumns.GetColumn(676);
            Assert.AreEqual("ZZ", result);
        }
    }
}
