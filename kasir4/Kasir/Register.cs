using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Kasir
{
    public partial class Register : Form
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        public bool emptyField() {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Username atau Password harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT * FROM users WHERE username = @usern";

                        using (MySqlCommand checkUsername = new MySqlCommand(selectUsername, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                string usern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(usern + " Sudah ada yang menggunakan.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_cPassword.Text)
                            {
                                MessageBox.Show("Password tidak cocok.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Password setidaknya min 8 character.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else
                            {
                                string insertData = "INSERT INTO users(username,password,role,status,data_reg)" +
                                    "VALUES(@usern, @pass, @role, @status, @date)";

                                using(MySqlCommand cmd = new MySqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", "Kasir");
                                    cmd.Parameters.AddWithValue("@status", "Aktif");
                                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registrasi telah berhasil!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login login = new Login();
                                    login.Show();

                                    this.Hide();
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
    }
}
