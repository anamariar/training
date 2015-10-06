using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class EncryptDecryptMessage
    {
        public static string EncryptMessage(string message, ushort columns)
        {
            RemoveNonAlphabeticalChars(ref message);
            int lines = message.Length / columns;
            if (message.Length % columns != 0)
            {
                lines++;
                int randomStringLength = columns - message.Length % columns;
                message = message.Insert(message.Length, GetRandomString(randomStringLength));
            }
            return EncryptText(message, lines);
        }        

        public static string DecryptMessage(string message, ushort columns)
        {
            return EncryptText(message, columns);
        }

        private static string EncryptText(string text, int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                for (int index = i; index < text.Length; index+=number)
                {
                    result += text[index];
                }
            }
            return result;
        }

        private static string GetRandomString(int length)
        {
            string result = string.Empty;
            var random = new Random();
            for (int i=1; i<= length; i++)
            {
                result += (char)random.Next('a', 'z');
            }
            return result;
        }

        private static void RemoveNonAlphabeticalChars(ref string text)
        {
            char[] result = text.Where(c => char.IsLetter(c)).ToArray();
            text = new string(result);
        }
    }
}
