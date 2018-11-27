using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Module_14
{
    class Book : IWorkingWithXML
    {
        public string Title { set; get; }
        public int Year { set; get; }
        public string Author { set; get; }
        public string Edition { set; get; }
        public int Price { set; get; }
        public int Pages { set; get; }
               
        /// <summary>
        ///Write in XMl
        /// </summary>
        /// <param name="path">path for file</param>
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
                XElement xElement = new XElement("books", "");
                xdoc.Add(xElement);
            }

            XElement newBook = new XElement("book");           
            
            XElement titleEl= new XElement("title", Title);
            XElement authorEl= new XElement("author", Author);
            XElement yearEl= new XElement("year", Year);
            XElement editionEl = new XElement("edition", Year);
            XAttribute priceAt = new XAttribute("price", Price);
            XAttribute pagesAt = new XAttribute("pages", Pages);

            editionEl.Add(priceAt);
            editionEl.Add(pagesAt);

            newBook.Add(titleEl);
            newBook.Add(authorEl);
            newBook.Add(editionEl);
            newBook.Add(yearEl);  
         
            XElement books = xdoc.Element("books");

            if(books == null) {
                books = new XElement("books");
                xdoc.Add(books);
            }

            books.Add(newBook);
            xdoc.Save(path);
        }

        /// <summary>
        /// Read form XML file
        /// </summary>
        /// <param name="path">path</param>
        /// <returns>XElements</returns>
        public XElement ReadFromXml(string path)
        {
            XDocument xdoc = XDocument.Load(path);
            XElement root = xdoc.Root;
            return root;
        }

        /// <summary>
        /// Convert XML book to class book list
        /// </summary>
        /// <param name="xel">element</param>
        /// <returns>List books</returns>
        public static List<Book> ConvertXelementToListBooks(XElement xel)
        {
            List<Book> listBook = new List<Book>();
            foreach (XElement item in xel.Elements("book"))
            {            
                Book tmp = new Book();
                tmp.Title = item.Element("title").Value;
                tmp.Author = item.Element("author").Value;
                tmp.Year = Convert.ToInt32(item.Element("year").Value);
                tmp.Edition = item.Element("edition").Value;
                tmp.Pages = Convert.ToInt32(item.Element("edition").Attribute("pages").Value);
                tmp.Price = Convert.ToInt32(item.Element("edition").Attribute("price").Value);

                listBook.Add(tmp);
             }


            return listBook;
        }
    }
}
