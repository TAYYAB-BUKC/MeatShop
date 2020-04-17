namespace MeatShop
{
	partial class NewCustomer
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.Customer_Name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Save_Button = new System.Windows.Forms.Button();
			this.Customer_Phone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(29, 246);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(907, 5);
			this.panel2.TabIndex = 69;
			// 
			// Customer_Name
			// 
			this.Customer_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_Name.Location = new System.Drawing.Point(136, 128);
			this.Customer_Name.Name = "Customer_Name";
			this.Customer_Name.Size = new System.Drawing.Size(293, 31);
			this.Customer_Name.TabIndex = 71;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 32);
			this.label1.TabIndex = 70;
			this.label1.Text = "Add Customer";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(30, 89);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(907, 5);
			this.panel1.TabIndex = 68;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(64, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 22);
			this.label2.TabIndex = 67;
			this.label2.Text = "Name";
			// 
			// Save_Button
			// 
			this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Save_Button.FlatAppearance.BorderSize = 0;
			this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Save_Button.Location = new System.Drawing.Point(209, 273);
			this.Save_Button.Name = "Save_Button";
			this.Save_Button.Size = new System.Drawing.Size(150, 40);
			this.Save_Button.TabIndex = 81;
			this.Save_Button.Text = "Save";
			this.Save_Button.UseVisualStyleBackColor = false;
			this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
			// 
			// Customer_Phone
			// 
			this.Customer_Phone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Customer_Phone.Location = new System.Drawing.Point(136, 183);
			this.Customer_Phone.Name = "Customer_Phone";
			this.Customer_Phone.Size = new System.Drawing.Size(293, 31);
			this.Customer_Phone.TabIndex = 83;
			this.Customer_Phone.Click += new System.EventHandler(this.Customer_Phone_Click);
			this.Customer_Phone.Leave += new System.EventHandler(this.Customer_Phone_Leave);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(61, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 22);
			this.label3.TabIndex = 82;
			this.label3.Text = "Phone";
			// 
			// NewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(485, 333);
			this.Controls.Add(this.Customer_Phone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Customer_Name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Name = "NewCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Customer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox Customer_Name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Save_Button;
		private System.Windows.Forms.TextBox Customer_Phone;
		private System.Windows.Forms.Label label3;
	}
}