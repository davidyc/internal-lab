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

        /// <summary>
        /// Create new person
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lname">last name</param>
        /// <param name="age">age</param>
        public void Create(string name, string lname, int age)
        {
             persons.Add(new Person(name, lname, age));
           // Console.WriteLine("create: " + Thread.CurrentThread.ManagedThreadId);
        }

        /// <summary>
        /// Create person asyns
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="lname">last anme</param>
        /// <param name="age">age</param>
        /// <returns></returns>
        public async Task CreateAsync(string name, string lname, int age)
        {
            await Task.Run(() => Create(name, lname, age));
        }

        /// <summary>
        /// read for id 
        /// </summary>
        /// <param name="id">id</param>
        public void Read(int id)
        {
            Person tmp = persons.FirstOrDefault(x => x.Id == id);
            if(tmp != null)
                Console.WriteLine(tmp.Name + "   " + tmp.LastName + "   " + tmp.Age);    
        }

        /// <summary>
        /// read for id async 
        /// </summary>
        /// <param name="id">id</param>
        public async Task ReadAsync(int id)
        {
            await Task.Run(() => Read(id));
        }

        /// <summary>
        /// Update name 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">new name</param>
        public void Update(int id, string name = null)
        {
            persons.FirstOrDefault(x => x.Id == id).Name = name;         
        }

        /// <summary>
        /// Update name async
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">new name</param> 
        public async Task UpdateAsync(int id, string name)
        {
            await Task.Run(() => Update(id, name));
        }

        /// <summary>
        /// Deleye person
        /// </summary>
        /// <param name="id">id person</param>
        public void Delete(int id)
        {
           persons.Remove(persons.FirstOrDefault(x=>x.Id == id));
         //  Console.WriteLine("delete: " + Thread.CurrentThread.ManagedThreadId);
        }

        /// <summary>
        /// delete person async
        /// </summary>
        /// <param name="id">ID person</param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            await Task.Run(() => Delete(id));
        }

         /// <summary>
        /// Show all in array person
        /// </summary>
        public void Show()
        {
            foreach (var item in persons)
            {
                Console.WriteLine("{0}  {1}  {2} ", item.Name, item.LastName, item.Age);
            }
        }

    }
}
