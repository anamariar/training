using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P6_Sportiv
    {        
        public static int GetWorkingRepetitions(int rounds)
        {
            return (rounds == 0) ? rounds : (GetWorkingRepetitions(rounds -1) + 2*rounds -1);
        }
    }
}
