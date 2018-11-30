using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        
            int number = 4;
            // создаем новый поток
            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(number);

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }

        public static void Count(object x)
        {
            for (int i = 1; i < 9; i++)
            {
                int n = (int)x;

                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * n);
                Thread.Sleep(400);
            }
        }
    }