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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.Grd_Sale = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Sale_Discount = new System.Windows.Forms.TextBox();
			this.Sale_TotalAmount = new System.Windows.Forms.TextBox();
			this.Sale_PaidAmount = new System.Windows.Forms.TextBox();
			this.Sale_Balance = new System.Windows.Forms.TextBox();
			this.LBoughtItems = new System.Windows.Forms.Label();
			this.Sale_Customer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Btn7 = new System.Windows.Forms.Button();
			this.Btn9 = new System.Windows.Forms.Button();
			this.Btn8 = new System.Windows.Forms.Button();
			this.Btn5 = new System.Windows.Forms.Button();
			this.Btn6 = new System.Windows.Forms.Button();
			this.Btn4 = new System.Windows.Forms.Button();
			this.Btn2 = new System.Windows.Forms.Button();
			this.Btn3 = new System.Windows.Forms.Button();
			this.Btn1 = new System.Windows.Forms.Button();
			this.Btn0 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.Sale_SetPrice = new System.Windows.Forms.CheckBox();
			this.Sale_NumPad = new System.Windows.Forms.CheckBox();
			this.ReturnLabel = new System.Windows.Forms.Label();
			this.BtnBack = new System.Windows.Forms.Button();
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
			this.Sale_Button.Location = new System.Drawing.Point(520, 716);
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
			this.panel2.Location = new System.Drawing.Point(29, 705);
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
			this.LDate.Location = new System.Drawing.Point(939, 633);
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
			this.LAmount.Location = new System.Drawing.Point(898, 583);
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
			this.LName.Location = new System.Drawing.Point(936, 530);
			this.LName.Name = "LName";
			this.LName.Size = new System.Drawing.Size(89, 22);
			this.LName.TabIndex = 76;
			this.LName.Text = "Discount";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 99);
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
			this.label2.Location = new System.Drawing.Point(892, 478);
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
            this.P,
            this.Quantity,
            this.HPrice,
            this.Unit,
            this.Delete});
			this.Grd_Sale.DoubleBuffered = true;
			this.Grd_Sale.EnableHeadersVisualStyles = false;
			this.Grd_Sale.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_Sale.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_Sale.Location = new System.Drawing.Point(656, 163);
			this.Grd_Sale.MultiSelect = false;
			this.Grd_Sale.Name = "Grd_Sale";
			this.Grd_Sale.ReadOnly = true;
			this.Grd_Sale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_Sale.Size = new System.Drawing.Size(576, 297);
			this.Grd_Sale.TabIndex = 89;
			this.Grd_Sale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Sale_CellContentClick);
			this.Grd_Sale.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Sale_CellEndEdit);
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			// 
			// P
			// 
			this.P.HeaderText = "Price";
			this.P.Name = "P";
			this.P.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.MaxInputLength = 999999;
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			// 
			// HPrice
			// 
			this.HPrice.HeaderText = "HPrice";
			this.HPrice.Name = "HPrice";
			this.HPrice.ReadOnly = true;
			this.HPrice.Visible = false;
			// 
			// Unit
			// 
			this.Unit.HeaderText = "Unit";
			this.Unit.Name = "Unit";
			this.Unit.ReadOnly = true;
			this.Unit.Visible = false;
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
			this.Sale_Discount.Location = new System.Drawing.Point(1034, 527);
			this.Sale_Discount.Name = "Sale_Discount";
			this.Sale_Discount.Size = new System.Drawing.Size(156, 31);
			this.Sale_Discount.TabIndex = 90;
			this.Sale_Discount.Text = "0";
			this.Sale_Discount.Click += new System.EventHandler(this.Sale_Discount_Click);
			this.Sale_Discount.Enter += new System.EventHandler(this.Sale_PaidAmount_Enter);
			this.Sale_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sale_Discount_KeyPress);
			this.Sale_Discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sale_Discount_KeyUp);
			this.Sale_Discount.Leave += new System.EventHandler(this.Sale_Discount_Leave);
			// 
			// Sale_TotalAmount
			// 
			this.Sale_TotalAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_TotalAmount.Location = new System.Drawing.Point(1034, 475);
			this.Sale_TotalAmount.Name = "Sale_TotalAmount";
			this.Sale_TotalAmount.ReadOnly = true;
			this.Sale_TotalAmount.Size = new System.Drawing.Size(156, 31);
			this.Sale_TotalAmount.TabIndex = 91;
			this.Sale_TotalAmount.Text = "0";
			// 
			// Sale_PaidAmount
			// 
			this.Sale_PaidAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_PaidAmount.Location = new System.Drawing.Point(1034, 580);
			this.Sale_PaidAmount.MaxLength = 8;
			this.Sale_PaidAmount.Name = "Sale_PaidAmount";
			this.Sale_PaidAmount.Size = new System.Drawing.Size(156, 31);
			this.Sale_PaidAmount.TabIndex = 96;
			this.Sale_PaidAmount.Enter += new System.EventHandler(this.Sale_PaidAmount_Enter);
			this.Sale_PaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sale_PaidAmount_KeyPress);
			this.Sale_PaidAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sale_PaidAmount_KeyUp);
			this.Sale_PaidAmount.Leave += new System.EventHandler(this.Sale_PaidAmount_Leave);
			// 
			// Sale_Balance
			// 
			this.Sale_Balance.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_Balance.Location = new System.Drawing.Point(1034, 630);
			this.Sale_Balance.Name = "Sale_Balance";
			this.Sale_Balance.ReadOnly = true;
			this.Sale_Balance.Size = new System.Drawing.Size(156, 31);
			this.Sale_Balance.TabIndex = 97;
			this.Sale_Balance.Enter += new System.EventHandler(this.Sale_PaidAmount_Enter);
			// 
			// LBoughtItems
			// 
			this.LBoughtItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LBoughtItems.AutoSize = true;
			this.LBoughtItems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBoughtItems.ForeColor = System.Drawing.Color.White;
			this.LBoughtItems.Location = new System.Drawing.Point(652, 129);
			this.LBoughtItems.Name = "LBoughtItems";
			this.LBoughtItems.Size = new System.Drawing.Size(130, 22);
			this.LBoughtItems.TabIndex = 98;
			this.LBoughtItems.Text = "Bought Items";
			// 
			// Sale_Customer
			// 
			this.Sale_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Sale_Customer.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.Sale_Customer.FormattingEnabled = true;
			this.Sale_Customer.Items.AddRange(new object[] {
            "WalkIn"});
			this.Sale_Customer.Location = new System.Drawing.Point(129, 119);
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
			this.label1.Location = new System.Drawing.Point(25, 122);
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
			this.label4.Location = new System.Drawing.Point(23, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 22);
			this.label4.TabIndex = 174;
			this.label4.Text = "Products";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(8, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 22);
			this.label5.TabIndex = 178;
			this.label5.Text = "Categories";
			// 
			// Btn7
			// 
			this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn7.FlatAppearance.BorderSize = 0;
			this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn7.ForeColor = System.Drawing.Color.LightGray;
			this.Btn7.Location = new System.Drawing.Point(656, 475);
			this.Btn7.Name = "Btn7";
			this.Btn7.Size = new System.Drawing.Size(50, 40);
			this.Btn7.TabIndex = 179;
			this.Btn7.Text = "7";
			this.Btn7.UseVisualStyleBackColor = false;
			this.Btn7.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn9
			// 
			this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn9.FlatAppearance.BorderSize = 0;
			this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn9.ForeColor = System.Drawing.Color.LightGray;
			this.Btn9.Location = new System.Drawing.Point(790, 475);
			this.Btn9.Name = "Btn9";
			this.Btn9.Size = new System.Drawing.Size(50, 40);
			this.Btn9.TabIndex = 180;
			this.Btn9.Text = "9";
			this.Btn9.UseVisualStyleBackColor = false;
			this.Btn9.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn8
			// 
			this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn8.FlatAppearance.BorderSize = 0;
			this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn8.ForeColor = System.Drawing.Color.LightGray;
			this.Btn8.Location = new System.Drawing.Point(723, 475);
			this.Btn8.Name = "Btn8";
			this.Btn8.Size = new System.Drawing.Size(50, 40);
			this.Btn8.TabIndex = 181;
			this.Btn8.Text = "8";
			this.Btn8.UseVisualStyleBackColor = false;
			this.Btn8.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn5
			// 
			this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn5.FlatAppearance.BorderSize = 0;
			this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn5.ForeColor = System.Drawing.Color.LightGray;
			this.Btn5.Location = new System.Drawing.Point(723, 527);
			this.Btn5.Name = "Btn5";
			this.Btn5.Size = new System.Drawing.Size(50, 40);
			this.Btn5.TabIndex = 184;
			this.Btn5.Text = "5";
			this.Btn5.UseVisualStyleBackColor = false;
			this.Btn5.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn6
			// 
			this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn6.FlatAppearance.BorderSize = 0;
			this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn6.ForeColor = System.Drawing.Color.LightGray;
			this.Btn6.Location = new System.Drawing.Point(790, 527);
			this.Btn6.Name = "Btn6";
			this.Btn6.Size = new System.Drawing.Size(50, 40);
			this.Btn6.TabIndex = 183;
			this.Btn6.Text = "6";
			this.Btn6.UseVisualStyleBackColor = false;
			this.Btn6.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn4
			// 
			this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn4.FlatAppearance.BorderSize = 0;
			this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn4.ForeColor = System.Drawing.Color.LightGray;
			this.Btn4.Location = new System.Drawing.Point(656, 527);
			this.Btn4.Name = "Btn4";
			this.Btn4.Size = new System.Drawing.Size(50, 40);
			this.Btn4.TabIndex = 182;
			this.Btn4.Text = "4";
			this.Btn4.UseVisualStyleBackColor = false;
			this.Btn4.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn2
			// 
			this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn2.FlatAppearance.BorderSize = 0;
			this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn2.ForeColor = System.Drawing.Color.LightGray;
			this.Btn2.Location = new System.Drawing.Point(723, 580);
			this.Btn2.Name = "Btn2";
			this.Btn2.Size = new System.Drawing.Size(50, 40);
			this.Btn2.TabIndex = 187;
			this.Btn2.Text = "2";
			this.Btn2.UseVisualStyleBackColor = false;
			this.Btn2.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn3
			// 
			this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn3.FlatAppearance.BorderSize = 0;
			this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn3.ForeColor = System.Drawing.Color.LightGray;
			this.Btn3.Location = new System.Drawing.Point(790, 580);
			this.Btn3.Name = "Btn3";
			this.Btn3.Size = new System.Drawing.Size(50, 40);
			this.Btn3.TabIndex = 186;
			this.Btn3.Text = "3";
			this.Btn3.UseVisualStyleBackColor = false;
			this.Btn3.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn1
			// 
			this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn1.FlatAppearance.BorderSize = 0;
			this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn1.ForeColor = System.Drawing.Color.LightGray;
			this.Btn1.Location = new System.Drawing.Point(656, 580);
			this.Btn1.Name = "Btn1";
			this.Btn1.Size = new System.Drawing.Size(50, 40);
			this.Btn1.TabIndex = 185;
			this.Btn1.Text = "1";
			this.Btn1.UseVisualStyleBackColor = false;
			this.Btn1.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// Btn0
			// 
			this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Btn0.FlatAppearance.BorderSize = 0;
			this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn0.ForeColor = System.Drawing.Color.LightGray;
			this.Btn0.Location = new System.Drawing.Point(656, 630);
			this.Btn0.Name = "Btn0";
			this.Btn0.Size = new System.Drawing.Size(117, 40);
			this.Btn0.TabIndex = 188;
			this.Btn0.Text = "0";
			this.Btn0.UseVisualStyleBackColor = false;
			this.Btn0.Click += new System.EventHandler(this.BtnC_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1114, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 22);
			this.label3.TabIndex = 191;
			this.label3.Text = "Products";
			this.label3.Visible = false;
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.BtnAdd.FlatAppearance.BorderSize = 0;
			this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAdd.ForeColor = System.Drawing.Color.LightGray;
			this.BtnAdd.Location = new System.Drawing.Point(386, 117);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(37, 40);
			this.BtnAdd.TabIndex = 192;
			this.BtnAdd.Text = "+";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// Sale_SetPrice
			// 
			this.Sale_SetPrice.AutoSize = true;
			this.Sale_SetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sale_SetPrice.ForeColor = System.Drawing.Color.White;
			this.Sale_SetPrice.Location = new System.Drawing.Point(801, 128);
			this.Sale_SetPrice.Name = "Sale_SetPrice";
			this.Sale_SetPrice.Size = new System.Drawing.Size(104, 28);
			this.Sale_SetPrice.TabIndex = 193;
			this.Sale_SetPrice.Text = "Set Price";
			this.Sale_SetPrice.UseVisualStyleBackColor = true;
			this.Sale_SetPrice.Visible = false;
			this.Sale_SetPrice.CheckedChanged += new System.EventHandler(this.Sale_SetPrice_CheckedChanged);
			// 
			// Sale_NumPad
			// 
			this.Sale_NumPad.AutoSize = true;
			this.Sale_NumPad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sale_NumPad.ForeColor = System.Drawing.Color.White;
			this.Sale_NumPad.Location = new System.Drawing.Point(924, 127);
			this.Sale_NumPad.Name = "Sale_NumPad";
			this.Sale_NumPad.Size = new System.Drawing.Size(144, 28);
			this.Sale_NumPad.TabIndex = 194;
			this.Sale_NumPad.Text = "Release Keys";
			this.Sale_NumPad.UseVisualStyleBackColor = true;
			this.Sale_NumPad.Visible = false;
			this.Sale_NumPad.CheckedChanged += new System.EventHandler(this.Sale_NumPad_CheckedChanged);
			// 
			// ReturnLabel
			// 
			this.ReturnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ReturnLabel.AutoSize = true;
			this.ReturnLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReturnLabel.ForeColor = System.Drawing.Color.White;
			this.ReturnLabel.Location = new System.Drawing.Point(939, 680);
			this.ReturnLabel.Name = "ReturnLabel";
			this.ReturnLabel.Size = new System.Drawing.Size(0, 22);
			this.ReturnLabel.TabIndex = 195;
			// 
			// BtnBack
			// 
			this.BtnBack.BackColor = System.Drawing.Color.LightGray;
			this.BtnBack.FlatAppearance.BorderSize = 0;
			this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBack.ForeColor = System.Drawing.Color.LightGray;
			this.BtnBack.Image = global::MeatShop.Desktop.Properties.Resources.icons8_back_arrow_24;
			this.BtnBack.Location = new System.Drawing.Point(790, 628);
			this.BtnBack.Name = "BtnBack";
			this.BtnBack.Size = new System.Drawing.Size(50, 40);
			this.BtnBack.TabIndex = 196;
			this.BtnBack.UseVisualStyleBackColor = false;
			this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// Sales
			// 
			this.AcceptButton = this.Sale_Button;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1244, 767);
			this.Controls.Add(this.BtnBack);
			this.Controls.Add(this.ReturnLabel);
			this.Controls.Add(this.Sale_NumPad);
			this.Controls.Add(this.Sale_SetPrice);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Btn0);
			this.Controls.Add(this.Btn2);
			this.Controls.Add(this.Btn3);
			this.Controls.Add(this.Btn1);
			this.Controls.Add(this.Btn5);
			this.Controls.Add(this.Btn6);
			this.Controls.Add(this.Btn4);
			this.Controls.Add(this.Btn8);
			this.Controls.Add(this.Btn9);
			this.Controls.Add(this.Btn7);
			this.Controls.Add(this.label5);
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
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Name = "Sales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Sale";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
			this.Load += new System.EventHandler(this.Sales_Load);
			this.Click += new System.EventHandler(this.Sales_Click);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sales_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sales_KeyPress);
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_Sale;
		private System.Windows.Forms.TextBox Sale_Discount;
		private System.Windows.Forms.TextBox Sale_TotalAmount;
        private System.Windows.Forms.TextBox Sale_PaidAmount;
		private System.Windows.Forms.TextBox Sale_Balance;
		private System.Windows.Forms.Label LBoughtItems;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Btn7;
		private System.Windows.Forms.Button Btn9;
		private System.Windows.Forms.Button Btn8;
		private System.Windows.Forms.Button Btn5;
		private System.Windows.Forms.Button Btn6;
		private System.Windows.Forms.Button Btn4;
		private System.Windows.Forms.Button Btn2;
		private System.Windows.Forms.Button Btn3;
		private System.Windows.Forms.Button Btn1;
		private System.Windows.Forms.Button Btn0;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.CheckBox Sale_SetPrice;
		private System.Windows.Forms.CheckBox Sale_NumPad;
		private System.Windows.Forms.Label ReturnLabel;
		private System.Windows.Forms.Button BtnBack;
		public System.Windows.Forms.ComboBox Sale_Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn P;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn HPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}