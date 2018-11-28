using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Module_15
{
    class Program
    {
        static void Main(string[] args)
        {         
            Book[] catolog =
            {
            new Book
            {
                Id = "1",
                Author = "Author",
                Title = "Title",
                Genre = Genre.Computer,
                Publisher = "Publish",
                Description = "Desc",
                PublishDate = DateTime.Today,
                RegistrationDate = DateTime.Today
            },
            new Book
            {
                Id = "2",
                Author = "Author2",
                Title = "Title2",
                Genre = Genre.Fantasy,
                Publisher = "Publish2",
                Description = "Desc2",
                PublishDate = DateTime.Today,
                RegistrationDate = DateTime.Today
            },
            };

            Catalog catalog = new Catalog
            {
                Date = DateTime.Today,
                Books = catolog.ToList()
            };

            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));

           
            using (FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, catalog);

                Console.WriteLine("Serial");
            }

            // десериализация
            using (FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate))
            {
                Catalog catalogg = (Catalog)formatter.Deserialize(fs);

                Console.WriteLine("Desear");

                foreach (var book in catalogg.Books)
                {
                    Console.WriteLine(book.Id + "  " + book.Author + "  " + book.Title + "  " + book.Genre + "  " + book.Publisher + "  "
                   + book.Description + "  " + book.PublishDate + "  " + book.RegistrationDate);
                }

                
               
            }



            Console.Read();


        }


    
        
    }
}
