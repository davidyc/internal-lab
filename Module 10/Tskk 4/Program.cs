using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tskk_4
{
    class Program
    {
        static void Main(string[] args)
        {      
            MyQueue<int> x = new MyQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                x.Enqueue(i);
            }

            Console.WriteLine(x.Peek());
            Console.WriteLine(x.Count);

            x.Dequeue();          

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
       

            Console.WriteLine(x.Peek());
            Console.WriteLine(x.Count);
         


            Console.ReadKey();
        }
    }
}
