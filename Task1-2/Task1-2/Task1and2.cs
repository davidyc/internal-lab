using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    public class Task1and2
    {
        /// <summary>
        /// Search for the maximum number
        /// </summary>
        /// <param name="arr">int Array</param>
        /// <param name="max">Current max</param>
        /// <param name="i">item number to compare</param>
        /// <returns>Max from array</returns>
        public static int MaxInArray(int[] arr, int max, int i = 0)
        {
            if (i >= arr.Length)
                return max;
            return MaxInArray(arr, arr[i] > max ? arr[i] : max, i + 1);
        }

        /// <summary>
        /// Search index of the element for which the sum of the elements on the left and the sum of the elements of the parameter are equal.
        /// </summary>
        /// <param name="array">Double array</param>
        /// <returns>Number Index</returns>
        public static double IndexEquelsLeftRigth(double[] array)
        {
            double leftSum = 0;
            double rigthSum = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                leftSum = 0;
                rigthSum = 0;

                leftSum = array.Take(i).Sum();

                rigthSum = array.Skip(i).Sum();             

                if (Math.Abs(rigthSum - leftSum) == 0)
                {
                    return i;
                }
            }

            return -1;
        }
              
    }
}
