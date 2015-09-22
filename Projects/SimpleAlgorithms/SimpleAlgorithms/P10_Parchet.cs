using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P10_Parchet
    {
        public static int CalculeazaParchet(int n, int m, int a, int b, int pierderi)
        {
            var suprafataTotala = n * m + n * m * pierderi / 100;
            var suprafataPlacaParchet = a * b;
            float placiParchet = (float)suprafataTotala / suprafataPlacaParchet;
            return (placiParchet % 1 == 0) ? (int)placiParchet : (int)(placiParchet + 1);
        }
    }
}
