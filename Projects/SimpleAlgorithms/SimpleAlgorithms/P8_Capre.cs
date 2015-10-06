using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P8_Capre
    {
        public static float CalculeazaKilograme(int x_zile, int y_capre, int z_kg, int w_zile, int q_capre)
        {
            return (float) z_kg * w_zile * q_capre / (x_zile * y_capre);
        }
    }
}
