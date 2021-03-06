﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class RecursiveProblemsTests
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            string text = "abcd";
            string expected = "dcba";
            Assert.AreEqual(expected, RecursiveProblems.ReverseString(text));
        }

        [TestMethod]
        public void ReverseOnCharStringTest()
        {
            string text = "a";
            string expected = "a";
            Assert.AreEqual(expected, RecursiveProblems.ReverseString(text));
        }

        [TestMethod]
        public void ReplaceCharFormStringTest()
        {
            string text = "abacda";
            char replaceChar = 'a';
            char replaceWith = '*';
            string expected = "*b*cd*";
            Assert.AreEqual(expected, RecursiveProblems.ReplaceStringChar(text, replaceChar, replaceWith));
        }

        [TestMethod]
        public void VerifyFirstRowOfPascalTriangleTest()
        {
            uint[] expected = new uint[] { 1 };
            CollectionAssert.AreEqual(expected, RecursiveProblems.GetPascalTriangleRow(0));
        }

        [TestMethod]
        public void VerifySecondRowOfPascalTriangleTest()
        {
            uint[] expected = new uint[] { 1, 1 };
            CollectionAssert.AreEqual(expected, RecursiveProblems.GetPascalTriangleRow(1));
        }

        [TestMethod]
        public void VerifyRowOfPascalTriangleTest()
        {
            uint[] expected = new uint[] { 1, 6, 15, 20, 15, 6, 1 };
            CollectionAssert.AreEqual(expected, RecursiveProblems.GetPascalTriangleRow(6));
        }        
        
        [TestMethod]
        public void CalculatorOneOperationTest()
        {
            string prefixedExpression = "* 3 4";
            Assert.AreEqual("12", RecursiveProblems.Calculator(prefixedExpression));
        }

        [TestMethod]
        public void CalculatorMultipleOperationsTest()
        {
            string prefixedExpression = "* / * + 56 45 45 3 0.75";
            Assert.AreEqual("1136.25", RecursiveProblems.Calculator(prefixedExpression));
        }

        [TestMethod]
        public void CalculatorInvalidExpressionTest()
        {
            string prefixedExpression = "3 * * 3 5";
            Assert.AreEqual("3 * 15", RecursiveProblems.Calculator(prefixedExpression));
        }

        [TestMethod]
        public void CalculatorInvalidOperatorAtTheEndTest()
        {
            string prefixedExpression = "3 * 3 5 *";
            Assert.AreEqual("3 * 3 5 *", RecursiveProblems.Calculator(prefixedExpression));
        }

        [TestMethod]
        public void CalculatorEmptyStringTest()
        {
            string prefixedExpression = "";
            Assert.AreEqual("", RecursiveProblems.Calculator(prefixedExpression));
        }        

        [TestMethod]
        public void CalculatorOperationsPrecedenceTest()
        {
            string prefixedExpression = "- * 4 + 2 1 * 2 - 3 2";
            Assert.AreEqual("10", RecursiveProblems.Calculator(prefixedExpression));
        }

        [TestMethod]
        public void HanoiTowersOneDiskTest()
        {
            uint disks = 1;
            byte[] source = new byte[] { 1 };
            byte[] destination = new byte[0];
            byte[] aux = new byte[0];
            uint currentMove = 0;
            RecursiveProblems.HanoiTowers(disks, ref source, ref destination, ref aux, ref currentMove, 1);
            Assert.AreEqual((uint)1, currentMove);
            CollectionAssert.AreEqual(new byte[] { 1 }, destination);
            Assert.AreEqual(0, source.Length);
            Assert.AreEqual(0, aux.Length);
        }

        [TestMethod]
        public void HanoiTowersIntermediateStateTest()
        {
            uint disks = 4;
            byte[] source = new byte[] { 4, 3, 2, 1 };
            byte[] destination = new byte[0];
            byte[] aux = new byte[0];
            uint currentMove = 0;
            RecursiveProblems.HanoiTowers(disks, ref source, ref destination, ref aux, ref currentMove, 6);
            CollectionAssert.AreEqual(new byte[] { 4, 1 }, source);
            Assert.AreEqual(0, destination.Length);
            CollectionAssert.AreEqual(new byte[] { 3, 2 }, aux);
        }

        [TestMethod]
        public void HanoiTowersNoMovesTest()
        {
            uint disks = 4;
            byte[] source = new byte[] { 4, 3, 2, 1 };
            byte[] destination = new byte[0];
            byte[] aux = new byte[0];
            uint currentMove = 0;
            RecursiveProblems.HanoiTowers(disks, ref source, ref destination, ref aux, ref currentMove, 0);
            Assert.AreEqual((uint)0, currentMove);
            CollectionAssert.AreEqual(new byte[] { 4, 3, 2, 1 }, source);
            Assert.AreEqual(0, destination.Length);
            Assert.AreEqual(0, aux.Length);
        }

        [TestMethod]
        public void HanoiTowersTenDisksTest()
        {
            uint disks = 10;
            byte[] source = new byte[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            byte[] destination = new byte[0];
            byte[] aux = new byte[0];
            uint currentMove = 0;
            RecursiveProblems.HanoiTowers(disks, ref source, ref destination, ref aux, ref currentMove, uint.MaxValue);
            Assert.AreEqual((uint)1023, currentMove);
            CollectionAssert.AreEqual(new byte[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, destination);
            Assert.AreEqual(0, source.Length);
            Assert.AreEqual(0, aux.Length);
        }
    }
}
