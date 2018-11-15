using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1, 2, 3, 4, 5 };

            var list = arr.ToList();

            Console.WriteLine(BinarySerachClass.GenericSearch(list, 100));


            ABC[] arr1 = { new ABC(1), new ABC(2), new ABC(3), new ABC(4), };


            Console.WriteLine(BinarySerachClass.BinarySearch(arr1, new ABC(111), delegate (ABC x, ABC y)
            {
                if (x.Id > y.Id)
                {
                    return 1;
                }
                else if (x.Id < y.Id)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }));


            Console.ReadKey();
        }        

        public class ABC
        {
            public int Id { get; set; }

            public ABC(int id)
            {
                Id = id;
            }
        }
    }
}
