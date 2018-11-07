using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Sergey", 18, new Car());
            person.Move();
            person.ChengeMoving(new Train());
            person.Move();


            Console.ReadKey();
        }
    }
}
