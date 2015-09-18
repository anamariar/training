using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P5_Pepene
    {
        public static string IsDivisible(ushort kg)
        {
            return ((kg % 2 == 0) && (kg / 2 % 2 == 0)) ? "YES" : "NO";
        }
    }
}
