using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P1_Pavaj
    {
        public static int GetStonesNumber(ushort m, ushort n, ushort a)
        {
            var columns = (m % a > 0) ? ((m / a) + 1) : (m / a);
            var lines = (n % a > 0) ? ((n / a) + 1) : (n / a);
            return columns * lines;
        }
    }
}
