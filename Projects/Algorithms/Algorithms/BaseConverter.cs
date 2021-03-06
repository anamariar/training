﻿using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AlgorithmsTests")]
namespace Algorithms
{
    public static class BaseConverter
    {
        internal static byte[] ConvertIntoBase(ushort number, ushort intoBase)
        {
            byte[] result = new byte[Byte.MaxValue];
            ushort size = 0;
            if (number == 0) return new byte[] { 0 };
            while (number > 0)
            {
                result[size] = (byte)(number % intoBase);
                number /= intoBase;
                size++;
            }
            Array.Resize(ref result, size);
            Array.Reverse(result);
            return result;
        }

        internal static int ConvertFromBase(byte[] number, ushort fromBase)
        {
            int result = 0;
            Array.Reverse(number);
            for (ushort i= 0; i< number.Length; i++)
            {
                result += number[i] * Power(fromBase, i);
            }
            return result;
        }

        internal static byte[] AndBaseTwo(byte[] firstNumber, byte[] secondNumber)
        {            
            return DoOperation(And, firstNumber, secondNumber);
        }

        internal static byte[] OrBaseTwo(byte[] firstNumber, byte[] secondNumber)
        {
            return DoOperation(Or, firstNumber, secondNumber);
        }

        internal static byte[] XorBaseTwo(byte[] firstNumber, byte[] secondNumber)
        {
            return DoOperation(Xor, firstNumber, secondNumber);
        }

        internal static byte[] NotBaseTwo(byte[] number)
        {
            byte[] result = new byte[number.Length];
            for (int i=0; i < number.Length; i++)
            {
                result[i] = Not(number[i]);
            }
            return result;
        }

        internal static byte[] DoOperation(Func<byte, byte, byte> operation, byte[] firstNumber, byte[] secondNumber)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            AddZerosToLeft(ref firstNumber, result.Length - firstNumber.Length);
            AddZerosToLeft(ref secondNumber, result.Length - secondNumber.Length);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = operation(firstNumber[i], secondNumber[i]);
            }
            return result;
        }        

        internal static byte[] Add(byte[] firstNumber, byte[] secondNumber, byte numbersBase)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            AddZerosToLeft(ref firstNumber, result.Length - firstNumber.Length);
            AddZerosToLeft(ref secondNumber, result.Length - secondNumber.Length);

            byte carry = 0;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = (byte)((firstNumber[i] + secondNumber[i] + carry) % numbersBase);
                carry = (byte)((firstNumber[i] + secondNumber[i] + carry) / numbersBase);
            }
            AddCarryToLeft(ref result, carry);
            return result;
        }

        internal static byte[] Subtract(byte[] firstNumber, byte[] secondNumber, byte numbersBase)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            AddZerosToLeft(ref firstNumber, result.Length - firstNumber.Length);
            AddZerosToLeft(ref secondNumber, result.Length - secondNumber.Length);

            int carry = 0;
            if (GreaterThan(firstNumber, secondNumber))
            {
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    if (carry + firstNumber[i] < secondNumber[i])
                    {
                        result[i] = (byte)(numbersBase + firstNumber[i] + carry - secondNumber[i]);
                        carry = -1;
                    }
                    else
                    {
                        result[i] = (byte)(firstNumber[i] + carry - secondNumber[i]);
                        carry = 0;
                    }
                } 
            }
            RemoveZerosFromLeft(ref result);
            return result;
        }

        internal static bool GreaterThan(byte[] greaterNumber, byte[] lowerNumber)
        {
            int length = 0;
            length = Math.Max(greaterNumber.Length, lowerNumber.Length);
            AddZerosToLeft(ref greaterNumber, length - greaterNumber.Length);
            AddZerosToLeft(ref lowerNumber, length - lowerNumber.Length);

            bool result = false;
            for (int i = 0; i < length; i++)
            {
                if (greaterNumber[i] > lowerNumber[i])
                {
                    result = true;
                    break;
                }
                else
                {
                    if (greaterNumber[i] < lowerNumber[i]) break;
                }
            }
            return result;
        }

        internal static byte[] Multiply(byte[] firstNumber, byte[] secondNumber, byte numbersBase)
        {
            byte[] result = { 0 };
            for (byte[] index = { 0 }; GreaterThan(secondNumber, index); index = Add(index, new byte[] { 1 }, numbersBase))
            {
                result = Add(result, firstNumber, numbersBase);
            }
            return result;
        }

        internal static byte[] Divide(byte[] firstNumber, byte[] secondNumber, byte numbersBase)
        {            
            if (!GreaterThan(secondNumber, new byte[] { 0 })) throw new DivideByZeroException();

            byte[] result = { 0 };
            while (GreaterThan(firstNumber, Subtract(secondNumber, new byte[] { 1 }, numbersBase)))
            {
                firstNumber = Subtract(firstNumber, secondNumber, numbersBase);
                result = Add(result, new byte[] { 1 }, numbersBase);
            }
            return result;
        }
        
        private static byte And(byte firstBit, byte secondBit)
        {
            return (firstBit != secondBit) ? (byte)0 : firstBit;
        }

        private static byte Or(byte firstBit, byte secondBit)
        {
            return (firstBit != secondBit) ? (byte)1 : firstBit;
        }

        private static byte Not(byte bit)
        {
            return (bit == 0) ? (byte)1 : (byte)0;
        }

        private static byte Xor(byte firstBit, byte secondBit)
        {
            return (firstBit != secondBit)? (byte)1 : (byte)0;
        }

        private static void RotateRight(ref byte[] number, int positions)
        {            
            for (int j = 1; j <= positions; j++)
            {
                byte[] rotatedNumber = new byte[number.Length];
                for (int i = 0; i < number.Length - 1; i++)
                {
                    rotatedNumber[i + 1] = number[i];
                }
                rotatedNumber[0] = number[number.Length - 1];
                number = rotatedNumber;
            }        
        }

        private static void RotateLeft(ref byte[] number, int positions)
        {
            for (int j = 1; j <= positions; j++)
            {
                byte[] rotatedNumber = new byte[number.Length];
                for (int i = 1; i < number.Length; i++)
                {
                    rotatedNumber[i - 1] = number[i];
                }
                rotatedNumber[number.Length - 1] = number[0];
                number = rotatedNumber;
            }
        }

        private static void AddCarryToLeft(ref byte[] result, byte carry)
        {
            if (carry == 1)
            {
                Array.Resize(ref result, result.Length + 1);
                RotateRight(ref result, 1);
                result[0] = carry;
            }
        }

        private static void RemoveZerosFromLeft(ref byte[] result)
        {
            int positions = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] != 0) break;
                else positions++;
            }
            RotateLeft(ref result, positions);
            Array.Resize(ref result, result.Length - positions);
        }

        private static void AddZerosToLeft(ref byte[] number, int positions)
        {
            Array.Resize(ref number, number.Length + positions);
            RotateRight(ref number, positions);
        }

        private static int Power(ushort number, ushort exponent)
        {
            return (exponent > 0) ? number * Power(number, (ushort)(exponent - 1)) : 1;
        }
    }
}
