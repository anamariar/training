using System;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AlgorithmsTests")]
namespace Algorithms
{
    public static class RecursiveProblems
    {
        internal static string ReverseString(string text)
        {
            if (text.Length == 1) return text;
            return text[text.Length - 1] + ReverseString(text.Remove(text.Length - 1, 1));
        }
        internal static string ReplaceStringChar(string text, char originalChar, char replaceChar)
        {
            if (text.Length == 1) return ReplaceChar(text, originalChar, replaceChar);
            return ReplaceChar(text[0].ToString(), originalChar, replaceChar) + ReplaceStringChar(text.Substring(1), originalChar, replaceChar);
        }

        private static string ReplaceChar(string text, char original, char replace)
        {
            if (text[0] == original) text = replace.ToString();
            return text;
        }

        internal static uint[] GetPascalTriangleRow(uint row)
        {
            uint[] result = new uint[row + 1];
            uint[] previous = new uint[row];
            result[0] = 1;
            if (row > 0)
            {
                result[row] = 1;
                previous = GetPascalTriangleRow(row - 1);
            }
            for (int i = 1; i < row; i++)
            {               
                result[i] = previous[i] + previous[i - 1];
            }
            return result;
        }        

        internal static float Calculator(string text)
        {
            if (text.Length < 3) throw new InvalidOperationException();

            string[] textArray = text.Split(' ');            
            if (textArray.Length == 3) return DoOperation(textArray[0], textArray[2], textArray[1]);

            var firstElement = textArray[0];
            var lastElement = textArray[textArray.Length - 1];
            string[] newTextArray = new string[textArray.Length - 2];
            Array.Copy(textArray, 1, newTextArray, 0, newTextArray.Length);
            string newText = String.Join(" ", newTextArray);
            return DoOperation(firstElement, Calculator(newText).ToString(CultureInfo.InvariantCulture), lastElement);
        }

        private static float DoOperation(string stringOperator, string firstOperand, string secondOperand)
        {          
            var firstNumber = float.Parse(firstOperand, CultureInfo.InvariantCulture.NumberFormat);
            var secondNumber = float.Parse(secondOperand, CultureInfo.InvariantCulture.NumberFormat);
            switch (stringOperator)
            {
                case "+": return firstNumber + secondNumber;
                case "-": return firstNumber - secondNumber;
                case "*": return firstNumber * secondNumber;
                case "/": return firstNumber / secondNumber;
                default: break;
            }
            return 0;
        }

    }
}
