using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy
{

    public class Car : IMove
    {
        /// <summary>
        /// moving by car
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Car");
        }
    }
}
