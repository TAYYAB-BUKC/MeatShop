namespace MeatShop
{
	partial class ManageUnit
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
			this.Grd_Unit = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Unit_Name = new System.Windows.Forms.TextBox();
			this.Unit_ID = new System.Windows.Forms.TextBox();
			this.Unit_Search = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Unit_Prefix = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Grd_Unit)).BeginInit();
			this.SuspendLayout();
			// 
			// Delete_Button
			// 
			this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Delete_Button.FlatAppearance.BorderSize = 0;
			this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Delete_Button.Location = new System.Drawing.Point(646, 315);
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
			this.panel2.Location = new System.Drawing.Point(27, 293);
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
			this.label3.Location = new System.Drawing.Point(122, 187);
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
			this.label1.Size = new System.Drawing.Size(324, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "Category Management";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 60);
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
			this.label2.Location = new System.Drawing.Point(120, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 22);
			this.label2.TabIndex = 72;
			this.label2.Text = "Unit ID";
			// 
			// Update_Button
			// 
			this.Update_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Update_Button.FlatAppearance.BorderSize = 0;
			this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Update_Button.Location = new System.Drawing.Point(458, 315);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(150, 40);
			this.Update_Button.TabIndex = 70;
			this.Update_Button.Text = "Update";
			this.Update_Button.UseVisualStyleBackColor = false;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// Grd_Unit
			// 
			this.Grd_Unit.AllowUserToAddRows = false;
			this.Grd_Unit.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_Unit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Grd_Unit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_Unit.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_Unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_Unit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_Unit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Grd_Unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_Unit.DoubleBuffered = true;
			this.Grd_Unit.EnableHeadersVisualStyles = false;
			this.Grd_Unit.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Unit.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Unit.Location = new System.Drawing.Point(485, 124);
			this.Grd_Unit.Name = "Grd_Unit";
			this.Grd_Unit.ReadOnly = true;
			this.Grd_Unit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Unit.Size = new System.Drawing.Size(676, 149);
			this.Grd_Unit.TabIndex = 89;
			this.Grd_Unit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_User_CellClick);
			// 
			// Unit_Name
			// 
			this.Unit_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Unit_Name.Location = new System.Drawing.Point(212, 178);
			this.Unit_Name.Name = "Unit_Name";
			this.Unit_Name.Size = new System.Drawing.Size(240, 31);
			this.Unit_Name.TabIndex = 90;
			// 
			// Unit_ID
			// 
			this.Unit_ID.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Unit_ID.Location = new System.Drawing.Point(212, 126);
			this.Unit_ID.Name = "Unit_ID";
			this.Unit_ID.ReadOnly = true;
			this.Unit_ID.Size = new System.Drawing.Size(240, 31);
			this.Unit_ID.TabIndex = 91;
			// 
			// Unit_Search
			// 
			this.Unit_Search.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Unit_Search.Location = new System.Drawing.Point(657, 81);
			this.Unit_Search.Name = "Unit_Search";
			this.Unit_Search.Size = new System.Drawing.Size(502, 31);
			this.Unit_Search.TabIndex = 99;
			this.Unit_Search.TextChanged += new System.EventHandler(this.User_Search_TextChanged);
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
			// Unit_Prefix
			// 
			this.Unit_Prefix.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Unit_Prefix.Location = new System.Drawing.Point(212, 230);
			this.Unit_Prefix.Name = "Unit_Prefix";
			this.Unit_Prefix.Size = new System.Drawing.Size(240, 31);
			this.Unit_Prefix.TabIndex = 101;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(92, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 22);
			this.label4.TabIndex = 100;
			this.label4.Text = "Unit Prefix";
			// 
			// ManageUnit
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1197, 378);
			this.Controls.Add(this.Unit_Prefix);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Unit_Search);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Unit_ID);
			this.Controls.Add(this.Unit_Name);
			this.Controls.Add(this.Grd_Unit);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Update_Button);
			this.Name = "ManageUnit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Category Management";
			((System.ComponentModel.ISupportInitialize)(this.Grd_Unit)).EndInit();
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
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Unit;
		private System.Windows.Forms.TextBox Unit_Name;
		private System.Windows.Forms.TextBox Unit_ID;
		private System.Windows.Forms.TextBox Unit_Search;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Unit_Prefix;
		private System.Windows.Forms.Label label4;
	}
}