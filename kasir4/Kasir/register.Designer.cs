
namespace Kasir
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            register_loginBtn = new Button();
            register_close = new Button();
            label1 = new Label();
            label2 = new Label();
            register_username = new TextBox();
            register_password = new TextBox();
            label3 = new Label();
            register_showPass = new CheckBox();
            register_btn = new Button();
            label6 = new Label();
            register_cPassword = new TextBox();
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
            panel1.Controls.Add(register_loginBtn);
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
            label4.Location = new Point(56, 380);
            label4.Name = "label4";
            label4.Size = new Size(173, 16);
            label4.TabIndex = 9;
            label4.Text = "Already have an account?";
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.Teal;
            register_loginBtn.FlatStyle = FlatStyle.Flat;
            register_loginBtn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = SystemColors.Control;
            register_loginBtn.Location = new Point(23, 399);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(236, 35);
            register_loginBtn.TabIndex = 9;
            register_loginBtn.Text = "SIGN IN";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // register_close
            // 
            register_close.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            register_close.BackColor = Color.Red;
            register_close.FlatAppearance.BorderSize = 0;
            register_close.FlatStyle = FlatStyle.Flat;
            register_close.Location = new Point(616, 12);
            register_close.Name = "register_close";
            register_close.Size = new Size(24, 24);
            register_close.TabIndex = 0;
            register_close.Text = "X";
            register_close.UseVisualStyleBackColor = false;
            register_close.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 74);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 1;
            label1.Text = "REGISTER";
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
            // register_username
            // 
            register_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(298, 139);
            register_username.Name = "register_username";
            register_username.Size = new Size(330, 26);
            register_username.TabIndex = 4;
            // 
            // register_password
            // 
            register_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(298, 195);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(330, 26);
            register_password.TabIndex = 5;
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
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(298, 284);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(118, 21);
            register_showPass.TabIndex = 7;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.Teal;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.ForeColor = SystemColors.Control;
            register_btn.Location = new Point(298, 336);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(105, 35);
            register_btn.TabIndex = 8;
            register_btn.Text = "SIGN UP";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(298, 232);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password :";
            // 
            // register_cPassword
            // 
            register_cPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_cPassword.Location = new Point(298, 252);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(330, 26);
            register_cPassword.TabIndex = 9;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 456);
            Controls.Add(label6);
            Controls.Add(register_cPassword);
            Controls.Add(register_btn);
            Controls.Add(register_showPass);
            Controls.Add(label3);
            Controls.Add(register_password);
            Controls.Add(register_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(register_close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
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
        private Button register_close;
        private Label label1;
        private Label label2;
        private TextBox register_username;
        private TextBox register_password;
        private Label label3;
        private CheckBox register_showPass;
        private Button register_btn;
        private Label label4;
        private Button register_loginBtn;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private TextBox register_cPassword;
    }
}
