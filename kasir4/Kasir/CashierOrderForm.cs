using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Org.BouncyCastle.Asn1.Ocsp;
using MySql.Data.MySqlClient;

namespace Kasir
{
    public partial class CashierOrderForm : UserControl
    {
        public static int getCustID;
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");
        public CashierOrderForm()
        {
            InitializeComponent();
            displayAvaiableProducts();
            IDGenerator();
            displayOrders();
            displayTotalPrice();
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

        public void gridOrder()
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int defaultWidth = 82;
            int idWidth = 32;
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.Name.Equals("CID", StringComparison.OrdinalIgnoreCase) || col.Name.Equals("Qty", StringComparison.OrdinalIgnoreCase))
                {
                    col.Width = idWidth;
                }
                else
                {
                    col.Width = defaultWidth;
                }
            }
        }
        public void displayAvaiableProducts()
        {
            CashierOrderFormProductsData allProd = new CashierOrderFormProductsData();
            allProd.LoadAvailableProducts(dataGridView1);
            gridTable();
        }

        private float totalPrice;

        public void displayTotalPrice()
        {
            IDGenerator();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectTotal = "SELECT SUM(total_price) AS TotalPrice FROM orders WHERE customer_id = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(selectTotal, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashier_totalPrice.Text = totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi Gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void cashier_productType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashier_productID.SelectedIndex = -1;
            cashier_productID.Items.Clear();

            string selectedType = cashier_productType.SelectedItem as string;

            if (selectedType != null)
            {
                try
                {
                    using (MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;"))
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM products WHERE product_tipe = @product_tipe AND product_status = 'Tersedia'";
                        using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@product_tipe", selectedType);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                cashier_productID.Items.Add(reader["product_id"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi Gagal: " + ex.Message);
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

        private void cashier_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashier_productID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;"))
                    {
                        connect.Open();
                        string selectData = "SELECT product_name, product_price FROM products WHERE product_id = @product_id AND product_status = 'Tersedia'";
                        using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@product_id", selectedValue);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["product_name"].ToString();
                                    string prodPrice = reader["product_price"].ToString();

                                    cashier_productName.Text = prodName;
                                    cashier_productPrice.Text = prodPrice;
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void clearOrder()
        {
            cashier_productID.SelectedIndex = -1;
            cashier_productID.Text = "";
            cashier_productType.SelectedIndex = -1;
            cashier_productName.Text = "";
            cashier_productPrice.Text = "";
            cashier_quantity.Value = 0;
        }
        private void cashierOrder_clearBtn_Click(object sender, EventArgs e)
        {
            clearOrder();

        }

        public void displayOrders()
        {
            CashierOrdersData ordersData = new CashierOrdersData();
            dataGridView2.DataSource = ordersData.orderListData();
            dataGridView2.Columns["ProductID"].Visible = false;
            gridOrder();
        }
        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();
            if (cashier_productID.Text == "" || cashier_productType.Text == "" || cashier_productName.Text == "" || cashier_productPrice.Text == "" || cashier_quantity.Value == 0)
            {
                MessageBox.Show("Mohon untuk melengkapi data terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE product_id = @product_id";

                        using (MySqlCommand GetOrder = new MySqlCommand(selectOrder, connect))
                        {
                            GetOrder.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);
                            using (MySqlDataReader reader = GetOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    getPrice = float.Parse(reader["product_price"].ToString());
                                }
                            }
                        }

                        // Cek apakah produk sudah ada
                        string checkQuery = "SELECT product_quantity FROM orders WHERE customer_id = @customer_id AND product_id = @product_id";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@customer_id", idGen);
                            checkCmd.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);

                            object result = checkCmd.ExecuteScalar();

                            if (result != null)
                            {
                                // Produk sudah ada, update
                                int existingQty = Convert.ToInt32(result);
                                int newQty = existingQty + (int)cashier_quantity.Value;
                                float totalPrice = newQty * getPrice;

                                string updateQuery = "UPDATE orders SET product_quantity = @quantity, total_price = @total_price " +
                                                     "WHERE customer_id = @customer_id AND product_id = @product_id";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@quantity", newQty);
                                    updateCmd.Parameters.AddWithValue("@total_price", totalPrice);
                                    updateCmd.Parameters.AddWithValue("@customer_id", idGen);
                                    updateCmd.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Produk baru, insert
                                string insertOrder = "INSERT INTO orders (customer_id, product_id, product_name, product_tipe, product_price, product_quantity, total_price, order_date) " +
                                                     "VALUES (@customer_id, @product_id, @product_name, @product_tipe, @product_price, @quantity, @total_price, @orderDate)";
                                using (MySqlCommand cmd = new MySqlCommand(insertOrder, connect))
                                {
                                    float totalPrice = getPrice * ((int)cashier_quantity.Value);
                                    cmd.Parameters.AddWithValue("@customer_id", idGen);
                                    cmd.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);
                                    cmd.Parameters.AddWithValue("@product_name", cashier_productName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@product_tipe", cashier_productType.SelectedItem);
                                    cmd.Parameters.AddWithValue("@product_price", cashier_productPrice.Text.Trim());
                                    cmd.Parameters.AddWithValue("@quantity", cashier_quantity.Value);
                                    cmd.Parameters.AddWithValue("@total_price", totalPrice);
                                    cmd.Parameters.AddWithValue("@orderDate", DateTime.Now);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Pesanan berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayOrders();
                        displayTotalPrice();
                        clearOrder();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menambahkan pesanan: " + ex.Message);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                            connect.Close();
                    }
                }
            }

            displayTotalPrice();
        }



        private int idGen = 0;
        private void IDGenerator()
        {
            using (MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;"))
            {
                connect.Open();
                string selectData = "SELECT IFNULL(MAX(customer_id), 0) FROM customers";
                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                {
                    int currentMaxID = Convert.ToInt32(cmd.ExecuteScalar());
                    idGen = currentMaxID + 1;
                    getCustID = idGen;
                }
            }
        }

        private void cashier_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = float.Parse(cashier_amount.Text, CultureInfo.InvariantCulture);
                    float getChange = (getAmount - totalPrice);

                    if (getChange < 0)
                    {
                        MessageBox.Show("Jumlah uang tidak cukup untuk membayar total harga.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cashier_change.Text = "";
                        return;
                    }
                    else
                    {
                        cashier_change.Text = getChange.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierOrder_payBtn_Click(object sender, EventArgs e)
        {

            if (cashier_amount.Text == "" || cashier_change.Text == "")
            {
                MessageBox.Show("Mohon untuk memasukkan jumlah uang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (MessageBox.Show("Apakah Anda yakin ingin melakukan pembayaran?", "Konfirmasi Pembayaran",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["ProductID"].Value != null && row.Cells["Qty"].Value != null)
                        {
                            string productId = row.Cells["ProductID"].Value.ToString();
                            int quantityWanted = Convert.ToInt32(row.Cells["Qty"].Value);

                            using (MySqlConnection tempConn = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;"))
                            {
                                tempConn.Open();
                                string checkStockQuery = "SELECT product_stock FROM products WHERE product_id = @productId";
                                using (MySqlCommand checkCmd = new MySqlCommand(checkStockQuery, tempConn))
                                {
                                    checkCmd.Parameters.AddWithValue("@productId", productId);
                                    object stockResult = checkCmd.ExecuteScalar();

                                    if (stockResult != null)
                                    {
                                        int currentStock = Convert.ToInt32(stockResult);
                                        if (quantityWanted > currentStock)
                                        {
                                            MessageBox.Show($"Stok tidak cukup untuk produk ID {productId}. Tersedia: {currentStock}, Diminta: {quantityWanted}",
                                                "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return; // Hentikan proses pembayaran
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Produk dengan ID {productId} tidak ditemukan dalam database.",
                                            "Produk Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return; // Hentikan proses pembayaran
                                    }
                                }
                            }
                        }
                    }

                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            string updateStatus = "INSERT into customers (customer_id, total_price, pay, `change`, date)" +
                                "Values(@custID, @total, @pay, @change, @date)";
                            using (MySqlCommand cmd = new MySqlCommand(updateStatus, connect))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@total", totalPrice);
                                cmd.Parameters.AddWithValue("@pay", float.Parse(cashier_amount.Text, CultureInfo.InvariantCulture));
                                cmd.Parameters.AddWithValue("@change", float.Parse(cashier_change.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("id-ID")));
                                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    foreach (DataGridViewRow row in dataGridView2.Rows)
                                    {
                                        if (row.Cells["ProductID"].Value != null && row.Cells["Qty"].Value != null)
                                        {
                                            string productId = row.Cells["ProductID"].Value.ToString();
                                            int quantityBought = Convert.ToInt32(row.Cells["Qty"].Value);

                                            string updateStockQuery = "UPDATE products SET product_stock = product_stock - @quantity WHERE product_id = @productId";

                                            using (MySqlCommand stockCmd = new MySqlCommand(updateStockQuery, connect))
                                            {
                                                stockCmd.Parameters.AddWithValue("@quantity", quantityBought);
                                                stockCmd.Parameters.AddWithValue("@productId", productId);
                                                stockCmd.ExecuteNonQuery();
                                            }

                                            string updateStock = "UPDATE products SET product_status = 'Tidak Tersedia' WHERE product_stock <= 0 AND product_id = @productId";
                                            using (MySqlCommand stockCmd = new MySqlCommand(updateStock, connect))
                                            {
                                                stockCmd.Parameters.AddWithValue("@productId", productId);
                                                stockCmd.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                    printPage();
                                    MessageBox.Show("Pembayaran Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    IDGenerator();
                                    cashier_amount.Text = "";
                                    cashier_change.Text = "";
                                    displayAvaiableProducts();
                                    displayOrders();
                                    displayTotalPrice();
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Koneksi Gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            }
            displayTotalPrice();

        }

        private int rowIndex = -0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Zaeni's Market";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + ((dataGridView2.Columns.Count - 1) / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            // Hanya header yang ingin di-print (tanpa ProductID)
            string[] header = { "CID", "Name", "Type", "Qty", "Price", "Total" };
            int[] printIndexes = { 0, 2, 3, 4, 5, 6 }; // index di DataGridView2 tanpa ProductID (index 1)

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                for (int i = 0; i < printIndexes.Length; i++)
                {
                    object cellValue = row.Cells[printIndexes[i]].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                int labelMargin = (int)Math.Min(rSpace, 200);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price: \t" + cashier_totalPrice.Text + "\nPay: \t"
                    + cashier_amount.Text + "\n\t\t------------\nChange: \t" + cashier_change.Text, labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);
            }
        }


        public void printPage()
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void cashier_reciptBtn_Click(object sender, EventArgs e)
        {
            printPage();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void cashierOrder_removeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                if (selectedRow.Cells["CID"].Value != null && selectedRow.Cells["Name"].Value != null)
                {
                    int orderID = Convert.ToInt32(selectedRow.Cells["CID"].Value);
                    string orderName = selectedRow.Cells["Name"].Value.ToString();
                    try
                    {
                        if (connect.State == ConnectionState.Closed)
                            connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE product_id = @product_id";

                        using (MySqlCommand GetOrder = new MySqlCommand(selectOrder, connect))
                        {
                            GetOrder.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);
                            using (MySqlDataReader reader = GetOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    getPrice = float.Parse(reader["product_price"].ToString());
                                }
                            }
                        }

                        // Cek apakah produk sudah ada
                        string checkQuery = "SELECT product_quantity FROM orders WHERE customer_id = @customer_id AND product_id = @product_id";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@customer_id", idGen);
                            checkCmd.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);

                            object result = checkCmd.ExecuteScalar();

                            if (result != null)
                            {
                                // Produk sudah ada, update
                                int existingQty = Convert.ToInt32(result);
                                int newQty = existingQty + (int)cashier_quantity.Value;
                                float totalPrice = newQty * getPrice;

                                string updateQuery = "UPDATE orders SET product_quantity = @quantity, total_price = @total_price " +
                                                     "WHERE customer_id = @customer_id AND product_id = @product_id";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@quantity", newQty);
                                    updateCmd.Parameters.AddWithValue("@total_price", totalPrice);
                                    updateCmd.Parameters.AddWithValue("@customer_id", idGen);
                                    updateCmd.Parameters.AddWithValue("@product_id", cashier_productID.SelectedItem);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus pesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                            connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Baris yang dipilih tidak memiliki nilai CID atau Name yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            if (row != null && row.Cells.Count > 0)
            {
                cashier_productID.Text = row.Cells["ProductID"].Value.ToString();
                cashier_productName.Text = row.Cells["Name"].Value.ToString();
                cashier_productType.SelectedItem = row.Cells["Type"].Value.ToString();
                int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                if (qty < cashier_quantity.Minimum)
                {
                    qty = (int)cashier_quantity.Minimum;
                }
                else if (qty > cashier_quantity.Maximum)
                {
                    cashier_quantity.Maximum = qty;

                    cashier_quantity.Value = qty;
                    cashier_quantity.Value = 0;
                }
                cashier_productPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null && row.Cells.Count > 0)
            {
                cashier_productID.SelectedItem = row.Cells["ProductID"].Value.ToString();
                cashier_productName.Text = row.Cells["ProductName"].Value.ToString();
                cashier_productType.SelectedItem = row.Cells["Type"].Value.ToString();
                cashier_productPrice.Text = row.Cells["Price"].Value.ToString();
                cashier_quantity.Value = 0;
            }
        }

        private void cashier_updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih baris pesanan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
            if (selectedRow.Cells["CID"].Value == null || selectedRow.Cells["Name"].Value == null)
            {
                MessageBox.Show("Baris yang dipilih tidak memiliki nilai CID atau Name yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cashier_productID.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih ID produk.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newQty = (int)cashier_quantity.Value;
            if (newQty <= 0)
            {
                MessageBox.Show("Kuantitas harus lebih besar dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(selectedRow.Cells["CID"].Value);
            string productId = cashier_productID.SelectedItem.ToString();

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                decimal productPrice = 0;
                using (var priceCmd = new MySqlCommand("SELECT product_price FROM products WHERE product_id = @product_id", connect))
                {
                    priceCmd.Parameters.AddWithValue("@product_id", productId);
                    var result = priceCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Produk tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    productPrice = Convert.ToDecimal(result);
                }

                decimal totalPrice = newQty * productPrice;

                using (var updateCmd = new MySqlCommand(@"UPDATE orders SET product_quantity = @quantity, total_price = @total_price WHERE customer_id = @customer_id AND product_id = @product_id", connect))
                {
                    updateCmd.Parameters.AddWithValue("@quantity", newQty);
                    updateCmd.Parameters.AddWithValue("@total_price", totalPrice);
                    updateCmd.Parameters.AddWithValue("@customer_id", customerId);
                    updateCmd.Parameters.AddWithValue("@product_id", productId);

                    int rows = updateCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Pesanan berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau tidak berubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengupdate: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
            displayOrders();
            displayTotalPrice();
            clearOrder();
        }




    }


}
