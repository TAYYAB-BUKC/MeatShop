namespace MeatShop
{
	partial class Sales
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
			this.Sale_Button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.LDate = new System.Windows.Forms.Label();
			this.LAmount = new System.Windows.Forms.Label();
			this.LName = new System.Windows.Forms.Label();
			this.LTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Grd_Sale = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Decrease = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Sale_Discount = new System.Windows.Forms.TextBox();
			this.Sale_TotalAmount = new System.Windows.Forms.TextBox();
			this.Sale_PaidAmount = new System.Windows.Forms.TextBox();
			this.Sale_Balance = new System.Windows.Forms.TextBox();
			this.LBoughtItems = new System.Windows.Forms.Label();
			this.Sale_Customer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Grd_Sale)).BeginInit();
			this.SuspendLayout();
			// 
			// Sale_Button
			// 
			this.Sale_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Sale_Button.FlatAppearance.BorderSize = 0;
			this.Sale_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sale_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sale_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Sale_Button.Location = new System.Drawing.Point(520, 688);
			this.Sale_Button.Name = "Sale_Button";
			this.Sale_Button.Size = new System.Drawing.Size(150, 40);
			this.Sale_Button.TabIndex = 82;
			this.Sale_Button.Text = "Sale";
			this.Sale_Button.UseVisualStyleBackColor = false;
			this.Sale_Button.Click += new System.EventHandler(this.Sale_Button_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(27, 663);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1117, 5);
			this.panel2.TabIndex = 74;
			// 
			// LDate
			// 
			this.LDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LDate.AutoSize = true;
			this.LDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LDate.ForeColor = System.Drawing.Color.White;
			this.LDate.Location = new System.Drawing.Point(706, 614);
			this.LDate.Name = "LDate";
			this.LDate.Size = new System.Drawing.Size(86, 22);
			this.LDate.TabIndex = 80;
			this.LDate.Text = "Balance";
			// 
			// LAmount
			// 
			this.LAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LAmount.AutoSize = true;
			this.LAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LAmount.ForeColor = System.Drawing.Color.White;
			this.LAmount.Location = new System.Drawing.Point(665, 564);
			this.LAmount.Name = "LAmount";
			this.LAmount.Size = new System.Drawing.Size(130, 22);
			this.LAmount.TabIndex = 78;
			this.LAmount.Text = "Paid Amount";
			// 
			// LName
			// 
			this.LName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LName.AutoSize = true;
			this.LName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LName.ForeColor = System.Drawing.Color.White;
			this.LName.Location = new System.Drawing.Point(703, 511);
			this.LName.Name = "LName";
			this.LName.Size = new System.Drawing.Size(89, 22);
			this.LName.TabIndex = 76;
			this.LName.Text = "Discount";
			// 
			// LTitle
			// 
			this.LTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LTitle.AutoSize = true;
			this.LTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LTitle.ForeColor = System.Drawing.Color.White;
			this.LTitle.Location = new System.Drawing.Point(10, 9);
			this.LTitle.Name = "LTitle";
			this.LTitle.Size = new System.Drawing.Size(134, 32);
			this.LTitle.TabIndex = 75;
			this.LTitle.Text = "Add Sale";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(14, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1118, 5);
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
			this.label2.Location = new System.Drawing.Point(659, 459);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 22);
			this.label2.TabIndex = 72;
			this.label2.Text = "Total Amount";
			// 
			// Grd_Sale
			// 
			this.Grd_Sale.AllowUserToAddRows = false;
			this.Grd_Sale.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_Sale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Grd_Sale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Grd_Sale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_Sale.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_Sale.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_Sale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Grd_Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_Sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Update,
            this.Decrease,
            this.Delete});
			this.Grd_Sale.DoubleBuffered = true;
			this.Grd_Sale.EnableHeadersVisualStyles = false;
			this.Grd_Sale.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Sale.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Sale.Location = new System.Drawing.Point(656, 135);
			this.Grd_Sale.Name = "Grd_Sale";
			this.Grd_Sale.ReadOnly = true;
			this.Grd_Sale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Sale.Size = new System.Drawing.Size(576, 297);
			this.Grd_Sale.TabIndex = 89;
			this.Grd_Sale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Sale_CellContentClick);
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			// 
			// Update
			// 
			this.Update.HeaderText = "Increase Quantity";
			this.Update.Name = "Update";
			this.Update.ReadOnly = true;
			this.Update.Text = "Increase";
			this.Update.UseColumnTextForButtonValue = true;
			// 
			// Decrease
			// 
			this.Decrease.HeaderText = "Decrease Quantity";
			this.Decrease.Name = "Decrease";
			this.Decrease.ReadOnly = true;
			this.Decrease.Text = "Decrease";
			this.Decrease.UseColumnTextForButtonValue = true;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Text = "Remove item";
			this.Delete.ToolTipText = "Remove item";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// Sale_Discount
			// 
			this.Sale_Discount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_Discount.Location = new System.Drawing.Point(801, 508);
			this.Sale_Discount.Name = "Sale_Discount";
			this.Sale_Discount.Size = new System.Drawing.Size(240, 31);
			this.Sale_Discount.TabIndex = 90;
			this.Sale_Discount.Leave += new System.EventHandler(this.Sale_Discount_Leave);
			// 
			// Sale_TotalAmount
			// 
			this.Sale_TotalAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_TotalAmount.Location = new System.Drawing.Point(801, 456);
			this.Sale_TotalAmount.Name = "Sale_TotalAmount";
			this.Sale_TotalAmount.ReadOnly = true;
			this.Sale_TotalAmount.Size = new System.Drawing.Size(240, 31);
			this.Sale_TotalAmount.TabIndex = 91;
			this.Sale_TotalAmount.Text = "0";
			// 
			// Sale_PaidAmount
			// 
			this.Sale_PaidAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_PaidAmount.Location = new System.Drawing.Point(801, 561);
			this.Sale_PaidAmount.Name = "Sale_PaidAmount";
			this.Sale_PaidAmount.Size = new System.Drawing.Size(240, 31);
			this.Sale_PaidAmount.TabIndex = 96;
			this.Sale_PaidAmount.Leave += new System.EventHandler(this.Sale_PaidAmount_Leave);
			// 
			// Sale_Balance
			// 
			this.Sale_Balance.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_Balance.Location = new System.Drawing.Point(801, 611);
			this.Sale_Balance.Name = "Sale_Balance";
			this.Sale_Balance.ReadOnly = true;
			this.Sale_Balance.Size = new System.Drawing.Size(240, 31);
			this.Sale_Balance.TabIndex = 97;
			// 
			// LBoughtItems
			// 
			this.LBoughtItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LBoughtItems.AutoSize = true;
			this.LBoughtItems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBoughtItems.ForeColor = System.Drawing.Color.White;
			this.LBoughtItems.Location = new System.Drawing.Point(652, 101);
			this.LBoughtItems.Name = "LBoughtItems";
			this.LBoughtItems.Size = new System.Drawing.Size(130, 22);
			this.LBoughtItems.TabIndex = 98;
			this.LBoughtItems.Text = "Bought Items";
			// 
			// Sale_Customer
			// 
			this.Sale_Customer.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_Customer.FormattingEnabled = true;
			this.Sale_Customer.Location = new System.Drawing.Point(127, 69);
			this.Sale_Customer.Name = "Sale_Customer";
			this.Sale_Customer.Size = new System.Drawing.Size(251, 30);
			this.Sale_Customer.TabIndex = 170;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 22);
			this.label1.TabIndex = 171;
			this.label1.Text = "Customer";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(261, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 22);
			this.label4.TabIndex = 174;
			this.label4.Text = "Products";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 22);
			this.label3.TabIndex = 176;
			this.label3.Text = "Categories";
			// 
			// Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1244, 741);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Sale_Customer);
			this.Controls.Add(this.LBoughtItems);
			this.Controls.Add(this.Sale_Balance);
			this.Controls.Add(this.Sale_PaidAmount);
			this.Controls.Add(this.Sale_TotalAmount);
			this.Controls.Add(this.Sale_Discount);
			this.Controls.Add(this.Grd_Sale);
			this.Controls.Add(this.Sale_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.LDate);
			this.Controls.Add(this.LAmount);
			this.Controls.Add(this.LName);
			this.Controls.Add(this.LTitle);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Name = "Sales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Sale";
			((System.ComponentModel.ISupportInitialize)(this.Grd_Sale)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Sale_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label LDate;
		private System.Windows.Forms.Label LAmount;
		private System.Windows.Forms.Label LName;
		private System.Windows.Forms.Label LTitle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Sale;
		private System.Windows.Forms.TextBox Sale_Discount;
		private System.Windows.Forms.TextBox Sale_TotalAmount;
        private System.Windows.Forms.TextBox Sale_PaidAmount;
		private System.Windows.Forms.TextBox Sale_Balance;
		private System.Windows.Forms.Label LBoughtItems;
		private System.Windows.Forms.ComboBox Sale_Customer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewButtonColumn Update;
		private System.Windows.Forms.DataGridViewButtonColumn Decrease;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}