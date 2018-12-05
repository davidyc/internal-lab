using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_task_2
{
    class Person
    {
        static int countID = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string name, string lastname, int age)
        {
             ++countID;
            Id = countID;
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
