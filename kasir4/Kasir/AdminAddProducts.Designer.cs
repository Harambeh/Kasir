namespace Kasir
{
    partial class AdminAddProducts
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel2 = new Panel();
            adminAddProducts_tipe = new ComboBox();
            adminAddProduct_clearBtn = new Button();
            adminAddProduct_deleteBtn = new Button();
            adminAddProduct_updateBtn = new Button();
            adminAddPruduct_addBtn = new Button();
            adminAddProducts_status = new ComboBox();
            adminAddProducts_price = new TextBox();
            adminAddProducts_stock = new TextBox();
            adminAddProducts_name = new TextBox();
            adminAddProducts_id = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(16, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 393);
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
            dataGridView1.Location = new Point(16, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1228, 336);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 12);
            label7.Name = "label7";
            label7.Size = new Size(159, 23);
            label7.TabIndex = 1;
            label7.Text = "DAFTAR PRODUK";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(adminAddProducts_tipe);
            panel2.Controls.Add(adminAddProduct_clearBtn);
            panel2.Controls.Add(adminAddProduct_deleteBtn);
            panel2.Controls.Add(adminAddProduct_updateBtn);
            panel2.Controls.Add(adminAddPruduct_addBtn);
            panel2.Controls.Add(adminAddProducts_status);
            panel2.Controls.Add(adminAddProducts_price);
            panel2.Controls.Add(adminAddProducts_stock);
            panel2.Controls.Add(adminAddProducts_name);
            panel2.Controls.Add(adminAddProducts_id);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 299);
            panel2.TabIndex = 1;
            // 
            // adminAddProducts_tipe
            // 
            adminAddProducts_tipe.DropDownStyle = ComboBoxStyle.DropDownList;
            adminAddProducts_tipe.Font = new Font("Arial", 12F);
            adminAddProducts_tipe.FormattingEnabled = true;
            adminAddProducts_tipe.Items.AddRange(new object[] { "Makanan", "Minuman" });
            adminAddProducts_tipe.Location = new Point(362, 144);
            adminAddProducts_tipe.Name = "adminAddProducts_tipe";
            adminAddProducts_tipe.Size = new Size(212, 26);
            adminAddProducts_tipe.TabIndex = 21;
            // 
            // adminAddProduct_clearBtn
            // 
            adminAddProduct_clearBtn.BackColor = Color.Teal;
            adminAddProduct_clearBtn.FlatStyle = FlatStyle.Flat;
            adminAddProduct_clearBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddProduct_clearBtn.ForeColor = Color.White;
            adminAddProduct_clearBtn.Location = new Point(810, 210);
            adminAddProduct_clearBtn.Name = "adminAddProduct_clearBtn";
            adminAddProduct_clearBtn.Size = new Size(90, 45);
            adminAddProduct_clearBtn.TabIndex = 17;
            adminAddProduct_clearBtn.Text = "CLEAR";
            adminAddProduct_clearBtn.UseVisualStyleBackColor = false;
            adminAddProduct_clearBtn.Click += adminAddProduct_clearBtn_Click;
            // 
            // adminAddProduct_deleteBtn
            // 
            adminAddProduct_deleteBtn.BackColor = Color.Teal;
            adminAddProduct_deleteBtn.FlatStyle = FlatStyle.Flat;
            adminAddProduct_deleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddProduct_deleteBtn.ForeColor = Color.White;
            adminAddProduct_deleteBtn.Location = new Point(676, 210);
            adminAddProduct_deleteBtn.Name = "adminAddProduct_deleteBtn";
            adminAddProduct_deleteBtn.Size = new Size(90, 45);
            adminAddProduct_deleteBtn.TabIndex = 16;
            adminAddProduct_deleteBtn.Text = "DELETE";
            adminAddProduct_deleteBtn.UseVisualStyleBackColor = false;
            adminAddProduct_deleteBtn.Click += adminAddProduct_deleteBtn_Click;
            // 
            // adminAddProduct_updateBtn
            // 
            adminAddProduct_updateBtn.BackColor = Color.Teal;
            adminAddProduct_updateBtn.FlatStyle = FlatStyle.Flat;
            adminAddProduct_updateBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddProduct_updateBtn.ForeColor = Color.White;
            adminAddProduct_updateBtn.Location = new Point(543, 210);
            adminAddProduct_updateBtn.Name = "adminAddProduct_updateBtn";
            adminAddProduct_updateBtn.Size = new Size(90, 45);
            adminAddProduct_updateBtn.TabIndex = 15;
            adminAddProduct_updateBtn.Text = "UPDATE";
            adminAddProduct_updateBtn.UseVisualStyleBackColor = false;
            adminAddProduct_updateBtn.Click += adminAddProduct_updateBtn_Click;
            // 
            // adminAddPruduct_addBtn
            // 
            adminAddPruduct_addBtn.BackColor = Color.Teal;
            adminAddPruduct_addBtn.FlatStyle = FlatStyle.Flat;
            adminAddPruduct_addBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddPruduct_addBtn.ForeColor = Color.White;
            adminAddPruduct_addBtn.Location = new Point(409, 210);
            adminAddPruduct_addBtn.Name = "adminAddPruduct_addBtn";
            adminAddPruduct_addBtn.Size = new Size(90, 45);
            adminAddPruduct_addBtn.TabIndex = 14;
            adminAddPruduct_addBtn.Text = "ADD";
            adminAddPruduct_addBtn.UseVisualStyleBackColor = false;
            adminAddPruduct_addBtn.Click += adminAddPruduct_addBtn_Click;
            // 
            // adminAddProducts_status
            // 
            adminAddProducts_status.DropDownStyle = ComboBoxStyle.DropDownList;
            adminAddProducts_status.Font = new Font("Arial", 12F);
            adminAddProducts_status.FormattingEnabled = true;
            adminAddProducts_status.Items.AddRange(new object[] { "Tersedia", "Tidak Tersedia" });
            adminAddProducts_status.Location = new Point(764, 144);
            adminAddProducts_status.Name = "adminAddProducts_status";
            adminAddProducts_status.Size = new Size(212, 26);
            adminAddProducts_status.TabIndex = 2;
            // 
            // adminAddProducts_price
            // 
            adminAddProducts_price.Font = new Font("Arial", 12F);
            adminAddProducts_price.Location = new Point(764, 96);
            adminAddProducts_price.Name = "adminAddProducts_price";
            adminAddProducts_price.Size = new Size(212, 26);
            adminAddProducts_price.TabIndex = 1;
            // 
            // adminAddProducts_stock
            // 
            adminAddProducts_stock.Font = new Font("Arial", 12F);
            adminAddProducts_stock.Location = new Point(764, 46);
            adminAddProducts_stock.Name = "adminAddProducts_stock";
            adminAddProducts_stock.Size = new Size(212, 26);
            adminAddProducts_stock.TabIndex = 1;
            // 
            // adminAddProducts_name
            // 
            adminAddProducts_name.Font = new Font("Arial", 12F);
            adminAddProducts_name.Location = new Point(364, 96);
            adminAddProducts_name.Name = "adminAddProducts_name";
            adminAddProducts_name.Size = new Size(212, 26);
            adminAddProducts_name.TabIndex = 1;
            // 
            // adminAddProducts_id
            // 
            adminAddProducts_id.Font = new Font("Arial", 12F);
            adminAddProducts_id.Location = new Point(364, 46);
            adminAddProducts_id.Name = "adminAddProducts_id";
            adminAddProducts_id.Size = new Size(212, 26);
            adminAddProducts_id.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(689, 147);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 0;
            label6.Text = "Status :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(296, 149);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 0;
            label3.Text = "Jenis :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(652, 99);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 0;
            label5.Text = "Harga (Rp.) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(234, 99);
            label2.Name = "label2";
            label2.Size = new Size(123, 19);
            label2.TabIndex = 0;
            label2.Text = "Nama Produk :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(700, 49);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 0;
            label4.Text = "Stok :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(261, 49);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 0;
            label1.Text = "Produk ID :";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1299, 752);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox adminAddProducts_price;
        private TextBox adminAddProducts_stock;
        private TextBox adminAddProducts_name;
        private TextBox adminAddProducts_id;
        private ComboBox adminAddProducts_status;
        private Button adminAddProduct_clearBtn;
        private Button adminAddProduct_deleteBtn;
        private Button adminAddProduct_updateBtn;
        private Button adminAddPruduct_addBtn;
        private Label label7;
        private DataGridView dataGridView1;
        private ComboBox adminAddProducts_tipe;
    }
}
