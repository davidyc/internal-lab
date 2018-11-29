using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_16
{
    abstract class Matrix<T> : IEqualityComparer where T : struct
    {
        public T[,] matrix;
        protected int rows;
        protected int cols;       
        public event Func<string> Say;

        public Matrix(int rows, int cols)
        {
            this.cols = cols;
            this.rows = rows;
            matrix = new T[rows, cols];
        }
                 
        


        /// <summary>
        /// return trans matrix
        /// </summary>
        /// <returns>trans matrix</returns>
        protected T[,] TransMatrix()
        {
            int tmp = rows;
            rows = cols;
            cols = tmp;

            T[,] tmpMatrix = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tmpMatrix[i, j] = matrix[j, i];
                }
            }
            return tmpMatrix;
        }

        /// <summary>
        /// Equels 2 matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public new bool Equals(object x, object y)
        {
            return x == y;
        }

        /// <summary>
        /// Return HashCode
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }

        

        //public void Show()
        //{
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(matrix[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
