namespace Kasir
{
    partial class AdminAddUsers
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
            adminAddUsers_clearBtn = new Button();
            adminAddUsers_deleteBtn = new Button();
            adminAddUsers_updateBtn = new Button();
            adminAddUsers_addBtn = new Button();
            adminAddUsers_status = new ComboBox();
            adminAddUsers_role = new ComboBox();
            adminAddUsers_password = new TextBox();
            adminAddUses_username = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(adminAddUsers_clearBtn);
            panel1.Controls.Add(adminAddUsers_deleteBtn);
            panel1.Controls.Add(adminAddUsers_updateBtn);
            panel1.Controls.Add(adminAddUsers_addBtn);
            panel1.Controls.Add(adminAddUsers_status);
            panel1.Controls.Add(adminAddUsers_role);
            panel1.Controls.Add(adminAddUsers_password);
            panel1.Controls.Add(adminAddUses_username);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 683);
            panel1.TabIndex = 0;
            // 
            // adminAddUsers_clearBtn
            // 
            adminAddUsers_clearBtn.BackColor = Color.Teal;
            adminAddUsers_clearBtn.FlatStyle = FlatStyle.Flat;
            adminAddUsers_clearBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddUsers_clearBtn.ForeColor = Color.White;
            adminAddUsers_clearBtn.Location = new Point(192, 509);
            adminAddUsers_clearBtn.Name = "adminAddUsers_clearBtn";
            adminAddUsers_clearBtn.Size = new Size(90, 45);
            adminAddUsers_clearBtn.TabIndex = 13;
            adminAddUsers_clearBtn.Text = "CLEAR";
            adminAddUsers_clearBtn.UseVisualStyleBackColor = false;
            adminAddUsers_clearBtn.Click += adminAddUsers_clearBtn_Click;
            // 
            // adminAddUsers_deleteBtn
            // 
            adminAddUsers_deleteBtn.BackColor = Color.Teal;
            adminAddUsers_deleteBtn.FlatStyle = FlatStyle.Flat;
            adminAddUsers_deleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddUsers_deleteBtn.ForeColor = Color.White;
            adminAddUsers_deleteBtn.Location = new Point(58, 509);
            adminAddUsers_deleteBtn.Name = "adminAddUsers_deleteBtn";
            adminAddUsers_deleteBtn.Size = new Size(90, 45);
            adminAddUsers_deleteBtn.TabIndex = 12;
            adminAddUsers_deleteBtn.Text = "DELETE";
            adminAddUsers_deleteBtn.UseVisualStyleBackColor = false;
            adminAddUsers_deleteBtn.Click += adminAddUsers_deleteBtn_Click;
            // 
            // adminAddUsers_updateBtn
            // 
            adminAddUsers_updateBtn.BackColor = Color.Teal;
            adminAddUsers_updateBtn.FlatStyle = FlatStyle.Flat;
            adminAddUsers_updateBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddUsers_updateBtn.ForeColor = Color.White;
            adminAddUsers_updateBtn.Location = new Point(192, 410);
            adminAddUsers_updateBtn.Name = "adminAddUsers_updateBtn";
            adminAddUsers_updateBtn.Size = new Size(90, 45);
            adminAddUsers_updateBtn.TabIndex = 11;
            adminAddUsers_updateBtn.Text = "UPDATE";
            adminAddUsers_updateBtn.UseVisualStyleBackColor = false;
            adminAddUsers_updateBtn.Click += adminAddUsers_updateBtn_Click;
            // 
            // adminAddUsers_addBtn
            // 
            adminAddUsers_addBtn.BackColor = Color.Teal;
            adminAddUsers_addBtn.FlatStyle = FlatStyle.Flat;
            adminAddUsers_addBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            adminAddUsers_addBtn.ForeColor = Color.White;
            adminAddUsers_addBtn.Location = new Point(58, 410);
            adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            adminAddUsers_addBtn.Size = new Size(90, 45);
            adminAddUsers_addBtn.TabIndex = 10;
            adminAddUsers_addBtn.Text = "ADD";
            adminAddUsers_addBtn.UseVisualStyleBackColor = false;
            adminAddUsers_addBtn.Click += adminAddUsers_addBtn_Click;
            // 
            // adminAddUsers_status
            // 
            adminAddUsers_status.DropDownStyle = ComboBoxStyle.DropDownList;
            adminAddUsers_status.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            adminAddUsers_status.FormattingEnabled = true;
            adminAddUsers_status.Items.AddRange(new object[] { "Aktif", "Tidak Aktif", "Perlu Persetujuan" });
            adminAddUsers_status.Location = new Point(130, 230);
            adminAddUsers_status.Name = "adminAddUsers_status";
            adminAddUsers_status.Size = new Size(166, 28);
            adminAddUsers_status.TabIndex = 9;
            // 
            // adminAddUsers_role
            // 
            adminAddUsers_role.DropDownStyle = ComboBoxStyle.DropDownList;
            adminAddUsers_role.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            adminAddUsers_role.FormattingEnabled = true;
            adminAddUsers_role.Items.AddRange(new object[] { "Admin", "Kasir" });
            adminAddUsers_role.Location = new Point(130, 174);
            adminAddUsers_role.Name = "adminAddUsers_role";
            adminAddUsers_role.Size = new Size(166, 28);
            adminAddUsers_role.TabIndex = 8;
            // 
            // adminAddUsers_password
            // 
            adminAddUsers_password.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            adminAddUsers_password.ImeMode = ImeMode.NoControl;
            adminAddUsers_password.Location = new Point(130, 119);
            adminAddUsers_password.Name = "adminAddUsers_password";
            adminAddUsers_password.Size = new Size(166, 25);
            adminAddUsers_password.TabIndex = 7;
            // 
            // adminAddUses_username
            // 
            adminAddUses_username.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            adminAddUses_username.ImeMode = ImeMode.NoControl;
            adminAddUses_username.Location = new Point(130, 63);
            adminAddUses_username.Name = "adminAddUses_username";
            adminAddUses_username.Size = new Size(166, 25);
            adminAddUses_username.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(66, 233);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 5;
            label5.Text = "Status :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(54, 177);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 4;
            label4.Text = "Jabatan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(40, 122);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(40, 66);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 4;
            label2.Text = "Username :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(392, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 683);
            panel2.TabIndex = 1;
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
            dataGridView1.Location = new Point(31, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(837, 595);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 2;
            label1.Text = "Daftar Kasir";
            // 
            // AdminAddUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddUsers";
            Size = new Size(1299, 752);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox adminAddUsers_password;
        private TextBox adminAddUses_username;
        private ComboBox adminAddUsers_role;
        private ComboBox adminAddUsers_status;
        private Button adminAddUsers_clearBtn;
        private Button adminAddUsers_deleteBtn;
        private Button adminAddUsers_updateBtn;
        private Button adminAddUsers_addBtn;
    }
}
