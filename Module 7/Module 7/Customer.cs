using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Revenue { get; set; }

        /// <summary>
        /// Return string customer
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("\nName = {0} \nPhone = {1} \nRevenue = {2}",Name, Phone, Revenue);
        }


    }
}
