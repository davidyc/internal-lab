using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer test = new Customer
            {
                Name = "Sergey",
                Phone = "+7 777 777 77 77",
                Revenue = 10000000
            };

            Console.WriteLine(test.ToString());
            Console.WriteLine(test.RevenueToString());

            Console.ReadKey();           
        }
    }
}
