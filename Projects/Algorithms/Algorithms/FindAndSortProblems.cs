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

    }
}
