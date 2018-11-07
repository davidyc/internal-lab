using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = { { 5, 4, 3 }, { 3, 1, 0},  { 2, 1, 0} };
            
            ShowArray(matrix);
            
            SortMaxSum(matrix);
            ShowArray(matrix);

            SortInRow(matrix);
            ShowArray(matrix);

            SortAllNumbers(matrix);
            ShowArray(matrix);

            Console.Read();
        }

        /// <summary>
        /// Soring all numbers in matrix 
        /// </summary>
        /// <param name="array"></param>
        static void SortAllNumbers(int[,] array)
        {
            int[] tmp = new int[array.Length];

            int step = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tmp[step] = array[i, j];
                    step++;
                }             
            }

            SwapArray(tmp);

            step = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = tmp[step];
                    step++;
                }
            }

        }



        /// <summary>
        /// Sorting numbers in row
        /// </summary>
        /// <param name="array"></param>
        static void SortInRow(int[,] array)
        {
            for (int g = 0; g < array.GetLength(0); g++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1) - 1; j++)
                    {
                        if (array[i, j] > array[i, j + 1])
                        {
                            int tmp = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = tmp;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// sortering for sum row
        /// </summary>
        /// <param name="array"></param>
        static void SortMaxSum(int[,] array)
        {
            for (int g = 0; g < array.GetLength(0) - 1; g++)
            {
                for (int i = 0; i < array.GetLength(0) - 1; i++)
                {
                    int sumTop = 0;
                    int sumBotton = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sumTop += array[i, j];
                        sumBotton += array[i + 1, j];
                    }

                    if (sumTop > sumBotton)
                    {
                        SwapRow(array, i);
                    }
                }
            }
        }


        /// <summary>
        /// Show array in Console
        /// </summary>
        /// <param name="array"></param>
        static void ShowArray(int[,] array)
        {
            for (int i = 0; i <  array.GetLength(0); i++)
            {
                for (int j = 0; j <array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        /// <summary>
        /// swap row
        /// </summary>
        /// <param name="array">array for swap row</param>
        /// <param name="index">first row index</param>
        static void SwapRow(int[,] array, int index)
        {
            int[] row1 = new int[array.GetLength(1)];

            for (int i = 0; i < row1.Length; i++)
            {
                row1[i] = array[index, i];
                array[index, i] = array[index + 1, i];
            }

            for (int i = 0; i < row1.Length; i++)
            {
                array[index+1, i] = row1[i];
            }
        }

        /// <summary>
        /// Sorting array
        /// </summary>
        /// <param name="array"></param>
        static void SwapArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j+1] = tmp;
                    }
                }
            }         
          
        }





    }


}
