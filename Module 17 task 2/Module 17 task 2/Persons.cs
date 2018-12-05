using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module_17_task_2
{
    class Persons
    {
        List<Person> persons = new List<Person>();

        public Persons()
        {
            persons.Add(new Person("Name1", "LName1", 12));
            persons.Add(new Person("Name0", "LName9", 54));
            persons.Add(new Person("Name4", "LName8", 112));
            persons.Add(new Person("Name2", "LName3", 89)); 
        }


        public void Create(string name, string lname, int age)
        {
             persons.Add(new Person(name, lname, age));
            Console.WriteLine("create: " + Thread.CurrentThread.ManagedThreadId);
        }

        public async Task CreateAsync(string name, string lname, int age)
        {
            await Task.Run(() => Create(name, lname, age));
        }

        public void Delete(int id)
        {
           persons.Remove(persons.FirstOrDefault(x=>x.Id == id));
           Console.WriteLine("delete: " + Thread.CurrentThread.ManagedThreadId);
        }

        public async Task DeleteAsync(int id)
        {
            await Task.Run(() => Delete(id));
        }




        public void Show()
        {
            foreach (var item in persons)
            {
                Console.WriteLine("{0}  {1}  {2} ", item.Name, item.LastName, item.Age);
            }
        }

    }
}
