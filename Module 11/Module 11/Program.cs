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
           
            StudentTestInformation[] tests =
            {
                new StudentTestInformation("C", "Test 1", 69, DateTime.Now),
                new StudentTestInformation("E", "Test 1", 58, DateTime.Now),
                new StudentTestInformation("F", "Test 1", 72, DateTime.Now),
                new StudentTestInformation("Z", "Test 2", 97, DateTime.Now),
                new StudentTestInformation("A", "Test 2", 59, DateTime.Now),
                new StudentTestInformation("B", "Test 2", 70, DateTime.Now),
                new StudentTestInformation("X", "Test 3", 63, DateTime.Now),
                new StudentTestInformation("Y", "Test 3", 57, DateTime.Now),
                new StudentTestInformation("Q", "Test 3", 71, DateTime.Now)
            };                  

            BinarySearchTree<StudentTestInformation> binarySearchTree = new BinarySearchTree<StudentTestInformation>();

            binarySearchTree.InsertArray(tests);

            var BinarytreeAfterWhere = binarySearchTree.WhereForBinaryTree(x => x.Score > 60);

            //var BinarytreeAfterOrderBy = binarySearchTree.OberByForBinaryTree(x => x.Name);

            //var BinarytreeAfterOrderByDes = binarySearchTree.OberByDescendingForBinaryTree(x => x.Name);

            foreach (var item in BinarytreeAfterWhere)
            {
                Console.WriteLine(item.ToString());
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
