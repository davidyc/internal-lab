using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Seller
    {
        string name;

        public Seller(Shop shop, string name)
        {
            this.name = name;
            shop.ShopIsWorking += SellProducts;
            shop.ShopIsClosing += TakeCash;

        }

        /// <summary>
        /// Input message in console message
        /// </summary>
        public void SellProducts()
        {
            Console.WriteLine(name + " sell something!");
        }

        public void TakeCash()
        {
            Console.WriteLine(name + " take cash!");
        }
    }
}
