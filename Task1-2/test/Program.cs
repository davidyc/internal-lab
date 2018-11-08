using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 3, 4, 2, 2, 1 };

            Console.WriteLine(Task1_2.Task1and2.MaxInArray(nums, nums[0]));
        }
    }
}
