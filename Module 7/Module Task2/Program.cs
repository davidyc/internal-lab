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
            Console.WriteLine(TitleSenten.ConvertToTitleSentence("a clash of KINGS", "a an the of"));
            Console.WriteLine(TitleSenten.ConvertToTitleSentence("THE WIND IN THE WILLOWS", "in The"));
            Console.WriteLine(TitleSenten.ConvertToTitleSentence("the quick brown fox"));

            Console.ReadKey();
        }       
    }
    
}
