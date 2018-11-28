using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serilization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
      
        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {           
            Person person = new Person("Tom", 29);
            Console.WriteLine("Object cretad");

          
            XmlSerializer formatter = new XmlSerializer(typeof(Person));


            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Object serial");
            }

        
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine("Object deserial");
                Console.WriteLine("Name: {0} --- Age: {1}", newPerson.Name, newPerson.Age);
            }

            Console.ReadLine();
        }
    }
}
