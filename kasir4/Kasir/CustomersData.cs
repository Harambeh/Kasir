using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    internal class CustomersData
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");

        public int CustID { get; set; }
        public decimal Price { get; set; }
        public decimal Pay { get; set; }
        public decimal Change { get; set; }
        public string date { get; set; }

        public List<CustomersData> allCustomersData()
        {
            List<CustomersData> listData = new List<CustomersData>();

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectAllCustomers = "SELECT * FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(selectAllCustomers, connect))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomersData data = new CustomersData
                            {
                                CustID = (int)reader["customer_id"],
                                Price = Convert.ToDecimal(reader["total_price"]),
                                Pay = Convert.ToDecimal(reader["pay"]),
                                Change = Convert.ToDecimal(reader["change"]),
                                date = reader["date"].ToString()
                            };
                            listData.Add(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }

    }
}
