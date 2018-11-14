using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Shop
    {
        public Action ShopIsWorking;
        public Action ShopIsClosing;

        /// <summary>
        ///  Start work shop
        /// </summary>
        public void OpenDoor()
        {
            Console.WriteLine("Shop Is Working");
            ShopIsWorking();
        }

        public void CloseDoor()
        {
            Console.WriteLine("Shop Is Closing");
            ShopIsClosing();
        }


    }
}
