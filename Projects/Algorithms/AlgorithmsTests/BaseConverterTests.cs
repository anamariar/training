using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class BaseConverterTests
    {
        [TestMethod]
        public void ConvertZeroInBaseTwoTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0 }, BaseConverter.ConvertIntoBase(0, 2));
        }

        [TestMethod]
        public void ConvertNumberInBaseTwoTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, BaseConverter.ConvertIntoBase(6, 2));
        }

        [TestMethod]
        public void ConvertNumberInBaseEightTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 6 }, BaseConverter.ConvertIntoBase(70, 8));
        }

        [TestMethod]
        public void ConvertNumberInBaseSixteenTest()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 14, 8 }, BaseConverter.ConvertIntoBase(1000, 16));
        }

        [TestMethod]
        public void ConvertZeroFromBaseTwoIntoBaseTenTest()
        {
            Assert.AreEqual(0, BaseConverter.ConvertFromBase(new byte[] { 0 }, 2));
        }

        [TestMethod]
        public void ConvertNumberFromBaseTwoIntoBaseTenTest()
        {
            Assert.AreEqual(6, BaseConverter.ConvertFromBase(new byte[] { 1, 1, 0 }, 2));
        }

        [TestMethod]
        public void ConvertNumberFromBaseEightIntoBaseTenTest()
        {
            Assert.AreEqual(70, BaseConverter.ConvertFromBase(new byte[] { 1, 0, 6 }, 8));
        }

        [TestMethod]
        public void ConvertNumberFromBaseSixteenIntoBaseTenTest()
        {
            Assert.AreEqual(1000, BaseConverter.ConvertFromBase(new byte[] { 3, 14, 8 }, 16));
        }

        [TestMethod]
        public void AndBetweenBaseTwoNumbers()
        {
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1, 0, 0 };
            byte[] expected = new byte[] { 1, 0, 0, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.AndBaseTwo(firstNumber, secondNumber));
        }

        [TestMethod]
        public void AndBetweenBaseTwoNumbersOfDifferentLength()
        {
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1 };
            byte[] expected = new byte[] { 0, 0, 1, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.AndBaseTwo(firstNumber, secondNumber));
        }

        [TestMethod]
        public void OrBetweenBaseTwoNumbers()
        {
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1, 0, 0 };
            byte[] expected = new byte[] { 1, 1, 1, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.OrBaseTwo(firstNumber, secondNumber));
        }

        [TestMethod]
        public void OrBetweenBaseTwoNumbersOfDifferentLength()
        {
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1 };
            byte[] expected = new byte[] { 1, 0, 1, 1 };
            CollectionAssert.AreEqual(expected, BaseConverter.OrBaseTwo(firstNumber, secondNumber));
        }

        [TestMethod]
        public void XOrBetweenBaseTwoNumbers()
        {
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1, 0, 0 };
            byte[] expected = new byte[] { 0, 1, 1, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.XorBaseTwo(firstNumber, secondNumber));
        }

        [TestMethod]
        public void XOrBetweenBaseTwoNumbersOfDifferentLength()
        {
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1 };
            byte[] expected = new byte[] { 1, 0, 0, 1 };
            CollectionAssert.AreEqual(expected, BaseConverter.XorBaseTwo(firstNumber, secondNumber));
        }

        [TestMethod]
        public void NotBaseTwoTest()
        {
            byte[] number = new byte[] { 1, 0, 1, 0 };
            byte[] expected = new byte[] { 0, 1, 0, 1 };
            CollectionAssert.AreEqual(expected, BaseConverter.NotBaseTwo(number));
        }

        [TestMethod]
        public void AddNumbersInBaseTwoTest()
        {
            byte numbersBase = 2;
            byte[] firstNumber = new byte[] { 1, 1, 0 };
            byte[] secondNumber = new byte[] { 1 };
            byte[] expected = new byte[] { 1, 1, 1 };
            CollectionAssert.AreEqual(expected, BaseConverter.Add(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void AddNumbersInBaseTwoWhenResultLengthIsHigherTest()
        {
            byte numbersBase = 2;            
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1, 1, 1, 0 };
            byte[] expected = new byte[] { 1, 0, 1, 0, 0, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.Add(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void AddNumbersInBaseEightTest()
        {
            byte numbersBase = 8;
            byte[] firstNumber = new byte[] { 1, 0, 6 };
            byte[] secondNumber = new byte[] { 1, 0, 6 };
            byte[] expected = new byte[] { 2, 1, 4 };
            CollectionAssert.AreEqual(expected, BaseConverter.Add(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void AddNumbersBaseSixteenTest()
        {
            byte numbersBase = 16;
            byte[] firstNumber = new byte[] { 3, 14, 8 };
            byte[] secondNumber = new byte[] { 3, 14, 8 };
            byte[] expected = new byte[] { 7, 13, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.Add(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void AddNumbersInBaseSixteenWhenResultLengthIsHigher()
        {
            byte numbersBase = 16;
            byte[] firstNumber = new byte[] { 12, 7 };
            byte[] secondNumber = new byte[] { 12, 7 };
            byte[] expected = new byte[] { 1, 8, 14 };
            CollectionAssert.AreEqual(expected, BaseConverter.Add(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void SubstractNumbersInBaseTwoTest()
        {
            byte numbersBase = 2;
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 1 };
            byte[] expected = new byte[] { 1, 1, 1 };
            CollectionAssert.AreEqual(expected, BaseConverter.Subtract(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void SubstractNumbersInBaseEightTest()
        {
            byte numbersBase = 8;
            byte[] firstNumber = new byte[] { 2, 1, 4 };
            byte[] secondNumber = new byte[] { 1, 0, 6 };
            byte[] expected = new byte[] { 1, 0, 6 };
            CollectionAssert.AreEqual(expected, BaseConverter.Subtract(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void SubstarctNumbersInBaseSixteenTest()
        {
            byte numbersBase = 16;
            byte[] firstNumber = new byte[] { 1, 8, 14 };
            byte[] secondNumber = new byte[] { 12, 7 };
            byte[] expected = new byte[] { 12, 7 };
            CollectionAssert.AreEqual(expected, BaseConverter.Subtract(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void GreaterThanForBaseSixteenNumbersTest()
        {
            byte[] greaterNumber = new byte[] { 1, 8, 14 };
            byte[] lowerNumber = new byte[] { 12, 7 };
            Assert.IsTrue(BaseConverter.GreaterThan(greaterNumber, lowerNumber));
        }

        [TestMethod]
        public void GreaterThanForBaseTwoNumbersOfDifferentLenghtsTest()
        {
            byte[] greaterNumber = new byte[] { 1, 0, 1, 0 };
            byte[] lowerNumber = new byte[] { 1, 1 };
            Assert.IsFalse(BaseConverter.GreaterThan(lowerNumber, greaterNumber));
        }

        [TestMethod]
        public void GreaterThanForBaseTwoNumbersTest()
        {
            byte[] greaterNumber = new byte[] { 1, 0, 1, 0 };
            byte[] lowerNumber = new byte[] { 1, 0, 0, 0 };
            Assert.IsTrue(BaseConverter.GreaterThan(greaterNumber, lowerNumber));
        }

        [TestMethod]
        public void MultiplyBaseTwoNumbersTest()
        {
            byte numbersBase = 2;
            byte[] firstNumber = new byte[] { 1, 0, 1, 0 };
            byte[] secondNumber = new byte[] { 1, 0, 1, 0 };
            byte[] expected = new byte[] { 1, 1, 0, 0, 1, 0, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.Multiply(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void MultiplyBaseEightNumbersTest()
        {
            byte numbersBase = 8;
            byte[] firstNumber = new byte[] { 1, 2 };
            byte[] secondNumber = new byte[] { 1, 5 };
            byte[] expected = new byte[] { 2, 0, 2 };
            CollectionAssert.AreEqual(expected, BaseConverter.Multiply(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void MultiplyBaseSixteenNumbersTest()
        {
            byte numbersBase = 16;
            byte[] firstNumber = new byte[] { 1, 14 };
            byte[] secondNumber = new byte[] { 3, 2 };
            byte[] expected = new byte[] { 5, 13, 12 };
            CollectionAssert.AreEqual(expected, BaseConverter.Multiply(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void DivideBaseTwoNumbersTest()
        {
            byte numbersBase = 2;
            byte[] firstNumber = new byte[] { 1, 1, 0, 0, 1, 0, 0 };
            byte[] secondNumber = new byte[] { 1, 0, 1, 0 };
            byte[] expected = new byte[] { 1, 0, 1, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.Divide(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void DivideBaseTwoNumbersThatDontDivideExactlyTest()
        {
            byte numbersBase = 2;
            byte[] firstNumber = new byte[] { 1, 1, 0, 0, 1, 0, 1 };
            byte[] secondNumber = new byte[] { 1, 0, 1, 0 };
            byte[] expected = new byte[] { 1, 0, 1, 0 };
            CollectionAssert.AreEqual(expected, BaseConverter.Divide(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void DivideBaseEightNumbersTest()
        {
            byte numbersBase = 8;
            byte[] firstNumber = new byte[] { 2, 0, 2 };
            byte[] secondNumber = new byte[] { 1, 5 };
            byte[] expected = new byte[] { 1, 2 };
            CollectionAssert.AreEqual(expected, BaseConverter.Divide(firstNumber, secondNumber, numbersBase));
        }

        [TestMethod]
        public void DivideBaseSixteenNumbersTest()
        {
            byte numbersBase = 16;
            byte[] firstNumber = new byte[] { 5, 13, 12 };
            byte[] secondNumber = new byte[] { 3, 2 };
            byte[] expected = new byte[] { 1, 14 };
            CollectionAssert.AreEqual(expected, BaseConverter.Divide(firstNumber, secondNumber, numbersBase));
        }
    }
}
