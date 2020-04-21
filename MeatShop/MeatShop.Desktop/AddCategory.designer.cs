namespace MeatShop
{
    partial class AddCategory
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
			this.Category_Name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.Save_Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(69, 185);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(907, 5);
			this.panel2.TabIndex = 69;
			// 
			// Category_Name
			// 
			this.Category_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Category_Name.Location = new System.Drawing.Point(278, 127);
			this.Category_Name.Name = "Category_Name";
			this.Category_Name.Size = new System.Drawing.Size(275, 31);
			this.Category_Name.TabIndex = 71;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(74, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 32);
			this.label1.TabIndex = 70;
			this.label1.Text = "Add Category";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(69, 90);
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
			this.label2.Location = new System.Drawing.Point(94, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 22);
			this.label2.TabIndex = 67;
			this.label2.Text = "Category Name";
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(0, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(25, 25);
			this.button5.TabIndex = 64;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Save_Button
			// 
			this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Save_Button.FlatAppearance.BorderSize = 0;
			this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save_Button.ForeColor = System.Drawing.Color.LightGray;
			this.Save_Button.Location = new System.Drawing.Point(336, 206);
			this.Save_Button.Name = "Save_Button";
			this.Save_Button.Size = new System.Drawing.Size(150, 40);
			this.Save_Button.TabIndex = 81;
			this.Save_Button.Text = "Save";
			this.Save_Button.UseVisualStyleBackColor = false;
			this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
			// 
			// AddCategory
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(995, 270);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Category_Name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Name = "AddCategory";
			this.Text = "Add Category";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Category_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button Save_Button;
	}
}