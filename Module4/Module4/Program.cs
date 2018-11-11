using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class test
    {


    }


    class Program
    {
        static void Main(string[] args)
        {
            int? testa = 100;
            int? testb = null;
            string text = null;
            string text2 = "Привет";
            test tmp = null;
            test tmp2 = new test();

            Console.WriteLine(testa.IsNull());
            Console.WriteLine(testb.IsNull());
            Console.WriteLine(text.IsNull());
            Console.WriteLine(text2.IsNull());
            Console.WriteLine(tmp.IsNull());
            Console.WriteLine(tmp2.IsNull());


            Console.WriteLine(Task2.GCD(24, 100));
            Console.WriteLine(Task2.GCD(9, 15, 6, 27));

            Console.WriteLine(Task2.BinaryGCD(24, 100));
            Console.WriteLine(Task2.BinaryGCD(9, 15, 6, 27));

            Task2.TimeMethodEuclidean(24,100);
            Task2.TimeMethodStein(24, 100);

            Console.Read();
        }
    }
}