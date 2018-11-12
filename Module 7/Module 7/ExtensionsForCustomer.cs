using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7
{
    public static class ExtensionsForCustomer
    {       
        /// <summary>
        /// Return Revenue to string
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static string RevenueToString(this Customer customer)
        {
            return String.Format("Revenue = {0:C}", customer.Revenue);
        }
    }
}
