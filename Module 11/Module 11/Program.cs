using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //first data for write in file
            //StudentTestInformation[] tests =
            //{
            //    new StudentTestInformation("Student 1", "Test 1", 100, DateTime.Now),
            //    new StudentTestInformation("Student 2", "Test 1", 58, DateTime.Now),
            //    new StudentTestInformation("Student 3", "Test 1", 72, DateTime.Now),
            //    new StudentTestInformation("Student 1", "Test 2", 97, DateTime.Now),
            //    new StudentTestInformation("Student 2", "Test 2", 59, DateTime.Now),
            //    new StudentTestInformation("Student 3", "Test 2", 70, DateTime.Now),
            //    new StudentTestInformation("Student 1", "Test 3", 63, DateTime.Now),
            //    new StudentTestInformation("Student 2", "Test 3", 57, DateTime.Now),
            //    new StudentTestInformation("Student 3", "Test 3", 71, DateTime.Now)
            //};
            //WriteInBonaryFile(@"file.dat", tests);


            var tests = ReadFromBinaryFile(@"file.dat");         

            BinarySearchTree<StudentTestInformation> binarySearchTree = new BinarySearchTree<StudentTestInformation>();

            for (int i = 0; i < tests.Length; i++)
            {
                binarySearchTree.Insert(tests[i]);
            }

                        
            Console.ReadLine();
        }

        /// <summary>
        /// Write information in binary file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="array"></param>
        static void WriteInBonaryFile(string path, StudentTestInformation[] array)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {

                    foreach (var item in array)
                    {
                        writer.Write(item.Name);
                        writer.Write(item.TestName);
                        writer.Write(item.Score);
                        writer.Write(item.TestDate.ToString());
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        /// <summary>
        /// Read from file
        /// </summary>
        /// <param name="path">path</param>
        /// <returns>Arrray with data</returns>
        static StudentTestInformation[] ReadFromBinaryFile(string path)
        {
            List<StudentTestInformation> tmp = new List<StudentTestInformation>();

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        string testname = reader.ReadString();
                        int score = reader.ReadInt32();
                        string datestring = reader.ReadString();

                        DateTime Date = DateTime.Parse(datestring);

                        tmp.Add(new StudentTestInformation(name, testname, score, Date));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
                return tmp.ToArray();
            
        }


    }
}
