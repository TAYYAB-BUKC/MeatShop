namespace MeatShop
{
	partial class ManageProduct
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Grd_Product = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Product_Name = new System.Windows.Forms.TextBox();
			this.Product_ID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Product_Price = new System.Windows.Forms.TextBox();
			this.Product_Search = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Product_Image = new System.Windows.Forms.PictureBox();
			this.Browse_Button = new System.Windows.Forms.Button();
			this.Product_Unit = new System.Windows.Forms.ComboBox();
			this.Product_Category = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Grd_Product)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Product_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// Delete_Button
			// 
			this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Delete_Button.FlatAppearance.BorderSize = 0;
			this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Delete_Button.Location = new System.Drawing.Point(691, 559);
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
			this.panel2.Location = new System.Drawing.Point(22, 527);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1117, 5);
			this.panel2.TabIndex = 74;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(124, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 22);
			this.label4.TabIndex = 78;
			this.label4.Text = "Price";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(112, 154);
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
			this.label1.Size = new System.Drawing.Size(300, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "Product Management";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 60);
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
			this.label2.Location = new System.Drawing.Point(74, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 22);
			this.label2.TabIndex = 72;
			this.label2.Text = "Product ID";
			// 
			// Update_Button
			// 
			this.Update_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Update_Button.FlatAppearance.BorderSize = 0;
			this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Update_Button.Location = new System.Drawing.Point(503, 559);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(150, 40);
			this.Update_Button.TabIndex = 70;
			this.Update_Button.Text = "Update";
			this.Update_Button.UseVisualStyleBackColor = false;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// Grd_Product
			// 
			this.Grd_Product.AllowUserToAddRows = false;
			this.Grd_Product.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Grd_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_Product.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Grd_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_Product.DoubleBuffered = true;
			this.Grd_Product.EnableHeadersVisualStyles = false;
			this.Grd_Product.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Product.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Product.Location = new System.Drawing.Point(485, 124);
			this.Grd_Product.Name = "Grd_Product";
			this.Grd_Product.ReadOnly = true;
			this.Grd_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Product.Size = new System.Drawing.Size(676, 378);
			this.Grd_Product.TabIndex = 89;
			this.Grd_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Product_CellClick);
			// 
			// Product_Name
			// 
			this.Product_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Product_Name.Location = new System.Drawing.Point(205, 151);
			this.Product_Name.Name = "Product_Name";
			this.Product_Name.Size = new System.Drawing.Size(240, 31);
			this.Product_Name.TabIndex = 90;
			// 
			// Product_ID
			// 
			this.Product_ID.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Product_ID.Location = new System.Drawing.Point(205, 99);
			this.Product_ID.Name = "Product_ID";
			this.Product_ID.ReadOnly = true;
			this.Product_ID.Size = new System.Drawing.Size(240, 31);
			this.Product_ID.TabIndex = 91;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(134, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 22);
			this.label6.TabIndex = 93;
			this.label6.Text = "Unit";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(85, 253);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 22);
			this.label7.TabIndex = 92;
			this.label7.Text = "Category";
			// 
			// Product_Price
			// 
			this.Product_Price.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Product_Price.Location = new System.Drawing.Point(205, 204);
			this.Product_Price.Name = "Product_Price";
			this.Product_Price.Size = new System.Drawing.Size(240, 31);
			this.Product_Price.TabIndex = 96;
			// 
			// Product_Search
			// 
			this.Product_Search.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Product_Search.Location = new System.Drawing.Point(659, 81);
			this.Product_Search.Name = "Product_Search";
			this.Product_Search.Size = new System.Drawing.Size(502, 31);
			this.Product_Search.TabIndex = 99;
			this.Product_Search.TextChanged += new System.EventHandler(this.Product_Search_TextChanged);
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
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(111, 362);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 22);
			this.label9.TabIndex = 100;
			this.label9.Text = "Image";
			// 
			// Product_Image
			// 
			this.Product_Image.Location = new System.Drawing.Point(202, 362);
			this.Product_Image.Name = "Product_Image";
			this.Product_Image.Size = new System.Drawing.Size(243, 140);
			this.Product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Product_Image.TabIndex = 101;
			this.Product_Image.TabStop = false;
			// 
			// Browse_Button
			// 
			this.Browse_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Browse_Button.FlatAppearance.BorderSize = 0;
			this.Browse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Browse_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Browse_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Browse_Button.Location = new System.Drawing.Point(31, 405);
			this.Browse_Button.Name = "Browse_Button";
			this.Browse_Button.Size = new System.Drawing.Size(150, 40);
			this.Browse_Button.TabIndex = 102;
			this.Browse_Button.Text = "Browse Image";
			this.Browse_Button.UseVisualStyleBackColor = false;
			this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
			// 
			// Product_Unit
			// 
			this.Product_Unit.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Product_Unit.FormattingEnabled = true;
			this.Product_Unit.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
			this.Product_Unit.Location = new System.Drawing.Point(205, 301);
			this.Product_Unit.Name = "Product_Unit";
			this.Product_Unit.Size = new System.Drawing.Size(240, 30);
			this.Product_Unit.TabIndex = 170;
			// 
			// Product_Category
			// 
			this.Product_Category.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Product_Category.FormattingEnabled = true;
			this.Product_Category.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
			this.Product_Category.Location = new System.Drawing.Point(205, 250);
			this.Product_Category.Name = "Product_Category";
			this.Product_Category.Size = new System.Drawing.Size(240, 30);
			this.Product_Category.TabIndex = 169;
			// 
			// ManageProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1197, 622);
			this.Controls.Add(this.Product_Unit);
			this.Controls.Add(this.Product_Category);
			this.Controls.Add(this.Browse_Button);
			this.Controls.Add(this.Product_Image);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Product_Search);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Product_Price);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Product_ID);
			this.Controls.Add(this.Product_Name);
			this.Controls.Add(this.Grd_Product);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Update_Button);
			this.Name = "ManageProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product Management";
			((System.ComponentModel.ISupportInitialize)(this.Grd_Product)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Product_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Update_Button;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Product;
		private System.Windows.Forms.TextBox Product_Name;
		private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Product_Price;
        private System.Windows.Forms.TextBox Product_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Product_Image;
        private System.Windows.Forms.Button Browse_Button;
		private System.Windows.Forms.ComboBox Product_Unit;
		private System.Windows.Forms.ComboBox Product_Category;
	}
}