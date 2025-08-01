namespace Kasir
{
    partial class CashierOrderForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            cashier_updateBtn = new Button();
            cashierOrder_clearBtn = new Button();
            cashierOrder_removeBtn = new Button();
            cashierOrder_addBtn = new Button();
            cashier_productPrice = new Label();
            label7 = new Label();
            cashier_productName = new Label();
            label5 = new Label();
            cashier_quantity = new NumericUpDown();
            label4 = new Label();
            cashier_productID = new ComboBox();
            label2 = new Label();
            cashier_productType = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            cashier_reciptBtn = new Button();
            cashierOrder_payBtn = new Button();
            cashier_amount = new TextBox();
            cashier_change = new Label();
            cashier_totalPrice = new Label();
            dataGridView2 = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashier_quantity).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 359);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(19, 32);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(757, 309);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 5);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 3;
            label1.Text = "MENU";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cashier_updateBtn);
            panel2.Controls.Add(cashierOrder_clearBtn);
            panel2.Controls.Add(cashierOrder_removeBtn);
            panel2.Controls.Add(cashierOrder_addBtn);
            panel2.Controls.Add(cashier_productPrice);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cashier_productName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cashier_quantity);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cashier_productID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cashier_productType);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 335);
            panel2.TabIndex = 1;
            // 
            // cashier_updateBtn
            // 
            cashier_updateBtn.BackColor = Color.Teal;
            cashier_updateBtn.FlatStyle = FlatStyle.Flat;
            cashier_updateBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cashier_updateBtn.ForeColor = Color.White;
            cashier_updateBtn.Location = new Point(231, 248);
            cashier_updateBtn.Name = "cashier_updateBtn";
            cashier_updateBtn.Size = new Size(140, 45);
            cashier_updateBtn.TabIndex = 31;
            cashier_updateBtn.Text = "UPDATE";
            cashier_updateBtn.UseVisualStyleBackColor = false;
            cashier_updateBtn.Click += cashier_updateBtn_Click;
            // 
            // cashierOrder_clearBtn
            // 
            cashierOrder_clearBtn.BackColor = Color.Teal;
            cashierOrder_clearBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_clearBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cashierOrder_clearBtn.ForeColor = Color.White;
            cashierOrder_clearBtn.Location = new Point(594, 248);
            cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            cashierOrder_clearBtn.Size = new Size(140, 45);
            cashierOrder_clearBtn.TabIndex = 30;
            cashierOrder_clearBtn.Text = "CLEAR";
            cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            cashierOrder_clearBtn.Click += cashierOrder_clearBtn_Click;
            // 
            // cashierOrder_removeBtn
            // 
            cashierOrder_removeBtn.BackColor = Color.Teal;
            cashierOrder_removeBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_removeBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cashierOrder_removeBtn.ForeColor = Color.White;
            cashierOrder_removeBtn.Location = new Point(410, 248);
            cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            cashierOrder_removeBtn.Size = new Size(140, 45);
            cashierOrder_removeBtn.TabIndex = 29;
            cashierOrder_removeBtn.Text = "REMOVE";
            cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            cashierOrder_removeBtn.Click += cashierOrder_removeBtn_Click;
            // 
            // cashierOrder_addBtn
            // 
            cashierOrder_addBtn.BackColor = Color.Teal;
            cashierOrder_addBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_addBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cashierOrder_addBtn.ForeColor = Color.White;
            cashierOrder_addBtn.Location = new Point(48, 248);
            cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            cashierOrder_addBtn.Size = new Size(140, 45);
            cashierOrder_addBtn.TabIndex = 28;
            cashierOrder_addBtn.Text = "ADD";
            cashierOrder_addBtn.UseVisualStyleBackColor = false;
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click;
            // 
            // cashier_productPrice
            // 
            cashier_productPrice.AutoSize = true;
            cashier_productPrice.Font = new Font("Arial", 12F);
            cashier_productPrice.Location = new Point(148, 162);
            cashier_productPrice.Name = "cashier_productPrice";
            cashier_productPrice.Size = new Size(0, 18);
            cashier_productPrice.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(45, 162);
            label7.Name = "label7";
            label7.Size = new Size(97, 18);
            label7.TabIndex = 26;
            label7.Text = "Harga (Rp.) :";
            // 
            // cashier_productName
            // 
            cashier_productName.AutoSize = true;
            cashier_productName.Font = new Font("Arial", 12F);
            cashier_productName.Location = new Point(148, 101);
            cashier_productName.Name = "cashier_productName";
            cashier_productName.Size = new Size(0, 18);
            cashier_productName.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(30, 101);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 26;
            label5.Text = "Nama Produk :";
            // 
            // cashier_quantity
            // 
            cashier_quantity.Font = new Font("Arial", 12F);
            cashier_quantity.Location = new Point(511, 98);
            cashier_quantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cashier_quantity.Name = "cashier_quantity";
            cashier_quantity.Size = new Size(212, 26);
            cashier_quantity.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(436, 102);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 24;
            label4.Text = "Jumlah : ";
            // 
            // cashier_productID
            // 
            cashier_productID.Font = new Font("Arial", 12F);
            cashier_productID.FormattingEnabled = true;
            cashier_productID.Location = new Point(511, 37);
            cashier_productID.Name = "cashier_productID";
            cashier_productID.Size = new Size(212, 26);
            cashier_productID.TabIndex = 23;
            cashier_productID.SelectedIndexChanged += cashier_productID_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(416, 41);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 22;
            label2.Text = "Produk ID : ";
            // 
            // cashier_productType
            // 
            cashier_productType.Font = new Font("Arial", 12F);
            cashier_productType.FormattingEnabled = true;
            cashier_productType.Items.AddRange(new object[] { "Makanan", "Minuman" });
            cashier_productType.Location = new Point(148, 37);
            cashier_productType.Name = "cashier_productType";
            cashier_productType.Size = new Size(212, 26);
            cashier_productType.TabIndex = 23;
            cashier_productType.SelectedIndexChanged += cashier_productType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(89, 41);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 22;
            label3.Text = "Jenis :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cashier_reciptBtn);
            panel3.Controls.Add(cashierOrder_payBtn);
            panel3.Controls.Add(cashier_amount);
            panel3.Controls.Add(cashier_change);
            panel3.Controls.Add(cashier_totalPrice);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(839, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 714);
            panel3.TabIndex = 2;
            // 
            // cashier_reciptBtn
            // 
            cashier_reciptBtn.BackColor = Color.Teal;
            cashier_reciptBtn.FlatStyle = FlatStyle.Flat;
            cashier_reciptBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cashier_reciptBtn.ForeColor = Color.White;
            cashier_reciptBtn.Location = new Point(42, 641);
            cashier_reciptBtn.Name = "cashier_reciptBtn";
            cashier_reciptBtn.Size = new Size(367, 45);
            cashier_reciptBtn.TabIndex = 30;
            cashier_reciptBtn.Text = "STRUK";
            cashier_reciptBtn.UseVisualStyleBackColor = false;
            cashier_reciptBtn.Click += cashier_reciptBtn_Click;
            // 
            // cashierOrder_payBtn
            // 
            cashierOrder_payBtn.BackColor = Color.Teal;
            cashierOrder_payBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_payBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cashierOrder_payBtn.ForeColor = Color.White;
            cashierOrder_payBtn.Location = new Point(42, 569);
            cashierOrder_payBtn.Name = "cashierOrder_payBtn";
            cashierOrder_payBtn.Size = new Size(367, 45);
            cashierOrder_payBtn.TabIndex = 30;
            cashierOrder_payBtn.Text = "BAYAR";
            cashierOrder_payBtn.UseVisualStyleBackColor = false;
            cashierOrder_payBtn.Click += cashierOrder_payBtn_Click;
            // 
            // cashier_amount
            // 
            cashier_amount.Font = new Font("Arial", 12F);
            cashier_amount.Location = new Point(209, 485);
            cashier_amount.Name = "cashier_amount";
            cashier_amount.Size = new Size(173, 26);
            cashier_amount.TabIndex = 33;
            cashier_amount.KeyDown += cashier_amount_KeyDown;
            // 
            // cashier_change
            // 
            cashier_change.AutoSize = true;
            cashier_change.Font = new Font("Arial", 12F);
            cashier_change.Location = new Point(209, 531);
            cashier_change.Name = "cashier_change";
            cashier_change.Size = new Size(17, 18);
            cashier_change.TabIndex = 32;
            cashier_change.Text = "0";
            // 
            // cashier_totalPrice
            // 
            cashier_totalPrice.AutoSize = true;
            cashier_totalPrice.Font = new Font("Arial", 12F);
            cashier_totalPrice.Location = new Point(209, 448);
            cashier_totalPrice.Name = "cashier_totalPrice";
            cashier_totalPrice.Size = new Size(17, 18);
            cashier_totalPrice.TabIndex = 32;
            cashier_totalPrice.Text = "0";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(25, 32);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(397, 395);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(108, 489);
            label11.Name = "label11";
            label11.Size = new Size(95, 18);
            label11.TabIndex = 31;
            label11.Text = "Bayar (Rp.) :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(70, 531);
            label12.Name = "label12";
            label12.Size = new Size(129, 18);
            label12.TabIndex = 31;
            label12.Text = "Kembalian (Rp.) :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(70, 448);
            label10.Name = "label10";
            label10.Size = new Size(133, 18);
            label10.TabIndex = 31;
            label10.Text = "Total Harga (Rp.) :";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrderForm";
            Size = new Size(1299, 752);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashier_quantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ComboBox cashier_productType;
        private Label label3;
        private ComboBox cashier_productID;
        private Label label2;
        private Label label4;
        private NumericUpDown cashier_quantity;
        private Label label5;
        private Label cashier_productName;
        private Label cashier_productPrice;
        private Label label7;
        private Button cashierOrder_clearBtn;
        private Button cashierOrder_removeBtn;
        private Button cashierOrder_addBtn;
        private Label cashier_totalPrice;
        private Label label10;
        private Label label11;
        private TextBox cashier_amount;
        private Label cashier_change;
        private Label label12;
        private Button cashier_reciptBtn;
        private Button cashierOrder_payBtn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button cashier_updateBtn;
    }
}
