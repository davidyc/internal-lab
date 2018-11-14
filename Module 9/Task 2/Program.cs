using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        public delegate int Switch(int first, int second);
        public delegate bool Compere(int first, int second);


        static void Main(string[] args)
        {

            int[,] arr = InputArray();

            ShowArray(arr);

            SortMaxElement(arr, (a, b) => a < b, (a, b) => a < b ? a : b);
            ShowArray(arr);
            SortMaxElement(arr, (a, b) => a > b, (a, b) => a > b ? a : b);
            ShowArray(arr);


            SortMinElement(arr, (a, b) => a < b, (a, b) => a < b ? a : b);
            ShowArray(arr);
            SortMinElement(arr, (a, b) => a > b, (a, b) => a < b ? a : b);
            ShowArray(arr);


            SortMaxSum(arr, (a, b) => a < b);
            ShowArray(arr);
            SortMaxSum(arr, (a, b) => a > b);
            ShowArray(arr);


            Console.Read();
        }





        /// <summary>
        /// sortering for sum row
        /// </summary>
        /// <param name="array"></param>
        public static void SortMaxSum(int[,] array, Compere comper)
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

                    if (wr(sumBotton, sumTop))
                    {
                        SwapRow(array, i);
                    }
                }
            }
        }



        /// <summary>
        /// sorts by max element
        /// </summary>
        /// <param name="array">array</param>
        public static void SortMinElement(int[,] array, Compere comper, Switch del)
        {
            for (int g = 0; g < array.GetLength(0) - 1; g++)
            {
                for (int i = 0; i < array.GetLength(0) - 1 - g; i++)
                {
                    int minTop = array[i, 0];
                    int minBotton = array[i + 1, 0];

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        minTop = del(minTop, array[i, j]);
                        minBotton = del(minBotton, array[i + 1, j]);
                    }

                    if (comper(minTop, minBotton))
                    {
                        SwapRow(array, i);
                    }
                }
            }
        }

        /// <summary>
        /// sorts by max element
        /// </summary>
        /// <param name="array">Array</param>
        public static void SortMaxElement(int[,] array, Compere comper, Switch del)
        {
            for (int g = 0; g < array.GetLength(0) - 1; g++)
            {
                for (int i = 0; i < array.GetLength(0) - 1 - g; i++)
                {
                    int maxTop = array[i, 0];
                    int maxBotton = array[i + 1, 0];

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        maxTop = del(maxTop, array[i, j]);
                        maxBotton = del(maxTop, array[i+1, j]);                    
                    }

                    if (comper(maxBotton, maxTop))
                    {
                       SwapRow(array, i);
                    }
                }
            }
        }




        /// <summary>
        /// swap row in matrix
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
                cols = InputNumbers("numbers of row");

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
                    arr[i, j] = InputNumbers(" row = " + i + " cols = " + cols);
                }
            }

            return arr;
        }

        /// <summary>
        /// Show array in Console
        /// </summary>
        /// <param name="array"></param>
        private static void ShowArray(int[,] array)
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
