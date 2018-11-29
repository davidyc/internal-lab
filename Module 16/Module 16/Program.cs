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
         

            x.Show();
            x.ChangeValue(0, 0, 10);
            x.Show();

        
            
            Console.WriteLine(x.IsDiagonalMatrix());
         
            Console.Read();
        }
    }
}
