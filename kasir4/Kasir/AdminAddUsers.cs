using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kasir
{
    public partial class AdminAddUsers : UserControl
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUsersData();
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();
            dataGridView1.DataSource = listData;
            gridTable();

        }
        public void gridTable()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int defaultWidth = 130;
            int idWidth = 60;
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

        public bool emptyField()
        {
            if (adminAddUses_username.Text == "" || adminAddUsers_password.Text == "" || adminAddUsers_role.Text == "" || adminAddUsers_status.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clearFields()
        {
            adminAddUses_username.Clear();
            adminAddUsers_password.Clear();
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;
        }



        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Username, Password, Role, dan Status harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string updateData = "UPDATE users SET password = @pass, role = @role, status = @status, data_reg = @date WHERE username = @usern";
                        using (MySqlCommand cmd = new MySqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adminAddUses_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Pengguna berhasil diperbarui!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                displayAddUsersData();
                            }
                            else
                            {
                                MessageBox.Show("Username tidak bisa diupdate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void adminAddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Username harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM users WHERE username = @usern";
                            using (MySqlCommand cmd = new MySqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adminAddUses_username.Text.Trim());
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Pengguna berhasil dihapus!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                    displayAddUsersData();
                                }
                                else
                                {
                                    MessageBox.Show("Gagal menghapus pengguna.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            adminAddUses_username.Text = row.Cells["username"].Value.ToString();
            adminAddUsers_password.Text = row.Cells["password"].Value.ToString();
            adminAddUsers_role.Text = row.Cells["role"].Value.ToString();
            adminAddUsers_status.Text = row.Cells["status"].Value.ToString();
        }

        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Username, Password, Role, dan Status harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";
                        using (MySqlCommand cmd = new MySqlCommand(selectUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adminAddUses_username.Text.Trim());
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Username sudah ada. Silakan gunakan username yang berbeda.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            connect.Close();
                        }
                        connect.Open();
                        string insertData = "INSERT INTO users (username, password, role, status, data_reg) VALUES (@usern, @pass, @role, @status, @date)";
                        using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adminAddUses_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Pengguna berhasil ditambahkan!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                displayAddUsersData();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menambahkan pengguna.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
