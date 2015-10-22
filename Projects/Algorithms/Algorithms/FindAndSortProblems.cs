using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FindAndSortProblems
    {
        internal static uint[] SortLotteryNumbers(uint[] loterryNumbers)
        {
            uint[] sorted = new uint[0];
            for (uint i=0; i< loterryNumbers.Length; i++)
            {
                InsertNumber(ref sorted, loterryNumbers[i]);
            }
            return sorted;
        }

        internal static void SortCases(uint[] inputArray, uint left, uint right, uint pivot)
        {
            uint i = 0;
            while (i <= right)
            {
                if (inputArray[i] < pivot) Swap(ref inputArray[left++], ref inputArray[i++]);
                else if (inputArray[i] > pivot) Swap(ref inputArray[i], ref inputArray[right--]);
                else i++;
            }
        }

        internal static Word[] SortWords(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '!', '?' };
            string[] textArray = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            var words = GetWordInformation(textArray);
            MergeSort(words, 0, words.Length - 1);
            return words;
        }
        
        internal static void SortCandidates(Candidate[] candidates, Candidate[] results)
        {
            AddResults(candidates, results);
            ShellSort(candidates);
        }

        private static void AddResults(Candidate[] candidates, Candidate[] results)
        {
            for (int i = 0; i < candidates.Length; i++)
            {
                for (int j = 0; j < results.Length; j++)
                {
                    if (String.Compare(candidates[i].Name, results[j].Name, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        candidates[i].Votes += results[j].Votes;
                        break;
                    }
                }
            }
        }

        public static void ShellSort(Candidate[] inputArray)
        {
            uint j = 0;
            Candidate temp = new Candidate();
            uint increment = (uint)(inputArray.Length) / 2;
            while (increment > 0)
            {
                for (uint index = 0; index < inputArray.Length; index++)
                {
                    j = index;
                    temp = inputArray[index];
                    while ((j >= increment) && inputArray[j - increment].Votes < temp.Votes)
                    {
                        inputArray[j] = inputArray[j - increment];
                        j = j - increment;
                    }
                    inputArray[j] = temp;
                }
                increment /= 2;
            }
        }

        private static Word[] GetWordInformation(string[] original)
        {
            Word[] result = new Word[original.Length];
            int size = 0;
            for (int i = 1; i < original.Length + 1; i++)
            {
                bool found = false;
                for (int j = 0; j < size; j++)
                {
                    if (String.Compare(original[i - 1], result[j].Name, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        found = true;
                        result[j].Occurence++;
                    }
                }
                if (!found)
                {
                    result[size].Occurence = 1;
                    result[size++].Name = original[i - 1];
                }
            }
            Array.Resize(ref result, size);
            return result;
        }

        private static void MergeSort(Word[] words, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(words, left, middle);
                MergeSort(words, middle + 1, right);
                Merge(words, left, middle + 1, right);
            }
        }

        private static void Merge(Word[] words, int left, int middle, int right)
        {
            Word[] temp = new Word[words.Length];

            int leftEnd = (middle - 1);
            int position = left;
            int rightEnd = (right - left + 1);

            while ((left <= leftEnd) && (middle <= right))
            {
                temp[position++] = (words[left].Occurence <= words[middle].Occurence) ? words[middle++] : words[left++];
            }
            while (left <= leftEnd) temp[position++] = words[left++];
            while (middle <= right) temp[position++] = words[middle++];
            for (int i = 0; i < rightEnd; i++)
            {
                words[right] = temp[right];
                right--;
            }
        }

        private static void InsertNumber(ref uint[] sorted, uint number)
        {
            Array.Resize(ref sorted, sorted.Length + 1);
            sorted[sorted.Length - 1] = number;
            for (int i = 0; i < sorted.Length - 1; i++)
            {
                if (number < sorted[i])
                {
                    for (int j = sorted.Length - 1; j > i; j--)
                    {
                        sorted[j] = sorted[j - 1];
                    }
                    sorted[i] = number;
                    break;
                }
            }
        }

        private static void Swap(ref uint firstValue, ref uint secondValue)
        {
            uint temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }

        public struct Candidate
        {
            public string Name;
            public uint Votes;
        }

        public struct Word
        {
            public string Name;
            public uint Occurence;
        }

        public struct Pupil
        {
            public string Name;
            public uint[][] Grades; 
        }
    }
}
