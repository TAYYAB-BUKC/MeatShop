namespace MeatShop
{
	partial class ManageCustomer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Grd_Customer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Customer_Name = new System.Windows.Forms.TextBox();
			this.Customer_ID = new System.Windows.Forms.TextBox();
			this.Customer_Search = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.Customer_Balance = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Customer_Phone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Grd_Customer)).BeginInit();
			this.SuspendLayout();
			// 
			// Delete_Button
			// 
			this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Delete_Button.FlatAppearance.BorderSize = 0;
			this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Delete_Button.Location = new System.Drawing.Point(645, 320);
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
			this.panel2.Location = new System.Drawing.Point(26, 298);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1141, 5);
			this.panel2.TabIndex = 74;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(122, 127);
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
			this.label1.Location = new System.Drawing.Point(12, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "Customer Management";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 70);
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
			this.label2.Location = new System.Drawing.Point(66, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 22);
			this.label2.TabIndex = 72;
			this.label2.Text = "Customer ID";
			this.label2.Visible = false;
			// 
			// Update_Button
			// 
			this.Update_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Update_Button.FlatAppearance.BorderSize = 0;
			this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Update_Button.Location = new System.Drawing.Point(457, 320);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(150, 40);
			this.Update_Button.TabIndex = 70;
			this.Update_Button.Text = "Update";
			this.Update_Button.UseVisualStyleBackColor = false;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// Grd_Customer
			// 
			this.Grd_Customer.AllowUserToAddRows = false;
			this.Grd_Customer.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Grd_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_Customer.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Grd_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_Customer.DoubleBuffered = true;
			this.Grd_Customer.EnableHeadersVisualStyles = false;
			this.Grd_Customer.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Customer.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Customer.Location = new System.Drawing.Point(485, 124);
			this.Grd_Customer.Name = "Grd_Customer";
			this.Grd_Customer.ReadOnly = true;
			this.Grd_Customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Customer.Size = new System.Drawing.Size(676, 155);
			this.Grd_Customer.TabIndex = 89;
			this.Grd_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Customer_CellClick);
			// 
			// Customer_Name
			// 
			this.Customer_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_Name.Location = new System.Drawing.Point(212, 124);
			this.Customer_Name.Name = "Customer_Name";
			this.Customer_Name.Size = new System.Drawing.Size(240, 31);
			this.Customer_Name.TabIndex = 90;
			this.Customer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customer_Name_KeyPress);
			// 
			// Customer_ID
			// 
			this.Customer_ID.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_ID.Location = new System.Drawing.Point(212, 81);
			this.Customer_ID.Name = "Customer_ID";
			this.Customer_ID.ReadOnly = true;
			this.Customer_ID.Size = new System.Drawing.Size(240, 31);
			this.Customer_ID.TabIndex = 91;
			this.Customer_ID.Visible = false;
			// 
			// Customer_Search
			// 
			this.Customer_Search.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_Search.Location = new System.Drawing.Point(657, 81);
			this.Customer_Search.Name = "Customer_Search";
			this.Customer_Search.Size = new System.Drawing.Size(502, 31);
			this.Customer_Search.TabIndex = 99;
			this.Customer_Search.TextChanged += new System.EventHandler(this.Customer_Search_TextChanged);
			this.Customer_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customer_Search_KeyPress);
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
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(0, 2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(25, 25);
			this.button5.TabIndex = 100;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Customer_Balance
			// 
			this.Customer_Balance.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_Balance.Location = new System.Drawing.Point(212, 226);
			this.Customer_Balance.Name = "Customer_Balance";
			this.Customer_Balance.Size = new System.Drawing.Size(240, 31);
			this.Customer_Balance.TabIndex = 102;
			this.Customer_Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customer_Phone_KeyPress);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(102, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 22);
			this.label4.TabIndex = 101;
			this.label4.Text = "Balance";
			// 
			// Customer_Phone
			// 
			this.Customer_Phone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_Phone.Location = new System.Drawing.Point(212, 177);
			this.Customer_Phone.MaxLength = 11;
			this.Customer_Phone.Name = "Customer_Phone";
			this.Customer_Phone.Size = new System.Drawing.Size(240, 31);
			this.Customer_Phone.TabIndex = 104;
			this.Customer_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customer_Phone_KeyPress);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(122, 180);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 22);
			this.label5.TabIndex = 103;
			this.label5.Text = "Phone";
			// 
			// ManageCustomer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1197, 381);
			this.Controls.Add(this.Customer_Phone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Customer_Balance);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Customer_Search);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Customer_ID);
			this.Controls.Add(this.Customer_Name);
			this.Controls.Add(this.Grd_Customer);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Update_Button);
			this.Name = "ManageCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Management";
			((System.ComponentModel.ISupportInitialize)(this.Grd_Customer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Update_Button;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Customer;
		private System.Windows.Forms.TextBox Customer_Name;
		private System.Windows.Forms.TextBox Customer_ID;
		private System.Windows.Forms.TextBox Customer_Search;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox Customer_Balance;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Customer_Phone;
		private System.Windows.Forms.Label label5;
	}
}