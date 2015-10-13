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
    }
}
