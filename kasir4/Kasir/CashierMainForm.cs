using Microsoft.Data.SqlClient;
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

namespace Kasir
{
    public partial class CashierMainForm : Form
    {
        MySqlConnection SqlConnection = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public string CurrentUsername { get; set; }
        public CashierMainForm()
        {
            InitializeComponent();
            username();
        }

        private void cashier_logoutBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void cashier_dashboardBtn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminDashboardForm1.dailyIncome();
            adminDashboardForm1.totalIncome();
            adminDashboardForm1.displayNoStock();
        }

        private void username()
        {
            SqlConnection.Open();
            string selectUsername = "SELECT username FROM users WHERE username = @username";
            using (MySqlCommand cmd = new MySqlCommand(selectUsername, SqlConnection))
            {
                cmd.Parameters.AddWithValue("@username", Login.CurrentUsername);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cashier_username.Text = reader["username"].ToString();
                }
            }
            SqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Apakah Anda yakin ingin menutupnya?", "Konfirmasi Menutup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }

        private void cashier_addProductBtn_Click(object sender, EventArgs e)
        {
            adminAddProducts1.Visible = true;
            cashierOrderForm1.Visible = false;
            adminDashboardForm1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminAddProducts1.displayData();
        }

        private void cashier_transactionBtn_Click(object sender, EventArgs e)
        {
            cashierOrderForm1.Visible = true;
            adminAddProducts1.Visible = false;
            adminDashboardForm1.Visible = false;
            cashierCustomerForm1.Visible = false;
        }

        private void cashier_historyBtn_Click(object sender, EventArgs e)
        {
            cashierCustomerForm1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = false;
            adminDashboardForm1.Visible = false;
            cashierCustomerForm1.displayCustomerData();
        }
    }
}
