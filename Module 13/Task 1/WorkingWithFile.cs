using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class WorkingWithFile
    {

        // task 1
        /// <summary>
        /// Сopies the file using filestream
        /// </summary>
        /// <param name="path">target file</param>
        /// <param name="newFilePath">new file path</param>
        /// <returns>Count copied bites</returns>
        public static ulong CopyFileWithUsingFileStream(string path, string newFilePath)
        {
            ulong countBites = 0;
            byte[] array;

            try
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    array = new byte[fstream.Length];

                    fstream.Read(array, 0, array.Length);

                    string textFromFile = System.Text.Encoding.Default.GetString(array);

                }

                using (FileStream fstream = File.Create(newFilePath))
                {
                    fstream.Write(array, 0, array.Length);
                    countBites = (ulong)array.Length;
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            Console.WriteLine("Copy completed");
            return countBites;
        }



        /// <summary>
        /// Сopies the file using BufferStream
        /// </summary>
        /// <param name="path">target file</param>
        /// <param name="newFilePath">new file path</param>
        /// <returns>Count copied bites</returns>
        public static ulong CopyFileWithUsingBufferStream(string path, string newFilePath)
        {
            ulong countBites = 0;
            byte[] bytes;

            try
            {





            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }


            Console.WriteLine("Copy Completed");
            return countBites;
        }






        // task 5
        /// <summary>
        /// Сopies the file using MemoryStream
        /// </summary>
        /// <param name="path">target file</param>
        /// <param name="newFilePath">new file path</param>
        /// <returns>Count copied bites</returns>
        public static ulong CopyFileWithUsingMemoryStream(string path, string newFilePath)
        {
            ulong countBites = 0;
            byte[] bytes;

            try
            {
                //read
                using (MemoryStream ms = new MemoryStream())
                {
                    using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        bytes = new byte[file.Length];
                        file.Read(bytes, 0, (int)file.Length);
                        ms.Write(bytes, 0, (int)file.Length);
                    }

                    //write             
                    using (FileStream file = new FileStream(newFilePath, FileMode.Create, FileAccess.Write))
                    {
                        ms.Read(bytes, 0, (int)ms.Length);
                        file.Write(bytes, 0, bytes.Length);
                        countBites = (ulong)bytes.Length;                      
                    }
                }                     
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
          

            Console.WriteLine("Copy Completed");
            return countBites;
        }

       

        





    }
}
