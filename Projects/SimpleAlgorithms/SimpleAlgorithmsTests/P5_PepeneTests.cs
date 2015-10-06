using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAlgorithms;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class P5_PepeneTests
    {
        [TestMethod]
        public void TestPepene1()
        {
            Assert.AreEqual("YES", P5_Pepene.IsDivisible(4));
        }

        [TestMethod]
        public void TestPepene2()
        {
            Assert.AreEqual("NO", P5_Pepene.IsDivisible(5));
        }

        [TestMethod]
        public void TestPepene3()
        {
            Assert.AreEqual("YES", P5_Pepene.IsDivisible(18));
        }

        [TestMethod]
        public void TestPepene4()
        {
            Assert.AreEqual("NO", P5_Pepene.IsDivisible(2));
        }

        [TestMethod]
        public void TestPepene5()
        {
            Assert.AreEqual("YES", P5_Pepene.IsDivisible(10));
        }
    }
}

