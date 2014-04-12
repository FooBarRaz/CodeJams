using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam___MinimumScalarProduct
{
    class MinumumScalarProduct
    {
        public static double GetMinimumScalarVector(int[] xVectors, int[] yVectors)
        {
            xVectors = xVectors.OrderBy(x=>x).ToArray();
            yVectors = yVectors.OrderByDescending(y=>y).ToArray();

            double result = 0;
            for (int i = 0; i < xVectors.Length; i++)
            {
                result += xVectors[i]*yVectors[i];
            }

            return result;
        }

    }
}