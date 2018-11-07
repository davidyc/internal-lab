using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy
{
    public class Train : IMove
    {
        /// <summary>
        /// Moving on Train
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Train");
        }
    }
}
