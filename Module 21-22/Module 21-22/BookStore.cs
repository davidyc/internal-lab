using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_21_22
{
    class BookStore
    {
        /// <summary>
        /// Add new author 
        /// </summary>
        /// <param name="authorName">Name author</param>
        public static void AddAuthor(string authorName)
        {
            using(BookstoreEntities db = new BookstoreEntities())
            {
                db.Authors.Add(new Author { name = authorName });
                db.SaveChanges();  
            }
        }

        /// <summary>
        /// Add new book 
        /// </summary>
        /// <param name="bookName">Name book</param>
        /// <param name="idAuthor">id autho</param>
        /// <param name="BookPrice">price book</param>
        public static void AddBook(string bookName, int idAuthor, int BookPrice)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                Author author =  db.Authors.FirstOrDefault(x=>x.id==idAuthor);
                if(author != null)
                {
                    db.Books.Add(new Book { name = bookName, price = BookPrice, Author = author });
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        /// <summary>
        /// Add new customer 
        /// </summary>
        /// <param name="customerName">Customer name</param>
        /// <param name="customerAdress">customer adress</param>
        public static void AddCustomer(string customerName, string customerAdress)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
               db.Customers.Add(new Customer { name = customerName, adress = customerAdress });
               db.SaveChanges();              
            }
            
        }

        /// <summary>
        /// Add new Order
        /// </summary>
        /// <param name="idB">book id</param>
        /// <param name="idCust">customer id</param>
        public static void AddOrder(int idB, int idCust)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                Book book = db.Books.FirstOrDefault(x => x.id == idB);
                Customer customer = db.Customers.FirstOrDefault(x => x.id == idCust);


                if (customer != null & book != null)
                {
                    db.Orders.Add(new Order { idBook = idB, idCustomer = idCust });
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        /// <summary>
        /// Chenged author name
        /// </summary>
        /// <param name="newName">new name</param>
        /// <param name="_id">id</param>
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

        /// <summary>
        /// Chenged book price for id book
        /// </summary>
        /// <param name="_id">id book</param>
        /// <param name="newPrice">new price</param>
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

        /// <summary>
        /// New name customer for id book
        /// </summary>
        /// <param name="newName">new name customer</param>
        /// <param name="_id">id book</param>
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

        /// <summary>
        /// Chenged id book in order id
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="newBookID"></param>
        public static void EditOrder(int _id, int newBookID)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Orders.FirstOrDefault(x => x.id == _id);
                var tmpBook = db.Books.FirstOrDefault(x => x.id == newBookID);

                if (tmp != null && tmpBook != null)
                {
                    tmp.Book = tmpBook;
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");

            }
        }

        /// <summary>
        /// Delete authot id with all his books and order this books
        /// </summary>
        /// <param name="_id">id authors</param>
        public static void DeleteAuthor(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Authors.FirstOrDefault(x => x.id == _id);

                if (tmp != null)
                {
                    var listOfBooksForDelete = db.Books.Where(x => x.AuthorID == _id);
                    foreach (var item in listOfBooksForDelete)
                    {
                        DeleteBook(item.id);
                    }                                                  
                }            
                else
                    Console.WriteLine("Error");                
            }

            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Authors.FirstOrDefault(x => x.id == _id);

                if (tmp != null)
                {                   
                    db.Authors.Remove(tmp);
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }
     
        /// <summary>
        /// Delete id with all orders book
        /// </summary>
        /// <param name="_id"></param>
        public static void DeleteBook(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Books.FirstOrDefault(x => x.id == _id);

                if (tmp != null)
                {
                    var listForDelete = db.Orders.Where(x => x.idBook == _id);
                    foreach (var item in listForDelete)
                    {
                        db.Orders.Remove(item);
                    }
                    db.Books.Remove(tmp);       
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        /// <summary>
        /// Delete customer with all his orders
        /// </summary>
        /// <param name="_id">customer id</param>
        public static void DeleteCustomer(int _id)
        {
            using (BookstoreEntities db = new BookstoreEntities())
            {
                var tmp = db.Customers.FirstOrDefault(x => x.id == _id);

                if (tmp != null)
                {
                    var listForDelete =  db.Orders.Where(x => x.idCustomer == _id);
                    foreach (var item in listForDelete)
                    {
                        db.Orders.Remove(item);
                    }
                    db.Customers.Remove(tmp); 
                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Error");
            }
        }

        /// <summary>
        /// Delete order id
        /// </summary>
        /// <param name="_id">order  ID</param>
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
