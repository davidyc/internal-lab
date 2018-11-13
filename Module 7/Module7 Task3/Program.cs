using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Task3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Hello World!");

            Console.WriteLine(URLString.AddOrChangeUrlParameter("www.example.com", "key = value"));
            Console.WriteLine(URLString.AddOrChangeUrlParameter("www.example.com?key=value", "key2 = value2"));
            Console.WriteLine(URLString.AddOrChangeUrlParameter("www.example.com?key = oldValue", "key = newValue"));

            Console.ReadKey();
        }
    }
}
