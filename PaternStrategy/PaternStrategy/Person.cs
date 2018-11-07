using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy
{
    /// <summary>
    /// Class person
    /// </summary>
    public class Person
    {
        string name;
        int age;
        IMove move;

        public Person(string name, int age, IMove move)
        {
            this.name = name;
            this.age = age;
            this.move = move;
        }

        /// <summary>
        /// Change type moving
        /// </summary>
        /// <param name="move"> new moving type</param>
        public void ChengeMoving(IMove move)
        {
            this.move = move;
        }

        /// <summary>
        /// Person moving
        /// </summary>
        public void Move()
        {
            Console.Write("{0} is moving on ", name);
            move.Move();
        }

    }
}
