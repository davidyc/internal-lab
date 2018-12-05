using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module_17_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons repo = new Persons();

            repo.Show();
            Console.WriteLine();

            repo.CreateAsync("Sergey", "Davydov", 27);
            repo.CreateAsync("Sergey", "Davydov", 27);
            repo.CreateAsync("Sergey", "Davydov", 27).Wait();
          
            //Thread.Sleep(1000);
            repo.Show();
            Console.WriteLine();
                                    
            repo.DeleteAsync(1).Wait();
           //Thread.Sleep(1000);
            repo.Show();

            Console.WriteLine();
            repo.ReadAsync(5);
            //Thread.Sleep(1000);
            Console.WriteLine();

            repo.UpdateAsync(5, "SERGEY").Wait();     
            Console.WriteLine();
            repo.Show();



            Console.Read();
        }
    }
}
 