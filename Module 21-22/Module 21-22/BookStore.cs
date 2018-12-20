using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_21_22
{
    class BookStore
    {
        public static void AddAuthor(string authorName)
        {
            using(BookstoreEntities db = new BookstoreEntities())
            {
                db.Authors.Add(new Authors { name = authorName });
                db.SaveChanges();  
            }
        }

        public static void AddBook(string bookName, int idAuthor, int BookPrice)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                Authors author =  db.Authors.FirstOrDefault(x=>x.id==idAuthor);
                if(author != null)
                {
                    db.Books.Add(new Books { name = bookName, price = BookPrice, Authors = author });
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        public static void AddCustomer(string customerName, string customerAdress)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
               db.Customers.Add(new Customers { name = customerName, adress = customerAdress });
               db.SaveChanges();              
            }
        }

        public static void AddOrder(int idB, int idCust)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                Books book = db.Books.FirstOrDefault(x => x.id == idB);
                Customers customer = db.Customers.FirstOrDefault(x => x.id == idCust);


                if (customer != null & book != null)
                {
                    db.Orders.Add(new Orders { idBook = idB, idCustomer = idCust });
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        public static void EditAuthor(string newName, int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Authors.FirstOrDefault(x => x.id == _id);
                if(tmp != null)
                {
                    tmp.name = newName;
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        public static void EditBook(int _id, int newPrice)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Books.FirstOrDefault(x => x.id == _id);
                if (tmp != null)
                {
                    tmp.price= newPrice;
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        public static void EditCustomer(string newName, int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Customers.FirstOrDefault(x => x.id == _id);
                if (tmp != null)
                {
                    tmp.name = newName;
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");

            }
        }

        public static void EditOrder(int _id, int newBookID)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Orders.FirstOrDefault(x => x.id == _id);
                var tmpBook = db.Books.FirstOrDefault(x => x.id == newBookID);

                if (tmp != null && tmpBook != null)
                {
                    tmp.Books = tmpBook;
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");

            }
        }

        public static void DeleteAuthor(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Authors.FirstOrDefault(x => x.id == _id);

                if (tmp != null)
                {
                  
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        public static void DeleteBook(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Books.FirstOrDefault(x => x.id == _id);
                if (tmp != null)
                {
         
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        public static void DeleteCustomer(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Customers.FirstOrDefault(x => x.id == _id);


                if (tmp != null)
                {
               
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");

            }
        }

        public static void DeleteOrder(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Orders.FirstOrDefault(x => x.id == _id);
               
                if (tmp != null)
                {
                    db.Orders.Remove(tmp);         
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");

            }
        }


    }
}
