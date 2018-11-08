
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? testa = 100;
            int? testb = null;
            int x = 1;
           

            var num = new Nullable<int>(100);

            Console.WriteLine(testa.IsNull());
            Console.WriteLine(testb.IsNull());



            Console.Read();
        }
    }
}
