using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Hello World!");

            Countdown cd = new Countdown(5);
            Person person = new Person("Sergey", 18, cd);
            Person person2 = new Person("Kirill", 100, cd);
            Licenzi licence = new Licenzi(5, cd);


            person.SubOnEvent();
            person2.SubOnEvent();
            licence.SubOnEvent();           

            cd.EventTime();

            Console.Read();
        }
    }
}
