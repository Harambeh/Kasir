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
    public partial class AdminMainForm : Form
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");


        public AdminMainForm()
        {
            InitializeComponent();
            adminDashboardForm1.BringToFront();
            admin_username.Text = Login.CurrentUsername;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Apakah Anda yakin ingin menutupnya?", "Konfirmasi Menutup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            adminAddProducts1.Visible = true;
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminAddProducts1.displayData();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminDashboardForm1.dailyIncome();
            adminDashboardForm1.totalIncome();
            adminDashboardForm1.displayNoStock();
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            adminAddUsers1.Visible = true;
            adminDashboardForm1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
        }

        private void history_Click(object sender, EventArgs e)
        {
            cashierCustomerForm1 .Visible = true;
            adminDashboardForm1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            cashierCustomerForm1.displayCustomerData();
        }
    }
}
