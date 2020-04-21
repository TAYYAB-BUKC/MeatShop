namespace MeatShop
{
	partial class AddUser
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
			this.Save_Button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.User_Role = new System.Windows.Forms.ComboBox();
			this.User_Username = new System.Windows.Forms.TextBox();
			this.User_Name = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.User_Password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Save_Button
			// 
			this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Save_Button.FlatAppearance.BorderSize = 0;
			this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Save_Button.Location = new System.Drawing.Point(463, 251);
			this.Save_Button.Name = "Save_Button";
			this.Save_Button.Size = new System.Drawing.Size(150, 40);
			this.Save_Button.TabIndex = 150;
			this.Save_Button.Text = "Save";
			this.Save_Button.UseVisualStyleBackColor = false;
			this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(27, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1002, 5);
			this.panel2.TabIndex = 142;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 32);
			this.label1.TabIndex = 143;
			this.label1.Text = "Add User";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(28, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1002, 5);
			this.panel1.TabIndex = 141;
			// 
			// User_Role
			// 
			this.User_Role.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Role.FormattingEnabled = true;
			this.User_Role.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
			this.User_Role.Location = new System.Drawing.Point(682, 155);
			this.User_Role.Name = "User_Role";
			this.User_Role.Size = new System.Drawing.Size(240, 30);
			this.User_Role.TabIndex = 171;
			// 
			// User_Username
			// 
			this.User_Username.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Username.Location = new System.Drawing.Point(682, 93);
			this.User_Username.Name = "User_Username";
			this.User_Username.Size = new System.Drawing.Size(240, 31);
			this.User_Username.TabIndex = 170;
			// 
			// User_Name
			// 
			this.User_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Name.Location = new System.Drawing.Point(209, 93);
			this.User_Name.Name = "User_Name";
			this.User_Name.Size = new System.Drawing.Size(240, 31);
			this.User_Name.TabIndex = 169;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(604, 155);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 22);
			this.label10.TabIndex = 168;
			this.label10.Text = "Role";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(90, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 22);
			this.label5.TabIndex = 167;
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
			this.label4.Location = new System.Drawing.Point(552, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 22);
			this.label4.TabIndex = 166;
			this.label4.Text = "Username";
			// 
			// User_Password
			// 
			this.User_Password.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.User_Password.Location = new System.Drawing.Point(209, 152);
			this.User_Password.Name = "User_Password";
			this.User_Password.Size = new System.Drawing.Size(240, 31);
			this.User_Password.TabIndex = 165;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(119, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 22);
			this.label3.TabIndex = 164;
			this.label3.Text = "Name";
			// 
			// AddUser
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1058, 313);
			this.Controls.Add(this.User_Role);
			this.Controls.Add(this.User_Username);
			this.Controls.Add(this.User_Name);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.User_Password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "AddUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Save_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox User_Role;
        private System.Windows.Forms.TextBox User_Username;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User_Password;
        private System.Windows.Forms.Label label3;
    }
}