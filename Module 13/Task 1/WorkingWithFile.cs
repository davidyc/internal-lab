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


        /// <summary>
        /// Сopies the file using StreamReader for Write and Memory for buffer
        /// </summary>
        /// <param name="path">target file</param>
        /// <param name="newFilePath">new file path</param>
        /// <returns>Count copied bites</returns>
        public static ulong CopyFileWithUsingMemoryStreamWithStreamReader(string path, string newFilePath)
        {
            ulong countBites = 0;
            byte[] bytes;
            try
            {
                MemoryStream mS = new MemoryStream();
                
                using (StreamReader fileForRead = new StreamReader(path))
                {
                    string line = null;
                    StringBuilder tmp = new StringBuilder();

                    while ((line = fileForRead.ReadLine()) != null)
                    {
                        tmp.Append(line + "\n ");
                    }

                    bytes = Encoding.ASCII.GetBytes(tmp.ToString());
                    mS.Write(bytes, 0, tmp.Length);
                }

                 using (FileStream file = File.Create(newFilePath))
                 {
                    mS.Write(bytes, 0, (int)mS.Length);
                    file.Write(bytes, 0, bytes.Length);

                    countBites = (ulong)bytes.Length;
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


        /// <summary>
        /// Сopies the file using buufrredStream
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newFilePath"></param>
        /// <returns></returns>
        public static ulong CopyFileWithUsingBufferedStream(string path, string newFilePath)
        {
            ulong countBites = 0;

            try
            {
                Stream inputStream = File.OpenRead(path);
                Stream outputStream = File.OpenWrite(newFilePath);
                BufferedStream bufferedInput = new BufferedStream(inputStream);
                BufferedStream bufferedOutput = new BufferedStream(outputStream);
                byte[] buffer = new Byte[bufferedInput.Length];
                int bytesRead;

                while ((bytesRead =
                bufferedInput.Read(buffer, 0, (int)bufferedInput.Length)) > 0)
                {
                    bufferedOutput.Write(buffer, 0, bytesRead);
                }

                countBites = (ulong)bufferedInput.Length;

                bufferedOutput.Flush();
                bufferedInput.Close();
                bufferedOutput.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            Console.WriteLine("Copy completed");
            return countBites;
        }

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
