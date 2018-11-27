using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_14
{
    class BookAndStudent : IWorkingWithXML
    {
        public Book Book { get; set; }
        public Student Student { get; set; }
        public string StartRead { get; set; }
        public string EndRead { get; set; }

        /// <summary>
        /// Create BookAndStudent
        /// </summary>
        /// <param name="book"></param>
        /// <param name="student"></param>
        /// <returns></returns>
        public static BookAndStudent CreateNote(Book book, Student student)
        {
            if(book == null || student == null)
            {
                return null;
            }

            BookAndStudent tmp = new BookAndStudent();
            tmp.Book = book;
            tmp.Student = student;
            tmp.StartRead = DateTime.Now.ToString();
            tmp.EndRead = DateTime.Now.ToString();

            return tmp;
        }

        /// <summary>
        /// Write in XML file
        /// </summary>
        /// <param name="path">path</param>
        public void WriteTOXml(string path)
        {
            XDocument xdoc;
            try
            {
                xdoc = XDocument.Load(path);
            }
            catch (FileNotFoundException e)
            {
                xdoc = new XDocument();
                XElement xElement = new XElement("booksandstudents", "");
                xdoc.Add(xElement);
            }

            XElement newbookandstudent = new XElement("bookandstudent");

            //add student element and attributes
            XElement nameEl = new XElement("name", Student.Name);
            XElement addressEl = new XElement("address", Student.Address);
            XElement faculty = new XElement("faculty", Student.Faculty);
            XAttribute groupAt = new XAttribute("group", Student.Group);
            XAttribute courseAt = new XAttribute("course", Student.Course);
            faculty.Add(groupAt);
            faculty.Add(courseAt);
            //add book element and attributes
            XElement titleEl = new XElement("title", Book.Title);
            XElement authorEl = new XElement("author", Book.Author);
            XElement yearEl = new XElement("year", Book.Year);
            XElement editionEl = new XElement("edition", Book.Year);
            XAttribute priceAt = new XAttribute("price", Book.Price);
            XAttribute pagesAt = new XAttribute("pages", Book.Pages);
            // add data elemebts
            XElement getDAte = new XElement("getdate", StartRead);
            XElement returnDate = new XElement("returndate", EndRead);

            editionEl.Add(priceAt);
            editionEl.Add(pagesAt);      

            ///Add elements in root elements
            newbookandstudent.Add(nameEl);
            newbookandstudent.Add(addressEl);
            newbookandstudent.Add(faculty);
            newbookandstudent.Add(titleEl);
            newbookandstudent.Add(authorEl);
            newbookandstudent.Add(editionEl);
            newbookandstudent.Add(getDAte);
            newbookandstudent.Add(returnDate);

            XElement booksandstudents = xdoc.Element("booksandstudents");

            if (booksandstudents == null)
            {
                booksandstudents = new XElement("booksandstudents");
                xdoc.Add(booksandstudents);
            }

            booksandstudents.Add(newbookandstudent);

            xdoc.Save(path);
        }

        /// <summary>
        ///  Read from XML
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public XElement ReadFromXml(string path)
        {
          XDocument xdoc = XDocument.Load(path);
          XElement root = xdoc.Element("booksandstudents");
          return root;
        }

        /// <summary>
        /// Convert to BookStudent
        /// </summary>
        /// <param name="xel"></param>
        /// <returns></returns>
        public static List<BookAndStudent> ConvertXelementToListBookStudent(XElement xel)
        {
            List<BookAndStudent> listBook = new List<BookAndStudent>();
            foreach (XElement item in xel.Elements("bookandstudent"))
            {

                BookAndStudent tmp = new BookAndStudent
                {
                    Book = new Book(),
                    Student = new Student()

                };

                tmp.Student.Address = item.Element("address").Value;
                tmp.Student.Name = item.Element("name").Value;
                tmp.Student.Faculty = item.Element("faculty").Value;
                tmp.Student.Group = item.Element("faculty").Attribute("group").Value;
                tmp.Student.Course = item.Element("faculty").Attribute("course").Value;
                tmp.Book.Title = item.Element("title").Value;
                tmp.Book.Author = item.Element("author").Value;               
                tmp.Book.Edition = item.Element("edition").Value;
                tmp.Book.Pages = Convert.ToInt32(item.Element("edition").Attribute("pages").Value);
                tmp.Book.Price = Convert.ToInt32(item.Element("edition").Attribute("price").Value);
                tmp.StartRead = item.Element("getdate").Value;
                tmp.EndRead = item.Element("returndate").Value;

                listBook.Add(tmp);
            }
            return listBook;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bs"></param>
        public static void WriteListBookStudent(List<BookAndStudent> bs , string path)
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();               
            }

            for (int i = 0; i < bs.Count(); i++)
            {
                bs[i].WriteTOXml(path);
            }
        }

    }
}
