using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Person : ISubstruct
    {
        string name;
        int age;
        Countdown cd;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;       
        }

        public Person(string name, int age, Countdown countdown): this(name, age)
        {
            this.cd = countdown;
        }

        /// <summary>
        /// Add referense for Countdown
        /// </summary>
        /// <param name="countdown"></param>
        public void AddTimer(Countdown countdown)
        {
            cd = countdown;
        }

        /// <summary>
        /// Get message 
        /// </summary>
        public void Say()
        {
            Console.WriteLine("My name is " + name + " amd now I am " + age+ " years old");
            age++;
        }

        /// <summary>
        /// Substruction on event
        /// </summary>
        /// <param name="act"></param>
        public void SubOnEvent()
        {
            cd.SendMessageAboutEvent += Say;
        }

        /// <summary>
        ///  Отписать от события
        /// </summary>
        /// <param name="act"></param>
        public void DelOnEvent()
        {
            cd.SendMessageAboutEvent -= Say; 
        }

        


    }
}
