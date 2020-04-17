namespace MeatShop
{
	partial class Login
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label1 = new System.Windows.Forms.Label();
			this.Login_Button = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(329, 333);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(64, 35);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 124;
			this.pictureBox3.TabStop = false;
			// 
			// Password
			// 
			this.Password.BackColor = System.Drawing.SystemColors.Window;
			this.Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(118)))), ((int)(((byte)(223)))));
			this.Password.BorderColorIdle = System.Drawing.Color.White;
			this.Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(118)))), ((int)(((byte)(223)))));
			this.Password.BorderThickness = 3;
			this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.Password.ForeColor = System.Drawing.Color.Black;
			this.Password.isPassword = true;
			this.Password.Location = new System.Drawing.Point(177, 465);
			this.Password.Margin = new System.Windows.Forms.Padding(4);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(369, 40);
			this.Password.TabIndex = 121;
			this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Password.Click += new System.EventHandler(this.Password_Click);
			this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
			// 
			// Username
			// 
			this.Username.BackColor = System.Drawing.SystemColors.Window;
			this.Username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(118)))), ((int)(((byte)(223)))));
			this.Username.BorderColorIdle = System.Drawing.Color.White;
			this.Username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(118)))), ((int)(((byte)(223)))));
			this.Username.BorderThickness = 3;
			this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.Username.ForeColor = System.Drawing.Color.Black;
			this.Username.isPassword = false;
			this.Username.Location = new System.Drawing.Point(177, 375);
			this.Username.Margin = new System.Windows.Forms.Padding(4);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(369, 40);
			this.Username.TabIndex = 120;
			this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Username.Click += new System.EventHandler(this.Email_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(314, 294);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 32);
			this.label1.TabIndex = 118;
			this.label1.Text = "Log In";
			// 
			// Login_Button
			// 
			this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Login_Button.FlatAppearance.BorderSize = 0;
			this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Login_Button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Login_Button.Location = new System.Drawing.Point(287, 542);
			this.Login_Button.Name = "Login_Button";
			this.Login_Button.Size = new System.Drawing.Size(150, 40);
			this.Login_Button.TabIndex = 117;
			this.Login_Button.Text = "Log In";
			this.Login_Button.UseVisualStyleBackColor = false;
			this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(70, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(590, 295);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 119;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(337, 422);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.TabIndex = 123;
			this.pictureBox2.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(715, 600);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Login_Button);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox3;
		private Bunifu.Framework.UI.BunifuMetroTextbox Password;
		private Bunifu.Framework.UI.BunifuMetroTextbox Username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Login_Button;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Timer timer1;
	}
}