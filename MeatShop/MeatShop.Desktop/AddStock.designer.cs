namespace MeatShop
{
	partial class AddStock
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
			this.Stock_Price = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Stock_Product = new System.Windows.Forms.ComboBox();
			this.Stock_Quantity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Save_Button
			// 
			this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Save_Button.FlatAppearance.BorderSize = 0;
			this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Save_Button.Location = new System.Drawing.Point(473, 236);
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
			this.panel2.Location = new System.Drawing.Point(29, 208);
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
			this.label1.Size = new System.Drawing.Size(151, 32);
			this.label1.TabIndex = 143;
			this.label1.Text = "Add Stock";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(28, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1002, 5);
			this.panel1.TabIndex = 141;
			// 
			// Stock_Price
			// 
			this.Stock_Price.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Stock_Price.Location = new System.Drawing.Point(656, 91);
			this.Stock_Price.Name = "Stock_Price";
			this.Stock_Price.Size = new System.Drawing.Size(249, 31);
			this.Stock_Price.TabIndex = 161;
			this.Stock_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stock_Price_KeyPress);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(167, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 22);
			this.label5.TabIndex = 154;
			this.label5.Text = "Product";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(587, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 22);
			this.label4.TabIndex = 153;
			this.label4.Text = "Price";
			// 
			// Stock_Product
			// 
			this.Stock_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Stock_Product.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Stock_Product.FormattingEnabled = true;
			this.Stock_Product.Location = new System.Drawing.Point(274, 91);
			this.Stock_Product.Name = "Stock_Product";
			this.Stock_Product.Size = new System.Drawing.Size(252, 30);
			this.Stock_Product.TabIndex = 167;
			this.Stock_Product.SelectedIndexChanged += new System.EventHandler(this.Stock_Product_SelectedIndexChanged);
			// 
			// Stock_Quantity
			// 
			this.Stock_Quantity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Stock_Quantity.Location = new System.Drawing.Point(449, 154);
			this.Stock_Quantity.Name = "Stock_Quantity";
			this.Stock_Quantity.Size = new System.Drawing.Size(249, 31);
			this.Stock_Quantity.TabIndex = 169;
			this.Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stock_Quantity_KeyPress);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(341, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 22);
			this.label2.TabIndex = 168;
			this.label2.Text = "Quantity";
			// 
			// AddStock
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1058, 302);
			this.Controls.Add(this.Stock_Quantity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Stock_Product);
			this.Controls.Add(this.Stock_Price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "AddStock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Product";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Save_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Stock_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Stock_Product;
		private System.Windows.Forms.TextBox Stock_Quantity;
		private System.Windows.Forms.Label label2;
	}
}