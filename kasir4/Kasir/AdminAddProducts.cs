using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class AdminAddProducts : UserControl
    {

        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayData();
        }

        public bool emptyField()
        {
            if (adminAddProducts_id.Text == "" || adminAddProducts_name.Text == "" || adminAddProducts_tipe.Text == ""
                || adminAddProducts_stock.Text == "" || adminAddProducts_price.Text == "" || adminAddProducts_status.SelectedIndex == -1)
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
            adminAddProducts_id.Clear();
            adminAddProducts_name.Clear();
            adminAddProducts_stock.Clear();
            adminAddProducts_price.Clear();
            adminAddProducts_tipe.SelectedIndex = -1;
            adminAddProducts_status.SelectedIndex = -1;
        }

        public void gridTable()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int defaultWidth = 130;
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
        public void displayData()
        {
            AdminAddProductsData productsData = new AdminAddProductsData();
            List<AdminAddProductsData> listData = productsData.productListData();
            dataGridView1.DataSource = listData;
            gridTable();
        }

        private void adminAddPruduct_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Semua field harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectProductId = "SELECT * FROM products WHERE product_id = @prodID";

                        using (MySqlCommand cmd = new MySqlCommand(selectProductId, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("ID Produk sudah ada. Silakan gunakan ID yang berbeda.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products (product_id, product_name, product_tipe, product_stock, product_price, product_status, date_insert) " +
                                                    "VALUES (@prodID, @prodName, @prodTipe, @prodStock, @prodPrice, @prodStatus, @dateInsert)";


                                using (MySqlCommand insertCmd = new MySqlCommand(insertData, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@prodTipe", adminAddProducts_tipe.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@prodStock", int.Parse(adminAddProducts_stock.Text.Trim()));
                                    insertCmd.Parameters.AddWithValue("@prodPrice", decimal.Parse(adminAddProducts_price.Text.Trim()));
                                    insertCmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.SelectedItem.ToString());
                                    insertCmd.Parameters.AddWithValue("@dateInsert", DateTime.Now);
                                    int result = insertCmd.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Produk berhasil ditambahkan!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        clearFields();
                                        displayData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Gagal menambahkan produk.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

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

        private string currentImagePath = null;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            adminAddProducts_id.Text = row.Cells["ProductID"].Value.ToString();
            adminAddProducts_name.Text = row.Cells["ProductName"].Value.ToString();
            adminAddProducts_tipe.Text = row.Cells["Type"].Value.ToString();
            adminAddProducts_stock.Text = row.Cells["Stock"].Value.ToString();
            adminAddProducts_price.Text = row.Cells["Price"].Value.ToString();
            adminAddProducts_status.SelectedItem = row.Cells["Status"].Value.ToString();
        }

        private void adminAddProduct_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void adminAddProduct_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Semua field harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin memperbarui produk ini?", "Konfirmasi Perbarui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(adminAddProducts_stock.Text != "0")
                    {
                        adminAddProducts_status.SelectedItem = "Tersedia";
                    }else
                    {
                        adminAddProducts_status.SelectedItem = "Tidak Tersedia";
                    }
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE products SET product_name = @prodName, product_tipe = @prodTipe, product_stock = @prodStock, " +
                                                "product_price = @prodPrice, product_status = @prodStatus, date_update = @dateUpdate " +
                                                "WHERE product_id = @prodID";

                            using (MySqlCommand cmd = new MySqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodTipe", adminAddProducts_tipe.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodStock", int.Parse(adminAddProducts_stock.Text.Trim()));
                                cmd.Parameters.AddWithValue("@prodPrice", decimal.Parse(adminAddProducts_price.Text.Trim()));
                                cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@dateUpdate", DateTime.Now);
                                int resultUpdate = cmd.ExecuteNonQuery();
                                if (resultUpdate > 0)
                                {
                                    MessageBox.Show("Produk berhasil diperbarui!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                    displayData();
                                }
                                else
                                {
                                    MessageBox.Show("Gagal memperbarui produk.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void adminAddProduct_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("ID Produk harus diisi terlebih dahulu.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus Produk ID: " + adminAddProducts_id.Text + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE products WHERE product_id = @prodID";
                            using (MySqlCommand cmd = new MySqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                int resultDelete = cmd.ExecuteNonQuery();
                                if (resultDelete > 0)
                                {
                                    MessageBox.Show("Produk berhasil dihapus!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                    displayData();
                                }
                                else
                                {
                                    MessageBox.Show("Gagal menghapus produk. Nama produk harus sesuai!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
