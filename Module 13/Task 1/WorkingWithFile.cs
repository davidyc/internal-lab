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


        public static ulong CopyFileWithUsingMemoryStreamWithStreamReader(string path, string newFilePath)
        {
            ulong countBites = 0;    

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (StreamReader file = new StreamReader(path))
                    {
                        string tmp = file.ReadToEnd();
                        byte[] array = new byte[tmp.Length];
                        for (int i = 0; i < tmp.Length; i++)
                        {
                            array[i] = Convert.ToByte(tmp[i]);
                        }                       
                        ms.Write(array, 0, array.Length);
                    }    
           
                    using (StreamWriter file = new StreamWriter(newFilePath))
                    {
                        byte[] array = new byte[ms.Length];
                        ms.Read(array, 0, (int)ms.Length);
                        string tmp = ""; 

                        for (int i = 0; i < array.Length; i++)
                        {
                            tmp += array[i].ToString();
                        }

                                                  

                        file.Write(tmp, 0, array.Length);
                        countBites = (ulong)array.Length;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            Console.WriteLine("Copy completed");
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
        // task 6
        /// <summary>
        /// Сopies on rols
        /// </summary>
        /// <param name="path">target file</param>
        /// <param name="newFilePath">new file path</param>
        /// <returns>Count copied bites</returns>
        public static int CopyOnRolls(string path, string newFilePath)
        {
            int countRolls = 0;
            List<string> ListString = new List<string>();

            try
            {
                using (StreamReader file = new StreamReader(path, Encoding.Default))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        ListString.Add(line);
                    }
                }

                using (StreamWriter file = new StreamWriter(path))
                {

                    using (StreamWriter sw = new StreamWriter(newFilePath))
                    {
                        for (int i = 0; i < ListString.Count; i++)
                        {
                            sw.WriteLine(ListString[i]);
                        }
                        countRolls = ListString.Count;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            Console.WriteLine("Copy completed");
            return countRolls;
        }
        //task 7
        /// <summary>
        /// Equesl 2 files
        /// </summary>
        /// <param name="path">target file</param>
        /// <param name="newFilePath">new file path</param>
        /// <returns>true or false</returns>
        public static bool EquealTwoFile(string path, string newFilePath)
        {            
            byte[] array;
            byte[] arraySecond;

            try
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);    
                }
                using (FileStream fstream = File.OpenRead(newFilePath))
                {
                    arraySecond = new byte[fstream.Length];
                    fstream.Read(arraySecond, 0, arraySecond.Length);
                }

                return array.SequenceEqual<byte>(arraySecond);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }     
        }









    }
}
