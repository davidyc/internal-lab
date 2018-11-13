using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Input numbers ->");
                string x = Console.ReadLine();
                int q;
                ConvertToInt.MyParseToInt(x, out q);
                Console.WriteLine(q);
            }
            Console.WriteLine("Press any Keys");
            Console.ReadKey();          
        }
    }
}
