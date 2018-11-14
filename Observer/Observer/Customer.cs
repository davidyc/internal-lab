using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Customer
    {
        string name;

        public Customer(Shop shop, string name)
        {
            this.name = name;
            shop.ShopIsWorking += GoForProducts;
            shop.ShopIsClosing += GoHome;
        }

        public void GoForProducts()
        {
            Console.WriteLine(name + " buy something!");
        }

        public void GoHome()
        {
            Console.WriteLine(name + " go home!");
        }
    }
}
