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
        public static bool GenericSearch<T>(List<T> list, T item)
        {
            int min = 0;
            int max = list.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                T midValue = list[mid];

                int res = ((IComparable)(midValue)).CompareTo(item);

                if (res == 0)
                    return true;
                else if (res == -1)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return false;
        }






        public static bool BinarySearch<T>(T[] array, T searchElement, Func<T, T, int> comparer)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                T midValue = array[mid];

                int res = comparer(searchElement, array[mid]);

                if (res == 0)
                    return true;
                else if (res == -1)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return false;
        }
    }
}
