using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_16
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagonalMatrix<int> x = new DiagonalMatrix<int>(2, 2);
            x.matrix[0, 0] = 1;
            x.matrix[0, 1] = 0;
            x.matrix[1, 0] = 0;
            x.matrix[1, 1] = 1;

           
            
            Console.WriteLine(x.IsDiagonalMatrix());
         
            Console.Read();
        }
    }
}
