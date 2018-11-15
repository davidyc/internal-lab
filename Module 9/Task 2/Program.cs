using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {       
        static void Main(string[] args)
        {

           int[,] arr = BuubleSortcs.InputArray();

           BuubleSortcs.ShowArray(arr);

           BuubleSortcs.SortMinOrMaxElementAscendingOrDescending(arr, (a, b) => a < b,
                                                                      (a, b) => a > b ? a : b);
           BuubleSortcs.ShowArray(arr);
           BuubleSortcs.SortMinOrMaxElementAscendingOrDescending(arr, (a, b) => a > b, 
                                                                      (a, b) => a > b ? a : b);
           BuubleSortcs.ShowArray(arr);


            BuubleSortcs.SortMinOrMaxElementAscendingOrDescending(arr, (a, b) => a < b, 
                                                                       (a, b) => a < b ? a : b);
            BuubleSortcs.ShowArray(arr);
            BuubleSortcs.SortMinOrMaxElementAscendingOrDescending(arr, (a, b) => a > b, 
                                                                       (a, b) => a < b ? a : b);
            BuubleSortcs.ShowArray(arr);


            BuubleSortcs.SortMaxSum(arr, (a, b) => a < b);
            BuubleSortcs.ShowArray(arr);
            BuubleSortcs.SortMaxSum(arr, (a, b) => a > b);
            BuubleSortcs.ShowArray(arr);


            Console.Read();
        }




    }
}
