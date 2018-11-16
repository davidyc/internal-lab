using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {            
           Console.WriteLine("Hello World!");

            var x = WordRepetitionRate(StringFromFile("text.txt"));

            foreach (var item in x)
            {
                Console.WriteLine("Word = {0} \nCount = {1}\n", item.Key, item.Value);
            }

            Console.ReadKey();
        }


        /// <summary>
        /// measures the frequency of words in a sentence
        /// </summary>
        /// <param name="text">Text foe work</param>
        /// <returns></returns>
        public static Dictionary<string, int> WordRepetitionRate(string text)
        {
            Dictionary<string, int> rate = new Dictionary<string, int>();

            string[] arrayWords = text.ToLower().Split(' ', ',', '.', '!', '?', '-','\'');

            for (int i = 0; i < arrayWords.Length; i++)
            {
                var tmp = rate.FirstOrDefault(x => x.Key.ToLower() == arrayWords[i]);

                if (tmp.Key == null)
                {
                    rate.Add(arrayWords[i], 1);
                }
                else
                {
                    rate[arrayWords[i]]++;
                }
            }           

            return rate;
        }


        /// <summary>
        /// Read file 
        /// </summary>
        /// <param name="path">path for file</param>
        /// <returns>string</returns>
        public static string StringFromFile(string path)
        {
            string textFromFile;
            try
            {
                using (FileStream streamFile = File.OpenRead(path))
                {
                    byte[] byteText = new byte[streamFile.Length];

                    streamFile.Read(byteText, 0, byteText.Length);

                    textFromFile = Encoding.Default.GetString(byteText);
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return textFromFile;
        }



    }
}
