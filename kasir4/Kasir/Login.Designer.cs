
namespace Kasir
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            login_registerBtn = new Button();
            login_close = new Button();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label3 = new Label();
            login_showPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_registerBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 456);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(28, 188);
            label5.Name = "label5";
            label5.Size = new Size(219, 22);
            label5.TabIndex = 11;
            label5.Text = "Aplikasi Manajemen Toko";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(79, 380);
            label4.Name = "label4";
            label4.Size = new Size(123, 16);
            label4.TabIndex = 9;
            label4.Text = "Creat an account?";
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.Teal;
            login_registerBtn.FlatStyle = FlatStyle.Flat;
            login_registerBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_registerBtn.ForeColor = SystemColors.Control;
            login_registerBtn.Location = new Point(23, 399);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(236, 35);
            login_registerBtn.TabIndex = 9;
            login_registerBtn.Text = "REGISTER";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // login_close
            // 
            login_close.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_close.BackColor = Color.Red;
            login_close.FlatAppearance.BorderSize = 0;
            login_close.FlatStyle = FlatStyle.Flat;
            login_close.Location = new Point(616, 12);
            login_close.Name = "login_close";
            login_close.Size = new Size(24, 24);
            login_close.TabIndex = 0;
            login_close.Text = "X";
            login_close.UseVisualStyleBackColor = false;
            login_close.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 74);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 1;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(298, 119);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // login_username
            // 
            login_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(298, 139);
            login_username.Name = "login_username";
            login_username.Size = new Size(330, 26);
            login_username.TabIndex = 4;
            login_username.KeyDown += login_username_KeyDown;
            // 
            // login_password
            // 
            login_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(298, 195);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(330, 26);
            login_password.TabIndex = 5;
            login_password.KeyDown += login_password_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 175);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 6;
            label3.Text = "Password :";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(298, 227);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(118, 21);
            login_showPass.TabIndex = 7;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Teal;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.Control;
            login_btn.Location = new Point(298, 298);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(105, 35);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 456);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(label3);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login_close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button login_close;
        private Label label1;
        private Label label2;
        private TextBox login_username;
        private TextBox login_password;
        private Label label3;
        private CheckBox login_showPass;
        private Button login_btn;
        private Label label4;
        private Button login_registerBtn;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
