namespace MeatShop
{
    partial class DailySalesReport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TotalAvailable = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TotalStock = new System.Windows.Forms.Label();
			this.Grd_DailySales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.TotalSale = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Grd_DailySales)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(12, 740);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1069, 5);
			this.panel2.TabIndex = 74;
			// 
			// TotalAvailable
			// 
			this.TotalAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TotalAvailable.AutoSize = true;
			this.TotalAvailable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalAvailable.ForeColor = System.Drawing.Color.White;
			this.TotalAvailable.Location = new System.Drawing.Point(732, 93);
			this.TotalAvailable.Name = "TotalAvailable";
			this.TotalAvailable.Size = new System.Drawing.Size(0, 22);
			this.TotalAvailable.TabIndex = 76;
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
			this.label1.Size = new System.Drawing.Size(188, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "Today\'s Sales";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(26, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1070, 5);
			this.panel1.TabIndex = 73;
			// 
			// TotalStock
			// 
			this.TotalStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TotalStock.AutoSize = true;
			this.TotalStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalStock.ForeColor = System.Drawing.Color.White;
			this.TotalStock.Location = new System.Drawing.Point(410, 93);
			this.TotalStock.Name = "TotalStock";
			this.TotalStock.Size = new System.Drawing.Size(0, 22);
			this.TotalStock.TabIndex = 72;
			// 
			// Grd_DailySales
			// 
			this.Grd_DailySales.AllowUserToAddRows = false;
			this.Grd_DailySales.AllowUserToDeleteRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_DailySales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.Grd_DailySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_DailySales.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_DailySales.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_DailySales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_DailySales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.Grd_DailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_DailySales.DoubleBuffered = true;
			this.Grd_DailySales.EnableHeadersVisualStyles = false;
			this.Grd_DailySales.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_DailySales.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_DailySales.Location = new System.Drawing.Point(46, 141);
			this.Grd_DailySales.Name = "Grd_DailySales";
			this.Grd_DailySales.ReadOnly = true;
			this.Grd_DailySales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_DailySales.Size = new System.Drawing.Size(1016, 593);
			this.Grd_DailySales.TabIndex = 89;
			// 
			// TotalSale
			// 
			this.TotalSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TotalSale.AutoSize = true;
			this.TotalSale.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalSale.ForeColor = System.Drawing.Color.White;
			this.TotalSale.Location = new System.Drawing.Point(42, 93);
			this.TotalSale.Name = "TotalSale";
			this.TotalSale.Size = new System.Drawing.Size(0, 22);
			this.TotalSale.TabIndex = 98;
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
			// DailySalesReport
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1096, 777);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.TotalSale);
			this.Controls.Add(this.Grd_DailySales);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.TotalAvailable);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TotalStock);
			this.Name = "DailySalesReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Today\'s Sales";
			this.Load += new System.EventHandler(this.DailySalesReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grd_DailySales)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalStock;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_DailySales;
        private System.Windows.Forms.Label TotalSale;
		private System.Windows.Forms.Button button5;
	}
}