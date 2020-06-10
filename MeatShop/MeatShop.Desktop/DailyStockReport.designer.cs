namespace MeatShop
{
	partial class DailyStockReport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.Grd_Stock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Stock_Date = new Bunifu.Framework.UI.BunifuDatepicker();
			this.All_Expenses_Button = new System.Windows.Forms.Button();
			this.TodayExpenses_Button = new System.Windows.Forms.Button();
			this.RandomExpenses_Button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Grd_Stock)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(26, 760);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1069, 5);
			this.panel2.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "Stock Report";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(26, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1070, 5);
			this.panel1.TabIndex = 73;
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(-2, -3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(23, 25);
			this.button5.TabIndex = 99;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Grd_Stock
			// 
			this.Grd_Stock.AllowUserToAddRows = false;
			this.Grd_Stock.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_Stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.Grd_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_Stock.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_Stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.Grd_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_Stock.DoubleBuffered = true;
			this.Grd_Stock.EnableHeadersVisualStyles = false;
			this.Grd_Stock.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Stock.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Stock.Location = new System.Drawing.Point(46, 139);
			this.Grd_Stock.Name = "Grd_Stock";
			this.Grd_Stock.ReadOnly = true;
			this.Grd_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Stock.Size = new System.Drawing.Size(1016, 607);
			this.Grd_Stock.TabIndex = 89;
			// 
			// Stock_Date
			// 
			this.Stock_Date.BackColor = System.Drawing.Color.White;
			this.Stock_Date.BorderRadius = 0;
			this.Stock_Date.Font = new System.Drawing.Font("Century Gothic", 6F);
			this.Stock_Date.ForeColor = System.Drawing.Color.Black;
			this.Stock_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.Stock_Date.FormatCustom = null;
			this.Stock_Date.Location = new System.Drawing.Point(657, 84);
			this.Stock_Date.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Stock_Date.Name = "Stock_Date";
			this.Stock_Date.Size = new System.Drawing.Size(252, 31);
			this.Stock_Date.TabIndex = 164;
			this.Stock_Date.Value = new System.DateTime(2019, 12, 30, 19, 3, 42, 85);
			// 
			// All_Expenses_Button
			// 
			this.All_Expenses_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.All_Expenses_Button.FlatAppearance.BorderSize = 0;
			this.All_Expenses_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.All_Expenses_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.All_Expenses_Button.ForeColor = System.Drawing.Color.LightGray;
			this.All_Expenses_Button.Location = new System.Drawing.Point(46, 79);
			this.All_Expenses_Button.Name = "All_Expenses_Button";
			this.All_Expenses_Button.Size = new System.Drawing.Size(274, 40);
			this.All_Expenses_Button.TabIndex = 165;
			this.All_Expenses_Button.Text = "All Stock";
			this.All_Expenses_Button.UseVisualStyleBackColor = false;
			this.All_Expenses_Button.Click += new System.EventHandler(this.All_Expenses_Button_Click);
			// 
			// TodayExpenses_Button
			// 
			this.TodayExpenses_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.TodayExpenses_Button.FlatAppearance.BorderSize = 0;
			this.TodayExpenses_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TodayExpenses_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TodayExpenses_Button.ForeColor = System.Drawing.Color.LightGray;
			this.TodayExpenses_Button.Location = new System.Drawing.Point(350, 79);
			this.TodayExpenses_Button.Name = "TodayExpenses_Button";
			this.TodayExpenses_Button.Size = new System.Drawing.Size(274, 40);
			this.TodayExpenses_Button.TabIndex = 166;
			this.TodayExpenses_Button.Text = "Today\'s Stock";
			this.TodayExpenses_Button.UseVisualStyleBackColor = false;
			this.TodayExpenses_Button.Click += new System.EventHandler(this.TodayExpenses_Button_Click);
			// 
			// RandomExpenses_Button
			// 
			this.RandomExpenses_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.RandomExpenses_Button.FlatAppearance.BorderSize = 0;
			this.RandomExpenses_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RandomExpenses_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RandomExpenses_Button.ForeColor = System.Drawing.Color.LightGray;
			this.RandomExpenses_Button.Location = new System.Drawing.Point(918, 84);
			this.RandomExpenses_Button.Name = "RandomExpenses_Button";
			this.RandomExpenses_Button.Size = new System.Drawing.Size(130, 31);
			this.RandomExpenses_Button.TabIndex = 167;
			this.RandomExpenses_Button.Text = "Fetch Stock";
			this.RandomExpenses_Button.UseVisualStyleBackColor = false;
			this.RandomExpenses_Button.Click += new System.EventHandler(this.RandomExpenses_Button_Click);
			// 
			// DailyStockReport
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1096, 777);
			this.Controls.Add(this.Grd_Stock);
			this.Controls.Add(this.RandomExpenses_Button);
			this.Controls.Add(this.TodayExpenses_Button);
			this.Controls.Add(this.All_Expenses_Button);
			this.Controls.Add(this.Stock_Date);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "DailyStockReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stock Report";
			((System.ComponentModel.ISupportInitialize)(this.Grd_Stock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button5;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Stock;
		private Bunifu.Framework.UI.BunifuDatepicker Stock_Date;
		private System.Windows.Forms.Button All_Expenses_Button;
		private System.Windows.Forms.Button TodayExpenses_Button;
		private System.Windows.Forms.Button RandomExpenses_Button;
	}
}