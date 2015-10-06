using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class LotteryWinningChances
    {
        public static double GetWinningChances(ushort playedNumbers, ushort totalNumbers, ushort category)
        {
            if ((playedNumbers * totalNumbers == 0) || (category == 0)) return 0;

            --category;
            return Combinations(playedNumbers - category, playedNumbers) * Combinations(category, totalNumbers - playedNumbers)
                / Combinations(playedNumbers, totalNumbers);
        }

        private static double Combinations(int usedNumbers, int totalNumbers)
        {
            return Factorial((uint) totalNumbers) / (Factorial((uint) usedNumbers) * Factorial((uint) totalNumbers - (uint) usedNumbers));
        }

        public static double Factorial(uint number)
        {
            return (number > 0) ? number * Factorial(number - 1): 1;
        }
    }
}
