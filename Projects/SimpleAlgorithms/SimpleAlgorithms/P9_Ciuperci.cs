using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P9_Ciuperci
    {
        public static Tuple<int, int> CalculeazaCiuperci(int N, int x)
        {
            var albe = N / (x + 1);
            var rosii = x * N / (x + 1);
            return (N % ++x == 0) ? new Tuple<int, int>(albe, rosii) : new Tuple<int, int>(-1, -1);
        }
    }
}
