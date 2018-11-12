using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string test = "a clash of KINGS";

            Console.WriteLine(ConvertToTitleSentence(test));

            Console.ReadKey();            
        }


        public static string ConvertToTitleSentence(string sentence, string exception = "")
        {
            string tmp = "";
            string exp = "";

            tmp = sentence.ToLower();
            exp = exception.ToLower();

            tmp = "";

            string[] xx = tmp.Split(' ');
            string[] arrayExp = exception.Split(' ');



            for (int i = 0; i < xx.Length; i++)
            {
                for (int j = 0; j < arrayExp.Length; j++)
                {
                    if(arrayExp[i].ToLower() == xx[j].ToLower())
                    {
                        tmp += xx[i] + " ";
                    }
                    else
                    {
                        tmp += xx[i].First().ToString().ToUpper() + xx[i].Substring(1) + " ";
                    }
                   
                }
               
            }
           

            return tmp;
        }

    }
}
