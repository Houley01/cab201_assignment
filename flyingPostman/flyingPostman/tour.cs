using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyingPostman
{
    class Tour
    {

        public static double CalculateTheDistanceBetweenPlaces(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt((x1 - x2) ^ 2 + (y1 - y2) ^ 2);
        }
    }
}
