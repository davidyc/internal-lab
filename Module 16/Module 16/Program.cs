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
            DiagonalMatrix<int> x2 = new DiagonalMatrix<int>(2, 2);


            x.Show();
            x.ChangeValue(1, 1, 10);
            x2.ChangeValue(1, 1, 10);

            x2 = (DiagonalMatrix<int>)x.Add(x2, (z, y) => z+y);

            x2.Show();
            

        
            
           
         
            Console.Read();
        }
    }
}
