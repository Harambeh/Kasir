using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    internal class CashierOrderFormProductsData
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }

        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");

        public List<CashierOrderFormProductsData> avaiableProductsData()
        {
            List<CashierOrderFormProductsData> listData = new List<CashierOrderFormProductsData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM products WHERE product_status = @status";
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Tersedia"); 

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var product = new CashierOrderFormProductsData
                            {
                                ID = (int)reader["id"],
                                ProductID = reader["product_id"].ToString(),
                                ProductName = reader["product_name"].ToString(),
                                Type = reader["product_tipe"].ToString(),
                                Stock = reader["product_stock"].ToString(),
                                Price = reader["product_price"].ToString(),
                                Status = reader["product_status"].ToString()
                            };
                            listData.Add(product);
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

        public void LoadAvailableProducts(DataGridView dataGridView)
        {
            var data = avaiableProductsData();
            dataGridView.DataSource = data;
        }
    }

    public class CashierNoStock
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }

        public List<CashierNoStock> noStockProductsData()
        {
            List<CashierNoStock> listData = new List<CashierNoStock>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM products WHERE product_status = @status";
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Tidak Tersedia");
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var product = new CashierNoStock
                            {
                                ProductID = reader["product_id"].ToString(),
                                ProductName = reader["product_name"].ToString(),
                                Type = reader["product_tipe"].ToString(),
                                Stock = reader["product_stock"].ToString(),
                                Price = reader["product_price"].ToString(),
                                Status = reader["product_status"].ToString()
                            };
                            listData.Add(product);
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
