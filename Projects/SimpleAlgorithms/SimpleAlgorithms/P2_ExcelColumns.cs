using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P2_ExcelColumns
    {
        public static string GetColumn(int n)
        {
            char[] Letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            
            var result = (n > 0 && n <= 26) ? Letters[n % 27 - 1].ToString() : 
                (n > 26) ? GetColumn((n - 1) / 26) + Letters[(n - 1) % 26].ToString() : string.Empty;
            return result;
        }
    }
}
