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
            //CreateRandomBook(10);
            //CreateRandomStudent(10);  
            //CreateBookStudentRandom(50);

            XElement el = new BookAndStudent().ReadFromXml("BooksAndStudents.xml");
            List<BookAndStudent> tmp = BookAndStudent.ConvertXelementToListBookStudent(el);
            BookAndStudent del = tmp.FirstOrDefault(x => x.Student.Name == "Studnet");
            tmp.Remove(del);

            BookAndStudent.WriteListBookStudent(tmp, "BooksAndStudents.xml");     

            Console.Read();
        }

        /// <summary>
        /// Creaete random data
        /// </summary>
        /// <param name="countOfBook">count creating book</param>
        static void CreateRandomBook(int countOfBook)
        {
            Random rnd = new Random();
            for (int i = 0; i < countOfBook; i++)
            {
                Book tmp = new Book()
                {
                    Title = "Book" + rnd.Next(0, 100),
                    Year = rnd.Next(1990, 2018),
                    Author = "Autohr " + rnd.Next(0, 100),
                    Edition = "Piter",
                    Price = rnd.Next(1, 25)*1000,
                    Pages = rnd.Next(250, 900)
                };

                tmp.WriteTOXml("Books.xml");
            }
          
        }

        /// <summary>
        /// Creaete random data
        /// </summary>
        /// <param name="countOfStudent">Count creating student</param>
        static void CreateRandomStudent(int countOfStudent)
        {
            Random rnd = new Random();
            for (int i = 0; i < countOfStudent; i++)
            {
                Student std = new Student()
                {
                    Name = "Studnet " + rnd.Next(0, 100),
                    Address = "Adreass room #" + rnd.Next(0, 500),
                    Faculty = "IT",
                    Group = "IT - " + rnd.Next(1, 5),
                    Course = rnd.Next(1, 5).ToString()
                };

                std.WriteTOXml("Students.xml");
            }

        }

        static void CreateBookStudentRandom(int countOfBS)
        {
            XElement rootStudent = new Student().ReadFromXml("Students.xml");
            XElement rootBook = new Book().ReadFromXml("Books.xml");

            List<Book> books = Book.ConvertXelementToListBooks(rootBook);
            List<Student> students = Student.ConvertXelementToListStudent(rootStudent);

            List<BookAndStudent> BS = new List<BookAndStudent>();

            Random rmd = new Random();
            for (int i = 0; i < countOfBS; i++)
            {
                Book tmpBook = books[rmd.Next(0, 10)];
                Student tmpStd = students[rmd.Next(0, 10)];
                BookAndStudent tmp = BookAndStudent.CreateNote(tmpBook, tmpStd);
                BS.Add(tmp);
            }

            for (int i = 0; i < BS.Count; i++)
            {
                BS[i].WriteTOXml("BooksAndStudents.xml");
            }

        }



    }
}
