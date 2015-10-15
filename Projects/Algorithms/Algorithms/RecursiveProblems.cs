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
            uint[] previousRow = new uint[row];
            result[0] = 1;
            if (row > 0)
            {
                result[row] = 1;
                previousRow = GetPascalTriangleRow(row - 1);
            }
            for (int i = 1; i < row; i++)
            {               
                result[i] = previousRow[i] + previousRow[i - 1];
            }
            return result;
        }        

        internal static float Calculate(string prefixedExpression)
        {
            if (prefixedExpression.Length < 3) throw new InvalidOperationException();

            string[] expression = prefixedExpression.Split(' ');            
            if (expression.Length == 3) return DoOperation(expression[0], expression[2], expression[1]);

            var firstElement = expression[0];
            var lastElement = expression[expression.Length - 1];
            string[] newExpression = new string[expression.Length - 2];
            Array.Copy(expression, 1, newExpression, 0, newExpression.Length);
            string newPrefixedExpression = String.Join(" ", newExpression);
            return DoOperation(firstElement, Calculate(newPrefixedExpression).ToString(CultureInfo.InvariantCulture), lastElement);
        }

        private static float DoOperation(string stringOperator, string firstOperand, string secondOperand)
        {
            float firstNumber;
            float secondNumber;
            if (float.TryParse(firstOperand, out firstNumber) && float.TryParse(secondOperand, out secondNumber))
            {
                switch (stringOperator)
                {
                    case "+": return firstNumber + secondNumber;
                    case "-": return firstNumber - secondNumber;
                    case "*": return firstNumber * secondNumber;
                    case "/": return firstNumber / secondNumber;
                    default: break;
                } 
            }
            return 0;
        }

    }
}
