using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Task_1
{
    public class BinarySerachClass
    {
        public static int BinarySearch<T>(T[] array, T searchElement, Func<T, T, int> comparer)
        {
            int leFtElement = 0;
            int rightlement = array.Length;
            int mid;

          //  Array.Sort<T>(array);         
           

            while(leFtElement < rightlement)
            {
                mid = leFtElement + (rightlement - leFtElement) / 2;

                if (comparer(searchElement, array[mid]) == 1)
                {
                    leFtElement = mid;
                }
                else if(comparer(searchElement, array[mid]) == -1)
                {
                    rightlement = mid;
                }
                else
                {
                    return mid;
                }               
            }

            return -1;
        }
    }
}
