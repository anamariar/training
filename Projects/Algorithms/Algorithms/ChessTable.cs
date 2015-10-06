using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ChessTable
    {
        public static int GetSquares(ushort tableSize)
        {
            int result = 0;
            for (ushort index = 1; index <= tableSize; index++)
            {
                result += index * index;
            }
            return result;
        }
    }
}
