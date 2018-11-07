using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    public class Task1and2
    {
        public static int MaxInArray(int[] arr, int max, int i = 0)
        {
            if (i >= arr.Length)
                return max;
            return MaxInArray(arr, arr[i] > max ? arr[i] : max, i + 1);
        }


        public static double Method2(double[] array)
        {
            double leftSum = 0;
            double rigthSum = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                leftSum = 0;
                rigthSum = 0;

                for (int g = 0; g < i; g++)
                {
                    leftSum += array[g];
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    rigthSum += array[j];
                }

                if (leftSum == rigthSum)
                {
                    return i;
                }

            }

            return -1;
        }
    }
}
