using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class ChessTableTests
    {
        [TestMethod]
        public void ChessTableTest1()
        {
            Assert.AreEqual(0, ChessTable.GetSquares(0));
        }

        [TestMethod]
        public void ChessTableeTest2()
        {
            Assert.AreEqual(1, ChessTable.GetSquares(1));
        }

        [TestMethod]
        public void ChessTableTest3()
        {
            Assert.AreEqual(5, ChessTable.GetSquares(2));
        }

        [TestMethod]
        public void ChessTableTest4()
        {
            Assert.AreEqual(14, ChessTable.GetSquares(3));
        }

        [TestMethod]
        public void ChessTableTest5()
        {
            Assert.AreEqual(204, ChessTable.GetSquares(8));
        }
    }
}
