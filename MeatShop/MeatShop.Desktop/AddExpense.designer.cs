namespace MeatShop
{
	partial class AddExpense
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
			this.Expense_Amount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Expense_Name = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Expense_Comment = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Expense_Date = new Bunifu.Framework.UI.BunifuDatepicker();
			this.SuspendLayout();
			// 
			// Save_Button
			// 
			this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Save_Button.FlatAppearance.BorderSize = 0;
			this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Save_Button.Location = new System.Drawing.Point(470, 260);
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
			this.panel2.Location = new System.Drawing.Point(21, 238);
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
			this.label1.Size = new System.Drawing.Size(188, 32);
			this.label1.TabIndex = 143;
			this.label1.Text = "Add Expense";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(28, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1002, 5);
			this.panel1.TabIndex = 141;
			// 
			// Expense_Amount
			// 
			this.Expense_Amount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Amount.Location = new System.Drawing.Point(251, 145);
			this.Expense_Amount.Name = "Expense_Amount";
			this.Expense_Amount.Size = new System.Drawing.Size(252, 31);
			this.Expense_Amount.TabIndex = 161;
			this.Expense_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Amount_KeyPress);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(171, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 22);
			this.label6.TabIndex = 159;
			this.label6.Text = "Date";
			// 
			// Expense_Name
			// 
			this.Expense_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Name.Location = new System.Drawing.Point(251, 91);
			this.Expense_Name.Name = "Expense_Name";
			this.Expense_Name.Size = new System.Drawing.Size(252, 31);
			this.Expense_Name.TabIndex = 157;
			this.Expense_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Name_KeyPress);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(530, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 22);
			this.label10.TabIndex = 156;
			this.label10.Text = "Comment";
			// 
			// Expense_Comment
			// 
			this.Expense_Comment.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Expense_Comment.Location = new System.Drawing.Point(649, 91);
			this.Expense_Comment.Multiline = true;
			this.Expense_Comment.Name = "Expense_Comment";
			this.Expense_Comment.Size = new System.Drawing.Size(255, 136);
			this.Expense_Comment.TabIndex = 155;
			this.Expense_Comment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Expense_Comment_KeyPress);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(147, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 22);
			this.label4.TabIndex = 153;
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
			this.label3.Location = new System.Drawing.Point(161, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 22);
			this.label3.TabIndex = 151;
			this.label3.Text = "Name";
			// 
			// Expense_Date
			// 
			this.Expense_Date.BackColor = System.Drawing.Color.White;
			this.Expense_Date.BorderRadius = 0;
			this.Expense_Date.Font = new System.Drawing.Font("Century Gothic", 6F);
			this.Expense_Date.ForeColor = System.Drawing.Color.Black;
			this.Expense_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.Expense_Date.FormatCustom = null;
			this.Expense_Date.Location = new System.Drawing.Point(251, 196);
			this.Expense_Date.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Expense_Date.Name = "Expense_Date";
			this.Expense_Date.Size = new System.Drawing.Size(252, 31);
			this.Expense_Date.TabIndex = 163;
			this.Expense_Date.Value = new System.DateTime(2019, 12, 30, 19, 3, 42, 85);
			// 
			// AddExpense
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1058, 312);
			this.Controls.Add(this.Expense_Date);
			this.Controls.Add(this.Expense_Amount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Expense_Name);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Expense_Comment);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "AddExpense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Expense";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Save_Button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Expense_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Expense_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Expense_Comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker Expense_Date;
    }
}