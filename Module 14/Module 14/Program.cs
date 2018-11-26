using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book tmp = new Book
            //{
            //    Title = "Fight club",
            //    Year = 1998,
            //    Author = "C. Palanic",
            //    Edition = "Piter",
            //    Price = 1000,
            //    Pages = 300
            //};

            Student std = new Student();
            //{
            //    Name = "Studnet",
            //    Address = "Adreass fedgfd",
            //    Faculty = "IT",
            //    Group = "IT - 1",
            //    Course = "1"
            //};

            // tmp.WriteTOXml("Books.xml");
            // std.WriteTOXml("Students.xml");

           //XElement el = std.ReadFromXml("Books.xml");

           // foreach (XElement item in el.Elements("book"))
           // {
           //    if(item.Element("year").Value == "1998")
           //     {
           //         Console.WriteLine(item.Element("author").Value);
           //     }
           // }


         Console.Read();
        }
    }
}
