using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SqlConnection   con = new SqlConnection("data source =BLT10141\\SQLEXPRESS2017;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetAllProducts ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Console.WriteLine("Price = {0} ,Product Name = {1}", datareader["UnitPrice"], datareader["ProductName"]);
            }
            datareader.Read();
            con.Close();
        }
    }
}
