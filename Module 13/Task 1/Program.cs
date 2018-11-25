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
            Console.WriteLine(WorkingWithFile.CopyFileWithUsingFileStream("test.txt", "CopyFileWithUsingFileStream.txt"));
            Console.WriteLine(WorkingWithFile.CopyFileWithUsingBufferedStream("test.txt", "CopyFileWithUsingBufferedStream.txt"));
            Console.WriteLine(WorkingWithFile.CopyFileWithUsingMemoryStream("test.txt", "CopyFileWithUsingMemoryStream.txt"));
            Console.WriteLine(WorkingWithFile.CopyFileWithUsingMemoryStreamWithStreamReader("test.txt", "CopyFileWithUsingMemoryStreamWithStreamReader.txt"));
            Console.WriteLine(WorkingWithFile.CopyOnRolls("test.txt", "CopyOnRolls.txt"));

            Console.Read();
        }
    }
}
