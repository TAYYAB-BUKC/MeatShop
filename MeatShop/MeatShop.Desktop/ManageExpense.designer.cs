namespace MeatShop
{
	partial class ManageExpense
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
			this.label10 = new System.Windows.Forms.Label();
			this.Expense_Comment = new System.Windows.Forms.TextBox();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Grd_Expense = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Expense_Name = new System.Windows.Forms.TextBox();
			this.Expense_ID = new System.Windows.Forms.TextBox();
			this.Expense_Amount = new System.Windows.Forms.TextBox();
			this.Expense_Search = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Expense_Date = new Bunifu.Framework.UI.BunifuDatepicker();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Grd_Expense)).BeginInit();
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
			this.label10.Location = new System.Drawing.Point(79, 328);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 22);
			this.label10.TabIndex = 85;
			this.label10.Text = "Comment";
			// 
			// Expense_Comment
			// 
			this.Expense_Comment.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Comment.Location = new System.Drawing.Point(205, 316);
			this.Expense_Comment.Multiline = true;
			this.Expense_Comment.Name = "Expense_Comment";
			this.Expense_Comment.Size = new System.Drawing.Size(240, 95);
			this.Expense_Comment.TabIndex = 84;
			this.Expense_Comment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Comment_KeyPress);
			// 
			// Delete_Button
			// 
			this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Delete_Button.FlatAppearance.BorderSize = 0;
			this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Delete_Button.Location = new System.Drawing.Point(503, 459);
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
			this.panel2.Location = new System.Drawing.Point(30, 439);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1117, 5);
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
			this.label5.Location = new System.Drawing.Point(125, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 22);
			this.label5.TabIndex = 80;
			this.label5.Text = "Date";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(96, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 22);
			this.label4.TabIndex = 78;
			this.label4.Text = "Amount";
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
			this.label1.Location = new System.Drawing.Point(12, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(309, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "Expense Management";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 70);
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
			this.label2.Location = new System.Drawing.Point(72, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 22);
			this.label2.TabIndex = 72;
			this.label2.Text = "Expense ID";
			// 
			// Grd_Expense
			// 
			this.Grd_Expense.AllowUserToAddRows = false;
			this.Grd_Expense.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_Expense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.Grd_Expense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_Expense.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_Expense.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_Expense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_Expense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.Grd_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_Expense.DoubleBuffered = true;
			this.Grd_Expense.EnableHeadersVisualStyles = false;
			this.Grd_Expense.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Expense.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Expense.Location = new System.Drawing.Point(485, 124);
			this.Grd_Expense.Name = "Grd_Expense";
			this.Grd_Expense.ReadOnly = true;
			this.Grd_Expense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Expense.Size = new System.Drawing.Size(676, 287);
			this.Grd_Expense.TabIndex = 89;
			this.Grd_Expense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Expense_CellClick);
			// 
			// Expense_Name
			// 
			this.Expense_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Name.Location = new System.Drawing.Point(205, 151);
			this.Expense_Name.Name = "Expense_Name";
			this.Expense_Name.Size = new System.Drawing.Size(240, 31);
			this.Expense_Name.TabIndex = 90;
			this.Expense_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Name_KeyPress);
			// 
			// Expense_ID
			// 
			this.Expense_ID.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_ID.Location = new System.Drawing.Point(205, 99);
			this.Expense_ID.Name = "Expense_ID";
			this.Expense_ID.ReadOnly = true;
			this.Expense_ID.Size = new System.Drawing.Size(240, 31);
			this.Expense_ID.TabIndex = 91;
			// 
			// Expense_Amount
			// 
			this.Expense_Amount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Amount.Location = new System.Drawing.Point(205, 204);
			this.Expense_Amount.Name = "Expense_Amount";
			this.Expense_Amount.Size = new System.Drawing.Size(240, 31);
			this.Expense_Amount.TabIndex = 96;
			this.Expense_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Amount_KeyPress);
			// 
			// Expense_Search
			// 
			this.Expense_Search.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Search.Location = new System.Drawing.Point(659, 81);
			this.Expense_Search.Name = "Expense_Search";
			this.Expense_Search.Size = new System.Drawing.Size(502, 31);
			this.Expense_Search.TabIndex = 99;
			this.Expense_Search.TextChanged += new System.EventHandler(this.Expense_Search_TextChanged);
			this.Expense_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Search_KeyPress);
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
			// Expense_Date
			// 
			this.Expense_Date.BackColor = System.Drawing.Color.White;
			this.Expense_Date.BorderRadius = 0;
			this.Expense_Date.Font = new System.Drawing.Font("Century Gothic", 6F);
			this.Expense_Date.ForeColor = System.Drawing.Color.Black;
			this.Expense_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.Expense_Date.FormatCustom = null;
			this.Expense_Date.Location = new System.Drawing.Point(205, 257);
			this.Expense_Date.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Expense_Date.Name = "Expense_Date";
			this.Expense_Date.Size = new System.Drawing.Size(240, 31);
			this.Expense_Date.TabIndex = 164;
			this.Expense_Date.Value = new System.DateTime(2019, 12, 30, 19, 3, 42, 85);
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(1, 2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(25, 25);
			this.button5.TabIndex = 165;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// ManageExpense
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1197, 516);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Expense_Date);
			this.Controls.Add(this.Expense_Search);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Expense_Amount);
			this.Controls.Add(this.Expense_ID);
			this.Controls.Add(this.Expense_Name);
			this.Controls.Add(this.Grd_Expense);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Expense_Comment);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Name = "ManageExpense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Expense Management";
			((System.ComponentModel.ISupportInitialize)(this.Grd_Expense)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Expense_Comment;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Expense;
		private System.Windows.Forms.TextBox Expense_Name;
		private System.Windows.Forms.TextBox Expense_ID;
        private System.Windows.Forms.TextBox Expense_Amount;
        private System.Windows.Forms.TextBox Expense_Search;
        private System.Windows.Forms.Label label8;
		private Bunifu.Framework.UI.BunifuDatepicker Expense_Date;
		private System.Windows.Forms.Button button5;
	}
}