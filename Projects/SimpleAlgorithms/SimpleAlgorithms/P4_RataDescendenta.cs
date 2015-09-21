using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P4_RataDescendenta
    {
        public static float CalculeazaRata(int suma, float dobanda, int perioada, int luna)
        {
            float rata = (float) suma / perioada + (suma -(--luna) * suma / perioada) * dobanda / (12 * 100);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            return rata;
        }
    }
}
