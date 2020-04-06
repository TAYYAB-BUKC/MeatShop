namespace MeatShop
{
    partial class ManageUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label10 = new System.Windows.Forms.Label();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.User_Password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Grd_User = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.User_Name = new System.Windows.Forms.TextBox();
			this.User_ID = new System.Windows.Forms.TextBox();
			this.User_Username = new System.Windows.Forms.TextBox();
			this.User_Search = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.User_Role = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Grd_User)).BeginInit();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(127, 308);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 22);
			this.label10.TabIndex = 85;
			this.label10.Text = "Role";
			// 
			// Delete_Button
			// 
			this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Delete_Button.FlatAppearance.BorderSize = 0;
			this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Delete_Button.Location = new System.Drawing.Point(637, 383);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(150, 40);
			this.Delete_Button.TabIndex = 82;
			this.Delete_Button.Text = "Delete";
			this.Delete_Button.UseVisualStyleBackColor = false;
			this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(18, 361);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1141, 5);
			this.panel2.TabIndex = 74;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(86, 260);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 22);
			this.label5.TabIndex = 80;
			this.label5.Text = "Password";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(80, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 22);
			this.label4.TabIndex = 78;
			this.label4.Text = "Username";
			// 
			// User_Password
			// 
			this.User_Password.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Password.Location = new System.Drawing.Point(205, 257);
			this.User_Password.Name = "User_Password";
			this.User_Password.Size = new System.Drawing.Size(240, 31);
			this.User_Password.TabIndex = 77;
			this.User_Password.Click += new System.EventHandler(this.Business_Email_Click);
			this.User_Password.Leave += new System.EventHandler(this.Business_Email_Leave);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(115, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 22);
			this.label3.TabIndex = 76;
			this.label3.Text = "Name";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "User Management";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1142, 5);
			this.panel1.TabIndex = 73;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(105, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 22);
			this.label2.TabIndex = 72;
			this.label2.Text = "User ID";
			// 
			// Update_Button
			// 
			this.Update_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Update_Button.FlatAppearance.BorderSize = 0;
			this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Update_Button.Location = new System.Drawing.Point(449, 383);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(150, 40);
			this.Update_Button.TabIndex = 70;
			this.Update_Button.Text = "Update";
			this.Update_Button.UseVisualStyleBackColor = false;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// Grd_User
			// 
			this.Grd_User.AllowUserToAddRows = false;
			this.Grd_User.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.Grd_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_User.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.Grd_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_User.DoubleBuffered = true;
			this.Grd_User.EnableHeadersVisualStyles = false;
			this.Grd_User.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_User.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_User.Location = new System.Drawing.Point(485, 124);
			this.Grd_User.Name = "Grd_User";
			this.Grd_User.ReadOnly = true;
			this.Grd_User.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_User.Size = new System.Drawing.Size(676, 214);
			this.Grd_User.TabIndex = 89;
			this.Grd_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Appointment_CellClick);
			// 
			// User_Name
			// 
			this.User_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Name.Location = new System.Drawing.Point(205, 151);
			this.User_Name.Name = "User_Name";
			this.User_Name.Size = new System.Drawing.Size(240, 31);
			this.User_Name.TabIndex = 90;
			// 
			// User_ID
			// 
			this.User_ID.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_ID.Location = new System.Drawing.Point(205, 99);
			this.User_ID.Name = "User_ID";
			this.User_ID.ReadOnly = true;
			this.User_ID.Size = new System.Drawing.Size(240, 31);
			this.User_ID.TabIndex = 91;
			// 
			// User_Username
			// 
			this.User_Username.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Username.Location = new System.Drawing.Point(205, 204);
			this.User_Username.Name = "User_Username";
			this.User_Username.Size = new System.Drawing.Size(240, 31);
			this.User_Username.TabIndex = 96;
			this.User_Username.Click += new System.EventHandler(this.Business_Phone_Click);
			this.User_Username.Leave += new System.EventHandler(this.Business_Phone_Leave);
			// 
			// User_Search
			// 
			this.User_Search.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Search.Location = new System.Drawing.Point(659, 81);
			this.User_Search.Name = "User_Search";
			this.User_Search.Size = new System.Drawing.Size(502, 31);
			this.User_Search.TabIndex = 99;
			this.User_Search.TextChanged += new System.EventHandler(this.Business_Search_TextChanged);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(491, 90);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(162, 22);
			this.label8.TabIndex = 98;
			this.label8.Text = "Search By Name";
			// 
			// User_Role
			// 
			this.User_Role.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Role.FormattingEnabled = true;
			this.User_Role.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
			this.User_Role.Location = new System.Drawing.Point(205, 308);
			this.User_Role.Name = "User_Role";
			this.User_Role.Size = new System.Drawing.Size(240, 30);
			this.User_Role.TabIndex = 100;
			// 
			// ManageUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1197, 450);
			this.Controls.Add(this.User_Role);
			this.Controls.Add(this.User_Search);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.User_Username);
			this.Controls.Add(this.User_ID);
			this.Controls.Add(this.User_Name);
			this.Controls.Add(this.Grd_User);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.User_Password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Update_Button);
			this.Name = "ManageUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageUser";
			((System.ComponentModel.ISupportInitialize)(this.Grd_User)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_Button;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_User;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.TextBox User_Username;
        private System.Windows.Forms.TextBox User_Search;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox User_Role;
	}
}