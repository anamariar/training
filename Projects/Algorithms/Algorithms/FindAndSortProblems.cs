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

        private static void InsertNumber(ref uint[] sorted, uint number)
        {
            Array.Resize(ref sorted, sorted.Length + 1);
            int index = sorted.Length - 1;
            for (int i = 0; i < sorted.Length - 1; i++)
            {
                if (number < sorted[i])
                {
                    index = i;
                    break;
                }
            }
            for (int j = sorted.Length - 1; j > index; j--)
            {
                sorted[j] = sorted[j - 1];
            }
            sorted[index] = number;
        }
    }
}
