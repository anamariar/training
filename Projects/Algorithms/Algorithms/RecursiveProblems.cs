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

        internal static string Calculator(string prefixedExpression)
        {
            string[] expression = prefixedExpression.Split(' ');
            if (expression.Length < 3) return prefixedExpression;

            int index = GetLastOperatorIndex(expression);
            bool invalidOperatorPosition = IsOperator(expression[expression.Length - 1]) || IsOperator(expression[expression.Length - 2]);
            if ((index >= 0)&&(!invalidOperatorPosition))
            {
                string operationResult = DoOperation(expression[index], expression[index + 1], expression[index + 2]);
                string[] newExpression = ReplaceExpression(expression, operationResult, index);
                string newPrefixedExpression = String.Join(" ", newExpression);
                return Calculator(newPrefixedExpression);
            }
            return prefixedExpression;
        }

        private static string DoOperation(string stringOperator, string firstOperand, string secondOperand)
        {
            float firstNumber;
            float secondNumber;
            if (float.TryParse(firstOperand, out firstNumber) && float.TryParse(secondOperand, out secondNumber))
            {
                switch (stringOperator)
                {
                    case "+": return (firstNumber + secondNumber).ToString();
                    case "-": return (firstNumber - secondNumber).ToString();
                    case "*": return (firstNumber * secondNumber).ToString();
                    case "/": return (firstNumber / secondNumber).ToString();
                    default: break;
                }
            }
            return "0";
        }        

        private static string[] ReplaceExpression(string[] expression, string operationResult, int index)
        {
            string[] result = new string[expression.Length - 2];
            for (int i = 0; i < index; i++)
            {
                result[i] = expression[i];
            }
            result[index] = operationResult;
            for (int i = index + 1; i < result.Length; i++)
            {
                result[i] = expression[i + 2];
            }
            return result;
        }

        private static int GetLastOperatorIndex(string[] expression)
        {
            for (int i = expression.Length - 3; i >= 0; i--)
            {
                if (IsOperator(expression[i])) return i;
            }
            return -1;
        }

        private static bool IsOperator(string element)
        {
            switch (element)
            {
                case "+": 
                case "-": 
                case "*": 
                case "/":
                    return true;
                default:
                    return false;
            }
        }
        
    }
}
