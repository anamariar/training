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
            string text = "* 3 4";
            Assert.AreEqual(12f, RecursiveProblems.Calculator(text));
        }

        [TestMethod]
        public void CalculatorTwoOperationsTest()
        {
            string text = "* + 1 1 2";
            Assert.AreEqual(4f, RecursiveProblems.Calculator(text));
        }

        [TestMethod]
        public void CalculatorMultipleOperationsTest()
        {
            string text = "* / * + 56 45 45 3 0.75";
            Assert.AreEqual(1136.25f, RecursiveProblems.Calculator(text));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CalculatorInvalidStringTest()
        {
            string text = "* 3";
            Assert.AreEqual(0f, RecursiveProblems.Calculator(text));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CalculatorInvalidStringOperatorAtTheEndTest()
        {
            string text = "* 3 *";
            Assert.AreEqual(0f, RecursiveProblems.Calculator(text));
        }
        
    }
}