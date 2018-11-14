using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {       
            Shop South = new Shop();
            Seller seller = new Seller(South, "Super Seller");
            Customer One = new Customer(South, "One");
            Customer Two = new Customer(South, "Two");
            Customer Thee = new Customer(South, "Thee");
            Customer Four = new Customer(South, "Four");

            South.OpenDoor();
            Console.WriteLine();
            South.CloseDoor();





            Console.ReadKey();            
        }
    }
}
