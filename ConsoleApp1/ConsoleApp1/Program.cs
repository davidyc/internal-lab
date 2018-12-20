using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HelloApp
{
    class Program
    {     
        static void Main(string[] args)
        {
            string connectSTR = @"Data Source= .\SQLEXPRESS; Initial Catalog=HM#1; Integrated Security=True";

            SqlConnection connect = new SqlConnection(connectSTR);
            connect.Open();
            Console.WriteLine(connect.State);
            Console.WriteLine(connect.DataSource);

            Console.Read();
        }
    }
    
}