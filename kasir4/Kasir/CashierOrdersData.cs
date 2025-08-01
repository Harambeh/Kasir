using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    internal class CashierOrdersData
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public int CID { get; set; }
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Qty { get; set; }
        public string Price { get; set; }
        public string Total { get; set; }

        public List<CashierOrdersData> orderListData()
        {
            List<CashierOrdersData> listData = new List<CashierOrdersData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectOrder = "SELECT * FROM orders WHERE customer_id = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(selectOrder, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", CashierOrderForm.getCustID);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CashierOrdersData ordersData = new CashierOrdersData();

                            ordersData.CID = (int)reader["customer_id"];
                            ordersData.ProductID = reader["product_id"].ToString();
                            ordersData.Name = reader["product_name"].ToString();
                            ordersData.Type = reader["product_tipe"].ToString();
                            ordersData.Qty = (int)reader["product_quantity"];
                            ordersData.Price = reader["product_price"].ToString();
                            ordersData.Total = reader["total_price"].ToString();

                            listData.Add(ordersData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Koneksi Gagal: " + ex.Message);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return listData;
        }
    }
}
