namespace Kasir
{
    partial class AdminMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            panel1 = new Panel();
            login_close = new Button();
            label5 = new Label();
            panel2 = new Panel();
            Logout = new Button();
            history = new Button();
            transaction = new Button();
            add_product = new Button();
            dashboard = new Button();
            admin_username = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            adminAddProducts1 = new AdminAddProducts();
            adminAddUsers1 = new AdminAddUsers();
            adminDashboardForm1 = new AdminDashboardForm();
            cashierCustomerForm1 = new CashierCustomerForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(login_close);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 48);
            panel1.TabIndex = 0;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_close.BackColor = Color.Red;
            login_close.FlatAppearance.BorderSize = 0;
            login_close.FlatStyle = FlatStyle.Flat;
            login_close.Location = new Point(1564, 11);
            login_close.Name = "login_close";
            login_close.Size = new Size(24, 24);
            login_close.TabIndex = 13;
            login_close.Text = "X";
            login_close.UseVisualStyleBackColor = false;
            login_close.Click += login_close_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 12);
            label5.Name = "label5";
            label5.Size = new Size(235, 23);
            label5.TabIndex = 12;
            label5.Text = "Aplikasi Manajemen Toko";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(history);
            panel2.Controls.Add(transaction);
            panel2.Controls.Add(add_product);
            panel2.Controls.Add(dashboard);
            panel2.Controls.Add(admin_username);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 752);
            panel2.TabIndex = 1;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Teal;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout.ForeColor = Color.White;
            Logout.Location = new Point(18, 644);
            Logout.Name = "Logout";
            Logout.Size = new Size(250, 45);
            Logout.TabIndex = 20;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // history
            // 
            history.BackColor = Color.Teal;
            history.FlatStyle = FlatStyle.Flat;
            history.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            history.ForeColor = Color.White;
            history.Location = new Point(18, 446);
            history.Name = "history";
            history.Size = new Size(250, 45);
            history.TabIndex = 19;
            history.Text = "Riwayat";
            history.UseVisualStyleBackColor = false;
            history.Click += history_Click;
            // 
            // transaction
            // 
            transaction.BackColor = Color.Teal;
            transaction.FlatStyle = FlatStyle.Flat;
            transaction.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction.ForeColor = Color.White;
            transaction.Location = new Point(18, 381);
            transaction.Name = "transaction";
            transaction.Size = new Size(250, 45);
            transaction.TabIndex = 18;
            transaction.Text = "Tambah Kasir";
            transaction.UseVisualStyleBackColor = false;
            transaction.Click += transaction_Click;
            // 
            // add_product
            // 
            add_product.BackColor = Color.Teal;
            add_product.FlatStyle = FlatStyle.Flat;
            add_product.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_product.ForeColor = Color.White;
            add_product.Location = new Point(18, 317);
            add_product.Name = "add_product";
            add_product.Size = new Size(250, 45);
            add_product.TabIndex = 17;
            add_product.Text = "Tambah Produk";
            add_product.UseVisualStyleBackColor = false;
            add_product.Click += add_product_Click;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.Teal;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard.ForeColor = Color.White;
            dashboard.Location = new Point(18, 251);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(250, 45);
            dashboard.TabIndex = 16;
            dashboard.Text = "Dashboard";
            dashboard.UseVisualStyleBackColor = false;
            dashboard.Click += dashboard_Click;
            // 
            // admin_username
            // 
            admin_username.AutoSize = true;
            admin_username.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            admin_username.ForeColor = Color.White;
            admin_username.Location = new Point(112, 205);
            admin_username.Name = "admin_username";
            admin_username.Size = new Size(51, 18);
            admin_username.TabIndex = 15;
            admin_username.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 205);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 14;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 165);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 13;
            label1.Text = "Admin Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(301, 49);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1299, 752);
            adminAddProducts1.TabIndex = 3;
            // 
            // adminAddUsers1
            // 
            adminAddUsers1.Location = new Point(301, 48);
            adminAddUsers1.Name = "adminAddUsers1";
            adminAddUsers1.Size = new Size(1299, 752);
            adminAddUsers1.TabIndex = 4;
            // 
            // adminDashboardForm1
            // 
            adminDashboardForm1.Location = new Point(298, 45);
            adminDashboardForm1.Name = "adminDashboardForm1";
            adminDashboardForm1.Size = new Size(1299, 752);
            adminDashboardForm1.TabIndex = 5;
            // 
            // cashierCustomerForm1
            // 
            cashierCustomerForm1.Location = new Point(298, 48);
            cashierCustomerForm1.Name = "cashierCustomerForm1";
            cashierCustomerForm1.Size = new Size(1299, 752);
            cashierCustomerForm1.TabIndex = 21;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 800);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(adminDashboardForm1);
            Controls.Add(adminAddProducts1);
            Controls.Add(adminAddUsers1);
            Controls.Add(cashierCustomerForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label1;
        private Label admin_username;
        private Label label2;
        private Button dashboard;
        private Button Logout;
        private Button history;
        private Button transaction;
        private Button add_product;
        private Button login_close;
        private AdminAddProducts adminAddProducts1;
        private AdminAddUsers adminAddUsers1;
        private AdminDashboardForm adminDashboardForm1;
        private CashierCustomerForm cashierCustomerForm1;
    }
}