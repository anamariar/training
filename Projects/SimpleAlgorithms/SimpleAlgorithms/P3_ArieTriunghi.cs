using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public static class P3_ArieTriunghi
    {
        public struct Point
        {
            public float x, y;
            public Point(float p1, float p2)
            {
                x = p1;
                y = p2;
            }
        }

        public static float GetTriagleArea(Point A, Point B, Point C)
        {
            var determinant = (A.x - C.x) * (B.y - A.y) - (A.x - B.x) * (C.y - A.y);
            var area = (determinant > 0) ? (determinant / 2) : (-determinant / 2);
            return area;
        }
    }
}
