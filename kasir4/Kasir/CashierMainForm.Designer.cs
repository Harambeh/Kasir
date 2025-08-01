namespace Kasir
{
    partial class CashierMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            panel2 = new Panel();
            cashier_logoutBtn = new Button();
            cashier_historyBtn = new Button();
            cashier_transactionBtn = new Button();
            cashier_addProductBtn = new Button();
            cashier_dashboardBtn = new Button();
            cashier_username = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            login_close = new Button();
            label5 = new Label();
            adminAddProducts1 = new AdminAddProducts();
            adminDashboardForm1 = new AdminDashboardForm();
            cashierOrderForm1 = new CashierOrderForm();
            cashierCustomerForm1 = new CashierCustomerForm();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(cashier_logoutBtn);
            panel2.Controls.Add(cashier_historyBtn);
            panel2.Controls.Add(cashier_transactionBtn);
            panel2.Controls.Add(cashier_addProductBtn);
            panel2.Controls.Add(cashier_dashboardBtn);
            panel2.Controls.Add(cashier_username);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 752);
            panel2.TabIndex = 3;
            // 
            // cashier_logoutBtn
            // 
            cashier_logoutBtn.BackColor = Color.Teal;
            cashier_logoutBtn.FlatStyle = FlatStyle.Flat;
            cashier_logoutBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashier_logoutBtn.ForeColor = Color.White;
            cashier_logoutBtn.Location = new Point(18, 644);
            cashier_logoutBtn.Name = "cashier_logoutBtn";
            cashier_logoutBtn.Size = new Size(250, 45);
            cashier_logoutBtn.TabIndex = 20;
            cashier_logoutBtn.Text = "Logout";
            cashier_logoutBtn.UseVisualStyleBackColor = false;
            cashier_logoutBtn.Click += cashier_logoutBtn_Click;
            // 
            // cashier_historyBtn
            // 
            cashier_historyBtn.BackColor = Color.Teal;
            cashier_historyBtn.FlatStyle = FlatStyle.Flat;
            cashier_historyBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashier_historyBtn.ForeColor = Color.White;
            cashier_historyBtn.Location = new Point(18, 446);
            cashier_historyBtn.Name = "cashier_historyBtn";
            cashier_historyBtn.Size = new Size(250, 45);
            cashier_historyBtn.TabIndex = 19;
            cashier_historyBtn.Text = "Riwayat";
            cashier_historyBtn.UseVisualStyleBackColor = false;
            cashier_historyBtn.Click += cashier_historyBtn_Click;
            // 
            // cashier_transactionBtn
            // 
            cashier_transactionBtn.BackColor = Color.Teal;
            cashier_transactionBtn.FlatStyle = FlatStyle.Flat;
            cashier_transactionBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashier_transactionBtn.ForeColor = Color.White;
            cashier_transactionBtn.Location = new Point(18, 381);
            cashier_transactionBtn.Name = "cashier_transactionBtn";
            cashier_transactionBtn.Size = new Size(250, 45);
            cashier_transactionBtn.TabIndex = 18;
            cashier_transactionBtn.Text = "Pemesanan";
            cashier_transactionBtn.UseVisualStyleBackColor = false;
            cashier_transactionBtn.Click += cashier_transactionBtn_Click;
            // 
            // cashier_addProductBtn
            // 
            cashier_addProductBtn.BackColor = Color.Teal;
            cashier_addProductBtn.FlatStyle = FlatStyle.Flat;
            cashier_addProductBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashier_addProductBtn.ForeColor = Color.White;
            cashier_addProductBtn.Location = new Point(18, 317);
            cashier_addProductBtn.Name = "cashier_addProductBtn";
            cashier_addProductBtn.Size = new Size(250, 45);
            cashier_addProductBtn.TabIndex = 17;
            cashier_addProductBtn.Text = "Tambah Produk";
            cashier_addProductBtn.UseVisualStyleBackColor = false;
            cashier_addProductBtn.Click += cashier_addProductBtn_Click;
            // 
            // cashier_dashboardBtn
            // 
            cashier_dashboardBtn.BackColor = Color.Teal;
            cashier_dashboardBtn.FlatStyle = FlatStyle.Flat;
            cashier_dashboardBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashier_dashboardBtn.ForeColor = Color.White;
            cashier_dashboardBtn.Location = new Point(18, 251);
            cashier_dashboardBtn.Name = "cashier_dashboardBtn";
            cashier_dashboardBtn.Size = new Size(250, 45);
            cashier_dashboardBtn.TabIndex = 16;
            cashier_dashboardBtn.Text = "Dashboard";
            cashier_dashboardBtn.UseVisualStyleBackColor = false;
            cashier_dashboardBtn.Click += cashier_dashboardBtn_Click;
            // 
            // cashier_username
            // 
            cashier_username.AutoSize = true;
            cashier_username.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            cashier_username.ForeColor = Color.White;
            cashier_username.Location = new Point(112, 205);
            cashier_username.Name = "cashier_username";
            cashier_username.Size = new Size(38, 18);
            cashier_username.TabIndex = 15;
            cashier_username.Text = "*****";
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
            label1.Size = new Size(145, 30);
            label1.TabIndex = 13;
            label1.Text = "Kasir Panel";
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(login_close);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 48);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1564, 12);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 21;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_close.BackColor = Color.Red;
            login_close.FlatAppearance.BorderSize = 0;
            login_close.FlatStyle = FlatStyle.Flat;
            login_close.Location = new Point(1564, 11);
            login_close.Name = "login_close";
            login_close.Size = new Size(1424, 0);
            login_close.TabIndex = 13;
            login_close.Text = "X";
            login_close.UseVisualStyleBackColor = false;
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
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(301, 50);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1299, 752);
            adminAddProducts1.TabIndex = 21;
            // 
            // adminDashboardForm1
            // 
            adminDashboardForm1.Location = new Point(301, 49);
            adminDashboardForm1.Name = "adminDashboardForm1";
            adminDashboardForm1.Size = new Size(1299, 752);
            adminDashboardForm1.TabIndex = 22;
            // 
            // cashierOrderForm1
            // 
            cashierOrderForm1.Location = new Point(301, 48);
            cashierOrderForm1.Name = "cashierOrderForm1";
            cashierOrderForm1.Size = new Size(1299, 752);
            cashierOrderForm1.TabIndex = 23;
            // 
            // cashierCustomerForm1
            // 
            cashierCustomerForm1.Location = new Point(301, 50);
            cashierCustomerForm1.Name = "cashierCustomerForm1";
            cashierCustomerForm1.Size = new Size(1299, 752);
            cashierCustomerForm1.TabIndex = 24;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 800);
            Controls.Add(adminDashboardForm1);
            Controls.Add(adminAddProducts1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cashierOrderForm1);
            Controls.Add(cashierCustomerForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button cashier_logoutBtn;
        private Button cashier_historyBtn;
        private Button cashier_transactionBtn;
        private Button cashier_addProductBtn;
        private Button cashier_dashboardBtn;
        private Label cashier_username;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button login_close;
        private Label label5;
        private Button button1;
        private AdminAddProducts adminAddProducts1;
        private AdminDashboardForm adminDashboardForm1;
        private CashierOrderForm cashierOrderForm1;
        private CashierCustomerForm cashierCustomerForm1;
    }
}