using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_16
{
 

    class SquareMatrix<T> : Matrix<T>, ISqueare where T : struct 
    {
      
        public SquareMatrix(int rows, int cols) : base(rows, cols)
        {
            Say += () => Console.WriteLine("Value was changed");
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
