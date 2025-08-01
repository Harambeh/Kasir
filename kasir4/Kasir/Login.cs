using Azure.Core;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Kasir
{

    public partial class Login : Form
    {
        public static string CurrentUsername { get; set; }

        public static string CurrentRole { get; set; }

        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");

    
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        public bool emptyField()
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Username atau Password harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectAccount = "SELECT username, role FROM users WHERE username = @usern AND password = @pass AND status = @status";

                        using (MySqlCommand cmd = new MySqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Aktif");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    CurrentUsername = reader["username"].ToString();
                                    CurrentRole = reader["role"].ToString();

                                    MessageBox.Show("Login Berhasil!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (CurrentRole == "Admin")
                                    {
                                        AdminMainForm adminForm = new AdminMainForm();
                                        adminForm.Show();
                                        this.Hide();
                                    }
                                    else if (CurrentRole == "Kasir")
                                    {
                                        CashierMainForm cashierForm = new CashierMainForm();
                                        cashierForm.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Username/Password salah! atau belum disetujui oleh admin!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Koneksi gagal: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void login_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        private void login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }
    }
}
