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
            //Console.WriteLine(WorkingWithFile.CopyFileWithUsingFileStream("0.pptx", "1.pptx"));
            Console.WriteLine(WorkingWithFile.CopyFileWithUsingMemoryStream("0.pptx", "1.pptx"));
            Console.Read();
        }
    }
}
