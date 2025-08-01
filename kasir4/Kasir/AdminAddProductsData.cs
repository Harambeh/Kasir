using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace Kasir
{
    internal class AdminAddProductsData
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }

        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");


        public List<AdminAddProductsData> productListData()
        {
            List<AdminAddProductsData> listData = new List<AdminAddProductsData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {

                    connect.Open();
                    string selectData = "SELECT * FROM products";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AdminAddProductsData apd = new AdminAddProductsData();
                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["product_id"].ToString();
                            apd.ProductName = reader["product_name"].ToString();
                            apd.Type = reader["product_tipe"].ToString();
                            apd.Stock = reader["product_stock"].ToString();
                            apd.Price = reader["product_price"].ToString();
                            apd.Status = reader["product_status"].ToString();
                            apd.DateInsert = reader["date_insert"].ToString();
                            apd.DateUpdate = reader["date_update"].ToString();
                            listData.Add(apd);
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
