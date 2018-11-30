using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_16
{
    class DiagonalMatrix<T> : Matrix<T>, ISqueare, IDiagonal where T : struct
    {
        public DiagonalMatrix(int rows, int cols) : base(rows, cols)
        {
            Say += () => Console.WriteLine("Value was changed");
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsDiagonalMatrix()
        {
            if (!IsSqueralMatrix())
                return false;
            for (int i = 0; i < rows; i++)
            {
                for (int g = 0; g < cols; g++)
                {
                    if(!matrix[i,g].Equals(0) && i!= g)
                    {
                        return false;
                    }
                }
            }


            return true;
        }

        /// <summary>
        /// if Matrix squer
        /// </summary>
        /// <returns></returns>
        public bool IsSqueralMatrix()
        {
            return rows == cols ? true : false;
        }
    }
}
