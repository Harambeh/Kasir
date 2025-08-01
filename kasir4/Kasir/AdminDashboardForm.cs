using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kasir
{
    public partial class AdminDashboardForm : UserControl
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public AdminDashboardForm()
        {
            InitializeComponent();
            displayTotalCashier();
            totalCustomers();
            dailyIncome();
            totalIncome();
            displayNoStock();
        }

        public void displayTotalCashier()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(*) FROM users WHERE role = @role AND status = @status";
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@role", "Kasir");
                        cmd.Parameters.AddWithValue("@status", "Aktif");
                        int totalCashier = (int)cmd.ExecuteScalar();
                        admin_totalCashier.Text = totalCashier.ToString();
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
        }

        public void totalCustomers()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(*) FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        int totalCustomers = (int)cmd.ExecuteScalar();
                        admin_totalCustomers.Text = totalCustomers.ToString();
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
        }

        public void dailyIncome()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM customers WHERE CAST(date AS DATE) = @orderDate";
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@orderDate", DateTime.Today);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            admin_dailyIncome.Text = Convert.ToDecimal(result).ToString("C2");
                        }
                        else
                        {
                            admin_dailyIncome.Text = "Rp 0,00";
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
        }

        public void totalIncome()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            admin_totalIncome.Text = Convert.ToDecimal(result).ToString("C2");
                        }
                        else
                        {
                            admin_totalIncome.Text = "Rp 0,00";
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
        }

        public void displayNoStock()
        {
            CashierNoStock noStock = new CashierNoStock();
            List<CashierNoStock> listData = noStock.noStockProductsData();
            dataGridView1.DataSource = listData;
            gridTable();

        }

        public void gridTable()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int defaultWidth = 110;
            int idWidth = 30;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
                {
                    col.Width = idWidth;
                }
                else
                {
                    col.Width = defaultWidth;
                }
            }
        }
    }
}
