using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class BuubleSortcs
    {
        public delegate int Switch(int first, int second);        

        /// <summary>
        /// Sort array for sum all element in rows
        /// </summary>
        /// <param name="array">Array for sort</param>
        /// <param name="func">Sort method reference</param>
        public static void SortMaxSum(int[,] array, Func<int, int, bool> func)
        {
            for (int g = 0; g < array.GetLength(0) - 1; g++)
            {
                for (int i = 0; i < array.GetLength(0) - 1 - g; i++)
                {
                    int sumTop = 0;
                    int sumBotton = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sumTop += array[i, j];
                        sumBotton += array[i + 1, j];
                    }

                    if (func(sumBotton, sumTop))
                    {
                        SwapRow(array, i);
                    }
                }
            }
        }


        /// <summary>
        /// Sort Min Or MaxElementAscendingOrDescending
        /// </summary>
        /// <param name="array">Array for sort</param>
        /// <param name="func">Ascending Or Descending sort</param>
        /// <param name="del">Min Or Max element</param>
        public static void SortMinOrMaxElementAscendingOrDescending(int[,] array, Func<int, int, bool> func, Func<int,int,int> del)
        {
            for (int g = 0; g < array.GetLength(0) - 1; g++)
            {
                for (int i = 0; i < array.GetLength(0) - 1 - g; i++)
                {
                    int topRowElement = array[i, 0];
                    int bottonRowElement = array[i + 1, 0];

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        topRowElement = del(topRowElement, array[i, j]);
                        bottonRowElement = del(bottonRowElement, array[i + 1, j]);
                    }

                    if (func(topRowElement, bottonRowElement))
                    {
                        SwapRow(array, i);
                    }
                }
            }
        }

        
        //public static void SortMaxElement(int[,] array, Func<int, int, bool> func, Func<int,int,int> del)
        //{
        //    for (int g = 0; g < array.GetLength(0) - 1; g++)
        //    {
        //        for (int i = 0; i < array.GetLength(0) - 1 - g; i++)
        //        {
        //            int maxTop = array[i, 0];
        //            int maxBotton = array[i + 1, 0];

        //            for (int j = 0; j < array.GetLength(1); j++)
        //            {
        //                maxTop = del(maxTop, array[i, j]);
        //                maxBotton = del(maxTop, array[i + 1, j]);
        //            }

        //            if (func(maxBotton, maxTop))
        //            {
        //                SwapRow(array, i);
        //            }
        //        }
        //    }
        //}


        /// <summary>
        /// swap row in matrix
        /// </summary>
        /// <param name="array">array for swap row</param>
        /// <param name="index">first row index</param>
       public static void SwapRow(int[,] array, int index)
        {
            int[] row1 = new int[array.GetLength(1)];

            for (int i = 0; i < row1.Length; i++)
            {
                row1[i] = array[index, i];
                array[index, i] = array[index + 1, i];
            }

            for (int i = 0; i < row1.Length; i++)
            {
                array[index + 1, i] = row1[i];
            }
        }

        /// <summary>
        /// Input Numbers
        /// </summary>
        /// <param name="name">Name inputs</param>
        /// <returns>Numbers</returns>
        private static int InputNumbers(string name)
        {
            int numbers;

            Console.Write("Input " + name + " > ");
            int.TryParse(Console.ReadLine(), out numbers);

            return numbers;
        }

        /// <summary>
        /// Input Martix
        /// </summary>
        /// <returns>Matrix</returns>
        public static int[,] InputArray()
        {
            int rows;
            int cols;

            do
            {
                rows = InputNumbers("numbers of row");
                cols = InputNumbers("numbers of Coloms");

                if (cols > 0 && rows > 0)
                {
                    break;
                }

                Console.WriteLine("Invalid matrix size entry");
            } while (true);


            int[,] arr = new int[rows, cols];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = InputNumbers(" row = " + i + " cols = " + cols);
                }
            }

            return arr;
        }

        /// <summary>
        /// Input Matrix 
        /// </summary>
        /// <param name="rows">rows </param>
        /// <param name="cols">cols </param>
        /// <returns></returns>
        public static int[,] InputArray(int rows, int cols)
        {
            int[,] arr = new int[rows, cols];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = InputNumbers(" row = " + i + " cols = " + j);
                }
            }

            return arr;
        }

        /// <summary>
        /// Show array in Console
        /// </summary>
        /// <param name="array"></param>
        public static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
