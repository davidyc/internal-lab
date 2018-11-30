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
        protected T[,] matrix;
        protected int rows;
        protected int cols;
        protected event Action Say;     

        public Matrix(int rows, int cols)
        {
            this.cols = cols;
            this.rows = rows;
            matrix = new T[rows, cols];
        }

        public bool ChangeValue(int row, int col, T value)
        {
            if (row >= rows || col >= cols)
            {
                return false;
            }

            matrix[row, col] = value;
            if (Say != null)
            {
                Say();
            }

            return true;    
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

        public T[,] Add (T[,] f, T[,] s)
        {
            T[,] x = new T[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int g = 0; g < 3; g++)
                {
                   // x[i, g] = f[i, g] + f[i,g];
                }
            }

            return x;
        }
      

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            //first.matrix[1, 1] += second.matrix[0, 0];

            return first;
        }
       

        public void Show()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
