using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_16
{
    class SymmetricMatrix<T> : Matrix<T>, ISqueare, ISymmetic<T> where T : struct
    {
        public SymmetricMatrix(int rows, int cols) : base(rows, cols)
        {

        }

        /// <summary>
        /// if Matrix squer
        /// </summary>
        /// <returns></returns>
        public bool IsSqueralMatrix()
        {
            return rows == cols ? true : false;
        }

        /// <summary>
        /// Is SYmmeticMatrix
        /// </summary>
        /// <returns></returns>
        public bool IsSymmeticMatrix()
        {
            T[,] tmp = TransMatrix();

            if (!IsSqueralMatrix())
            {
                return false;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int g = 0; g < cols; g++)
                {
                    if (tmp[i, g].Equals(matrix[i, g]) == false)
                        return false;
                }
            }


            return true;
        }
    }
}

