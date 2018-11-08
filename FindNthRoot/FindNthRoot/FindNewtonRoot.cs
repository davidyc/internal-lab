using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot
{
    public static class FindNewtonRoot
    {
        /// <summary>
        /// Find Root method newton
        /// </summary>
        /// <param name="number"></param>
        /// <param name="root"></param>
        /// <param name="eps"></param>
        /// <returns></returns>
        public static double NewtonRoot(double number, int root, double eps)
        {
            if ((number <= 0 && root % 2 == 0) || root <= 0)
            {
                return 0;
            }

            if (eps <= 0 || eps >= 1)
            {
                return 0;
            }

            double tmp1 = number / root;
            double tmp2 = 1.0 / root * ((root - 1) * tmp1 + number / Math.Pow(tmp1, root - 1));
            while (Math.Abs(tmp1 - tmp2) > eps)
            {
                tmp1 = tmp2;
                tmp2 = 1.0 / root * ((root - 1) * tmp1 + number / Math.Pow(tmp1, root - 1));
            }
            return tmp2;

        }



    }
}
