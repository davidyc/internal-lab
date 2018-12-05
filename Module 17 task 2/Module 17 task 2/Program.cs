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
            repo.CreateAsync("Sergey", "Davydov", 27);

            //Thread.Sleep(1000);
            repo.Show();

            HttpClient aa = new HttpClient();

            
            repo.DeleteAsync(1).Wait();
          //Thread.Sleep(1000);
            repo.Show();

            Console.Read();
        }
    }
}
 