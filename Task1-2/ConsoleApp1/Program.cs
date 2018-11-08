using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 4, 0, 2, 3 };

            Console.WriteLine(Task1and2.IndexEquelsLeftRigth(arr));
        
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
