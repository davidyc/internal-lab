using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAll
{
    class Program
    {
        static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        static int[] numbers2 = { 1, 4, 1, 3, 61, 3, 60, 87, 2, 2 };

        static string[] words = { "Hello", "Hi", "Hell", "Stan", "Spoon", "Sky", "Foot" };

        static void Main(string[] args)
        {
            //Where();
            //Select();
            //SelectMany();
            //OrderBy();
            //GroupBy();
            //ElementAt();
            //Disting_Uinon_Intersect_Except();
            //Any_All();
            ConCat();


            Console.Read();
        }     

        /// <summary>
        /// Show array in console 
        /// </summary>
        /// <param name="array"> Array </param>
        /// <param name="head">Head array</param>
        static void ShowArray(IEnumerable<int> array, string head)
        {
            Console.WriteLine(head);
            foreach (var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
   
        static void Where()
        {
            ShowArray(numbers, "Original array");           

            var ResNums =
                from n in numbers
                where n < 5
                where n > 1
                select n;

            ShowArray(ResNums, "1 < Numbers < 5 :");
            var ResNums2 = numbers.Where(x => x < 5 && x > 1);
            ShowArray(ResNums2, "1 < Numbers < 5 :");
            ShowArray(numbers, "Original array");
        }

        static void Select()
        {
            ShowArray(numbers, "Original array");
            var res = numbers.Select(x => x * 10);
            ShowArray(res, "Original array where every element * 10");
            ShowArray(numbers, "Original array");
        }

        static void SelectMany()
        {
            ShowArray(numbers, "Original array");
            int[] array2 = { 1, 3, 4, 5, 6, 7, 0 };

            var res =
                 from a in numbers
                 from b in array2
                 where a < b
                 select new { a, b };


            foreach (var item in res)
            {
                Console.WriteLine(item.a + " < " + item.b);
            }

            ShowArray(numbers, "Original array");
        }

        static void OrderBy()
        {
            ShowArray(numbers, "Original array");
            var ResNums = numbers.OrderBy(x=>x);
            ShowArray(ResNums, "Order by value");

            ResNums = numbers.OrderByDescending(x => x);
            ShowArray(ResNums, "Order by value");

            ShowArray(numbers, "Original array");
        }

        static void GroupBy()
        {
            var res = words.GroupBy((x => x[0]));

            foreach (var item in res)
            {
                foreach (var word in item)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
        }

        static void Disting_Uinon_Intersect_Except()
        {
            ShowArray(numbers2, "Original array");
            var  res = numbers2.Distinct();
            ShowArray(res, "Array after dis");

            ShowArray(numbers, "Original array1");
            ShowArray(numbers2, "Original array2");

            res = numbers2.Union(numbers).OrderBy(x=>x); // обьеденяет без повторво
            ShowArray(res, "Array after Union");

            res = numbers.Intersect(numbers2);
            ShowArray(res, "after Intersected"); // возращает только те элементы в котрых есть совпадение по боим массивасм

            res = numbers.Except(numbers2);
            ShowArray(res, "after Except"); //только те элементы которых нет в другой последовательность

        }

        static void ElementAt()
        {
            ShowArray(numbers, "Original array");

            var resulr = numbers.Where(x=>x>3).ElementAt(2);
            Console.WriteLine("Second element in arrray > 3 = " + resulr);
        }

        static void Any_All()
        {
            ShowArray(numbers, "Original array");

            bool resulr = numbers.Any(x=>x == 3);
            Console.WriteLine("If array has 3 return true. Answer = " + resulr);
            resulr = numbers.Any(x => x == 100);
            Console.WriteLine("If array has 100 return true. Answer = " + resulr);

            resulr = numbers.All(x => x < 10);
            Console.WriteLine("If all elements array < 10 return true. Answer = " + resulr);
            resulr = numbers.All(x => x > 100);
            Console.WriteLine("If all elements array > 100 return true. Answer = " + resulr);
        }

        static void ConCat()
        {
            ShowArray(numbers, "Original array1");
            ShowArray(numbers2, "Original array2");

            var res = numbers.Concat(numbers2).OrderBy(x=>x);

            ShowArray(res, "arraay1 + array2 with order");  //соединяет 2 массива

        }



    }
}
