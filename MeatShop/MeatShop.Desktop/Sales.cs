using MeatShop.Database;
using MeatShop.Desktop.Properties;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MeatShop
{
	public partial class Sales : Form
	{
		Customer customer = new Customer();
		Category category = new Category();
		Product product = new Product();
		CategoryEntity categoryEntity;
		ProductCategoryEntity products;
		Panel categoryPanel;
		Panel productPanel;
		int totalAmount = 0;
		int price = 0;
		bool releaseKeys = false;
		//clsResize _form_resize;

		public Sales()
		{
			InitializeComponent();
			//_form_resize = new clsResize(this);
			//this.Load += _Load;
			//this.Resize += _Resize;

			//expense.GetData(Grd_Expense, "select * from Expenses");

			//CreateAllProducts(242, 190);
			CreateAllProductsNew(27, 189);
			//CreateCategories(16,190);
			CreateCategoriesOnTop(12, 34);


			customer.FillCombo(Sale_Customer);

		}

		private void CreateAllProductsNew(int x, int y)
		{
			//int x = 12, y = 124, px= 12,py = 14;
			products = product.getProducts();
			if (products.Id != null)
			{
				string path = Path.GetDirectoryName(Application.StartupPath);
				string newpath = path.Substring(0, (Application.StartupPath.Length - 10));

				FlowLayoutPanel panel = new FlowLayoutPanel();
				panel.Location = new Point(x, y);
				panel.Size = new Size(623, 496);
				panel.AutoScroll = true;
				this.Controls.Add(panel);

				int px = 3, py = 3;

				for (int i = 0; i < products.Id.Length; i++)
				{
					if (i == 0)
					{
						PictureBox pictureBox = new PictureBox();
						//pictureBox.Name = (i + 1).ToString();
						//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
						pictureBox.Name = products.Name[i];
						pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
						pictureBox.Location = new Point(px, py);
						pictureBox.Size = new Size(141, 77);
						pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

						if (products.ImageUrl[i] == "")
						{
							pictureBox.Image = product.DrawText(products.Name[i], new Font("Century Gothic", 10.0f), Color.White, Color.FromArgb(32, 30, 45));
						}
						else
						{
							using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								pictureBox.Image = (Bitmap)bmp.Clone();
							}
						}

						//pictureBox.Image = Resources.Default_Image_Thumbnail;
						pictureBox.MouseHover += new EventHandler(MyMouseHover);
						pictureBox.Click += new EventHandler(MyClickEvent);

						//Button button = new Button();
						//button.Location = new Point(x, y);
						//button.Text = "button" + (i + 1).ToString();
						//button.Size = new Size(185, 43);
						//button.Font = new Font("Microsoft Sans Serif", 10);

						panel.Controls.Add(pictureBox);
						//panel3.Controls.Add(button);
					}
					else
					{
						//x += 199;
						//px += 199;
						px += 175;

						PictureBox pictureBox = new PictureBox();
						pictureBox.Location = new Point(px, py);
						pictureBox.Size = new Size(141, 77);
						pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
						//pictureBox.Image = Resources.Default_Image_Thumbnail;
						pictureBox.MouseHover += new EventHandler(MyMouseHover);
						//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
						pictureBox.Name = products.Name[i];
						pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
						if (products.ImageUrl[i] == "")
						{
							pictureBox.Image = product.DrawText(products.Name[i], new Font("Century Gothic", 10.0f), Color.White, Color.FromArgb(32, 30, 45));
						}
						else
						{
							using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								pictureBox.Image = (Bitmap)bmp.Clone();
							}
						}
						pictureBox.Click += new EventHandler(MyClickEvent);

						panel.Controls.Add(pictureBox);
					}
				}

				//for testing
				//for (int i = 0; i < 100; i++)
				//{
				//	if (i == 0)
				//	{
				//		PictureBox pictureBox = new PictureBox();
				//		//pictureBox.Name = (i + 1).ToString();
				//		//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
				//		pictureBox.Name = i.ToString();
				//		pictureBox.Tag = Convert.ToString(i) + "-" + Convert.ToString(i);
				//		pictureBox.Location = new Point(px, py);
				//		pictureBox.Size = new Size(141, 77);
				//		pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


				//		pictureBox.Image = Resources.Default_Image_Thumbnail;
				//		pictureBox.MouseHover += new EventHandler(MyMouseHover);
				//		pictureBox.Click += new EventHandler(MyClickEvent);

				//		//Button button = new Button();
				//		//button.Location = new Point(x, y);
				//		//button.Text = "button" + (i + 1).ToString();
				//		//button.Size = new Size(185, 43);
				//		//button.Font = new Font("Microsoft Sans Serif", 10);

				//		panel.Controls.Add(pictureBox);
				//		//panel3.Controls.Add(button);
				//	}
				//	else
				//	{
				//		//x += 199;
				//		//px += 199;
				//		px += 175;

				//		PictureBox pictureBox = new PictureBox();
				//		pictureBox.Location = new Point(px, py);
				//		pictureBox.Size = new Size(141, 77);
				//		pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				//		pictureBox.MouseHover += new EventHandler(MyMouseHover);
				//		//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
				//		pictureBox.Name = i.ToString();
				//		pictureBox.Tag = Convert.ToString(i) + "-" + Convert.ToString(i);
				//		pictureBox.Image = Resources.Default_Image_Thumbnail;
				//		pictureBox.Click += new EventHandler(MyClickEvent);

				//		panel.Controls.Add(pictureBox);
				//	}
				//}


				productPanel = panel;
			}
		}


		//private void _Load(object sender, EventArgs e)
		//{
		//	_form_resize._get_initial_size();
		//}

		//private void _Resize(object sender, EventArgs e)
		//{
		//	_form_resize._resize();
		//}



		//private void CreateAllProducts(int x,int y)
		//{
		//	//int x = 12, y = 124, px= 12,py = 14;
		//	products = product.getProducts();
		//	if (products.Id != null)
		//	{
		//		string path = Path.GetDirectoryName(Application.StartupPath);
		//		string newpath = path.Substring(0, (Application.StartupPath.Length - 10));

		//		Panel panel = new Panel();
		//		panel.Location = new Point(x,y);
		//		panel.Size = new Size(398, 446);
		//		panel.AutoScroll = true;
		//		this.Controls.Add(panel);

		//		int px = 13, py = 3;
		//		for (int i = 0; i < products.Id.Length; i++)
		//		{
		//			if (i == 0)
		//			{
		//				PictureBox pictureBox = new PictureBox();
		//				//pictureBox.Name = (i + 1).ToString();
		//				//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
		//				pictureBox.Name = products.Name[i];
		//				pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
		//				pictureBox.Location = new Point(px, py);
		//				pictureBox.Size = new Size(185, 104);
		//				pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

		//				using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
		//				{
		//					var bmp = new Bitmap(fs);
		//					pictureBox.Image = (Bitmap)bmp.Clone();
		//				}

		//				//pictureBox.Image = Resources.Default_Image_Thumbnail;
		//				pictureBox.MouseHover += new EventHandler(MyMouseHover);
		//				pictureBox.Click += new EventHandler(MyClickEvent);

		//				//Button button = new Button();
		//				//button.Location = new Point(x, y);
		//				//button.Text = "button" + (i + 1).ToString();
		//				//button.Size = new Size(185, 43);
		//				//button.Font = new Font("Microsoft Sans Serif", 10);

		//				panel.Controls.Add(pictureBox);
		//				//panel3.Controls.Add(button);
		//			}
		//			else
		//			{
		//				if (i % 2 != 0)
		//				{
		//					//x += 199;
		//					//px += 199;
		//					px += 175;

		//					PictureBox pictureBox = new PictureBox();
		//					pictureBox.Location = new Point(px, py);
		//					pictureBox.Size = new Size(185, 104);
		//					pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
		//					//pictureBox.Image = Resources.Default_Image_Thumbnail;
		//					pictureBox.MouseHover += new EventHandler(MyMouseHover);
		//					//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
		//					pictureBox.Name = products.Name[i];
		//					pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
		//					using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
		//					{
		//						var bmp = new Bitmap(fs);
		//						pictureBox.Image = (Bitmap)bmp.Clone();
		//					}
		//					pictureBox.Click += new EventHandler(MyClickEvent);

		//					panel.Controls.Add(pictureBox);
		//				}
		//				else
		//				{
		//					//x -= 199;
		//					//y += 159;
		//					//px -= 199;
		//					//py +=159;
		//					px -= 175;
		//					py += 141;

		//					PictureBox pictureBox = new PictureBox();
		//					//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
		//					pictureBox.Location = new Point(px, py);
		//					pictureBox.Size = new Size(185, 104);
		//					pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
		//					//pictureBox.Image = Resources.Default_Image_Thumbnail;
		//					pictureBox.Name = products.Name[i];
		//					pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
		//					using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
		//					{
		//						var bmp = new Bitmap(fs);
		//						pictureBox.Image = (Bitmap)bmp.Clone();
		//					}
		//					pictureBox.MouseHover += new EventHandler(MyMouseHover);
		//					pictureBox.Click += new EventHandler(MyClickEvent);

		//					panel.Controls.Add(pictureBox);
		//				}
		//			}
		//		}
		//		productPanel = panel;
		//	}
		//}

		private void CreateProducts(int x, int y, ProductCategoryEntity entity)
		{
			//int x = 12, y = 124, px= 12,py = 14;
			products = entity;
			if (products.Id != null)
			{
				string path = Path.GetDirectoryName(Application.StartupPath);
				string newpath = path.Substring(0, (Application.StartupPath.Length - 10));

				FlowLayoutPanel panel = new FlowLayoutPanel();
				panel.Location = new Point(x, y);
				panel.Size = new Size(623, 496);
				panel.AutoScroll = true;
				this.Controls.Add(panel);

				int px = 13, py = 3;
				for (int i = 0; i < products.Id.Length; i++)
				{
					if (i == 0)
					{
						PictureBox pictureBox = new PictureBox();
						//pictureBox.Name = (i + 1).ToString();
						//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
						pictureBox.Name = products.Name[i];
						pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
						pictureBox.Location = new Point(px, py);
						pictureBox.Size = new Size(141, 77);
						pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

						if (products.ImageUrl[i] == "")
						{
							pictureBox.Image = product.DrawText(products.Name[i], new Font("Century Gothic", 10.0f), Color.White, Color.FromArgb(32, 30, 45));
						}
						else
						{
							using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								pictureBox.Image = (Bitmap)bmp.Clone();
							}
						}
						

						//pictureBox.Image = Resources.Default_Image_Thumbnail;
						pictureBox.MouseHover += new EventHandler(MyMouseHover);
						pictureBox.Click += new EventHandler(MyClickEvent);

						//Button button = new Button();
						//button.Location = new Point(x, y);
						//button.Text = "button" + (i + 1).ToString();
						//button.Size = new Size(185, 43);
						//button.Font = new Font("Microsoft Sans Serif", 10);

						panel.Controls.Add(pictureBox);
						//panel3.Controls.Add(button);
					}
					else
					{
							px += 175;

							PictureBox pictureBox = new PictureBox();
							pictureBox.Location = new Point(px, py);
							pictureBox.Size = new Size(141, 77);
							pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
							//pictureBox.Image = Resources.Default_Image_Thumbnail;
							pictureBox.MouseHover += new EventHandler(MyMouseHover);
							//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
							pictureBox.Name = products.Name[i];
							pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
						if (products.ImageUrl[i] == "")
						{
							pictureBox.Image = product.DrawText(products.Name[i], new Font("Century Gothic", 10.0f), Color.White, Color.FromArgb(32, 30, 45));
						}
						else
						{
							using (var fs = new System.IO.FileStream(newpath + products.ImageUrl[i], FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								pictureBox.Image = (Bitmap)bmp.Clone();
							}
						}
						pictureBox.Click += new EventHandler(MyClickEvent);

							//Button button = new Button();
							//button.Location = new Point(x, y);
							//button.Text = "button"+ (i + 1).ToString();
							//button.Size = new Size(185, 43);
							//button.Font = new Font("Microsoft Sans Serif", 10);

							panel.Controls.Add(pictureBox);
							//panel3.Controls.Add(button);
						
					}
				}
				productPanel = panel;
			}
		}

		//private void CreateCategories(int x,int y)
		//{
		//	//int x = 12, y = 124, px= 12,py = 14;
		//	categoryEntity = category.GetCategories();

		//	if (categoryEntity.Id != null)
		//	{
		//		Panel panel = new Panel();
		//		panel.Location = new Point(x, y);
		//		panel.Size = new Size(220, 446);
		//		panel.AutoScroll = true;
		//		this.Controls.Add(panel);
		//		int px = 4, py = 3;
		//		for (int i = 0; i < categoryEntity.Id.Length; i++)
		//		{
		//			if (i == 0)
		//			{
		//				//PictureBox pictureBox = new PictureBox();
		//				//pictureBox.Name = (i + 1).ToString();
		//				//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
		//				//pictureBox.Location = new Point(px, py);
		//				//pictureBox.Size = new Size(189, 104);
		//				//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
		//				//pictureBox.Image = Resources.Default_Image_Thumbnail;
		//				//pictureBox.MouseHover += new EventHandler(MyMouseHover);
		//				//pictureBox.Click += new EventHandler(MyClickEvent);


		//				Button button = new Button();
		//				button.Location = new Point(px, py);
		//				//button.Tag = i + 1;
		//				//button.Text = "button" + (i + 1).ToString();
		//				button.Tag = categoryEntity.Id[i];
		//				button.Text = categoryEntity.Name[i];
		//				button.TextAlign = ContentAlignment.MiddleCenter;
		//				button.Size = new Size(200, 48);
		//				button.Font = new Font("Microsoft Sans Serif", 10);
		//				button.Click += new EventHandler(MyButtonClick);
		//				button.ForeColor = Color.LightGray;
		//				button.FlatStyle = FlatStyle.Flat;
		//				button.BackColor = Color.FromArgb(24, 22, 34);
		//				button.UseVisualStyleBackColor = false;
		//				//panel4.Controls.Add(button);
		//				//panel3.Controls.Add(button);
		//				panel.Controls.Add(button);

		//			}
		//			else
		//			{
		//				//x -= 199;
		//				//y += 159;
		//				//px -= 199;
		//				//py +=159;

		//				py += 54;

		//				//PictureBox pictureBox = new PictureBox();
		//				//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
		//				//pictureBox.Location = new Point(px, py);
		//				//pictureBox.Size = new Size(189, 104);
		//				//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
		//				//pictureBox.Image = Resources.Default_Image_Thumbnail;
		//				//pictureBox.MouseHover += new EventHandler(MyMouseHover);
		//				//pictureBox.Click += new EventHandler(MyClickEvent);

		//				Button button = new Button();
		//				button.Location = new Point(px, py);
		//				//button.Tag = i + 1;
		//				//button.Text = "button" + (i + 1).ToString();
		//				button.Tag = categoryEntity.Id[i];
		//				button.Text = categoryEntity.Name[i];
		//				button.TextAlign = ContentAlignment.MiddleCenter;
		//				button.Size = new Size(200, 48);
		//				button.Font = new Font("Microsoft Sans Serif", 10);
		//				button.Click += new EventHandler(MyButtonClick);
		//				button.ForeColor = Color.LightGray;
		//				button.FlatStyle = FlatStyle.Flat;
		//				button.BackColor = Color.FromArgb(24, 22, 34);
		//				button.UseVisualStyleBackColor = false;
		//				//panel4.Controls.Add(pictureBox);
		//				//panel3.Controls.Add(button);
		//				panel.Controls.Add(button);
		//			}
		//		}
		//		categoryPanel = panel;
		//	}
		//}

		private void CreateCategoriesOnTop(int x, int y)
		{
			//int x = 12, y = 124, px= 12,py = 14;
			categoryEntity = category.GetCategories();

			if (categoryEntity.Id != null)
			{
				FlowLayoutPanel panel = new FlowLayoutPanel();
				panel.Location = new Point(x, y);
				panel.Size = new Size(1216, 59);
				panel.AutoScroll = true;
				
				this.Controls.Add(panel);
				int px = 3, py = 3;
				Button b = new Button();
				b.Location = new Point(px, py);
				//button.Tag = i + 1;
				//button.Text = "button" + (i + 1).ToString();
				b.Tag = 0;
				b.Text = "All Categories";
				b.TextAlign = ContentAlignment.MiddleCenter;
				b.Size = new Size(150, 40);
				b.Font = new Font("Microsoft Sans Serif", 10);
				b.Click += new EventHandler(MyButtonClick);
				b.ForeColor = Color.LightGray;
				b.FlatStyle = FlatStyle.Flat;
				b.BackColor = Color.FromArgb(24, 22, 34);
				b.UseVisualStyleBackColor = false;
				//panel4.Controls.Add(button);
				//panel3.Controls.Add(button);
				panel.Controls.Add(b);

				for (int i = 0; i < categoryEntity.Id.Length; i++)
				{
					if (i == 0)
					{
						//PictureBox pictureBox = new PictureBox();
						//pictureBox.Name = (i + 1).ToString();
						//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
						//pictureBox.Location = new Point(px, py);
						//pictureBox.Size = new Size(189, 104);
						//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
						//pictureBox.Image = Resources.Default_Image_Thumbnail;
						//pictureBox.MouseHover += new EventHandler(MyMouseHover);
						//pictureBox.Click += new EventHandler(MyClickEvent);


						Button button = new Button();
						button.Location = new Point(px, py);
						//button.Tag = i + 1;
						//button.Text = "button" + (i + 1).ToString();
						button.Tag = categoryEntity.Id[i];
						button.Text = categoryEntity.Name[i];
						button.TextAlign = ContentAlignment.MiddleCenter;
						button.Size = new Size(150, 40);
						button.Font = new Font("Microsoft Sans Serif", 10);
						button.Click += new EventHandler(MyButtonClick);
						button.ForeColor = Color.LightGray;
						button.FlatStyle = FlatStyle.Flat;
						button.BackColor = Color.FromArgb(24, 22, 34);
						button.UseVisualStyleBackColor = false;
						//panel4.Controls.Add(button);
						//panel3.Controls.Add(button);
						panel.Controls.Add(button);

					}
					else
					{
						//x -= 199;
						//y += 159;
						//px -= 199;
						//py +=159;

						px += 156;

						//PictureBox pictureBox = new PictureBox();
						//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
						//pictureBox.Location = new Point(px, py);
						//pictureBox.Size = new Size(189, 104);
						//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
						//pictureBox.Image = Resources.Default_Image_Thumbnail;
						//pictureBox.MouseHover += new EventHandler(MyMouseHover);
						//pictureBox.Click += new EventHandler(MyClickEvent);

						Button button = new Button();
						button.Location = new Point(px, py);
						//button.Tag = i + 1;
						//button.Text = "button" + (i + 1).ToString();
						button.Tag = categoryEntity.Id[i];
						button.Text = categoryEntity.Name[i];
						button.TextAlign = ContentAlignment.MiddleCenter;
						button.Size = new Size(150, 40);
						button.Font = new Font("Microsoft Sans Serif", 10);
						button.Click += new EventHandler(MyButtonClick);
						button.ForeColor = Color.LightGray;
						button.FlatStyle = FlatStyle.Flat;
						button.BackColor = Color.FromArgb(24, 22, 34);
						button.UseVisualStyleBackColor = false;
						//panel4.Controls.Add(pictureBox);
						//panel3.Controls.Add(button);
						panel.Controls.Add(button);
					}
				}

				//for (int i = 0; i < 20; i++)
				//{
				//	if (i == 0)
				//	{
				//		//PictureBox pictureBox = new PictureBox();
				//		//pictureBox.Name = (i + 1).ToString();
				//		//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
				//		//pictureBox.Location = new Point(px, py);
				//		//pictureBox.Size = new Size(189, 104);
				//		//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				//		//pictureBox.Image = Resources.Default_Image_Thumbnail;
				//		//pictureBox.MouseHover += new EventHandler(MyMouseHover);
				//		//pictureBox.Click += new EventHandler(MyClickEvent);


				//		Button button = new Button();
				//		button.Location = new Point(px, py);
				//		//button.Tag = i + 1;
				//		//button.Text = "button" + (i + 1).ToString();
				//		button.Tag = i;
				//		button.Text = i.ToString();
				//		button.TextAlign = ContentAlignment.MiddleCenter;
				//		button.Size = new Size(150, 40);
				//		button.Font = new Font("Microsoft Sans Serif", 10);
				//		button.Click += new EventHandler(MyButtonClick);
				//		button.ForeColor = Color.LightGray;
				//		button.FlatStyle = FlatStyle.Flat;
				//		button.BackColor = Color.FromArgb(24, 22, 34);
				//		button.UseVisualStyleBackColor = false;
				//		//panel4.Controls.Add(button);
				//		//panel3.Controls.Add(button);
				//		panel.Controls.Add(button);

				//	}
				//	else
				//	{
				//		//x -= 199;
				//		//y += 159;
				//		//px -= 199;
				//		//py +=159;

				//		px += 156;

				//		//PictureBox pictureBox = new PictureBox();
				//		//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
				//		//pictureBox.Location = new Point(px, py);
				//		//pictureBox.Size = new Size(189, 104);
				//		//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				//		//pictureBox.Image = Resources.Default_Image_Thumbnail;
				//		//pictureBox.MouseHover += new EventHandler(MyMouseHover);
				//		//pictureBox.Click += new EventHandler(MyClickEvent);

				//		Button button = new Button();
				//		button.Location = new Point(px, py);
				//		//button.Tag = i + 1;
				//		//button.Text = "button" + (i + 1).ToString();
				//		button.Tag = i;
				//		button.Text = i.ToString();
				//		button.TextAlign = ContentAlignment.MiddleCenter;
				//		button.Size = new Size(150, 40);
				//		button.Font = new Font("Microsoft Sans Serif", 10);
				//		button.Click += new EventHandler(MyButtonClick);
				//		button.ForeColor = Color.LightGray;
				//		button.FlatStyle = FlatStyle.Flat;
				//		button.BackColor = Color.FromArgb(24, 22, 34);
				//		button.UseVisualStyleBackColor = false;
				//		//panel4.Controls.Add(pictureBox);
				//		//panel3.Controls.Add(button);
				//		panel.Controls.Add(button);
				//	}
				//}

				categoryPanel = panel;
			}
		}


		private void MyButtonClick(object sender, EventArgs e)
		{

			Button button = sender as Button;

			if (Convert.ToInt32(button.Tag) == 0)
			{
				products = product.getProducts();

				if (products.Id != null)
				{
					productPanel.Controls.Clear();
					this.Controls.Remove(productPanel);
					CreateProducts(27, 189, products);
				}
				else
				{
					MessageBox.Show("No products found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				products = product.getProductsByCategory(Convert.ToInt32(button.Tag));

				if (products.Id != null)
				{
					productPanel.Controls.Clear();
					this.Controls.Remove(productPanel);
					CreateProducts(27, 189, products);
				}
				else
				{
					MessageBox.Show("No products found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			

			//for (int i = 0; i < pictureBoxes.Length; i++)
			//{
			//		categoryPanel.Controls.Clear();
			//		this.Controls.Remove(categoryPanel);
			//}

			//MessageBox.Show(""+button.Tag);
		}

		private void MyClickEvent(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			string price = Convert.ToString(pictureBox.Tag);
			int place = price.LastIndexOf('-');
			price = price.Substring(place + 1);
			totalAmount = Convert.ToInt32(Sale_TotalAmount.Text);


			string id = Convert.ToString(pictureBox.Tag);
			int pid = Convert.ToInt32(id.Substring(0, place));

			int rowIndex = -1;
			foreach (DataGridViewRow row in Grd_Sale.Rows)
			{
				if (row.Cells[0].Value.ToString().Equals(pid.ToString()))
				{
					rowIndex = row.Index;
					break;
				}
			}
			if (rowIndex != -1)
			{
				DataGridViewRow selectedRow = Grd_Sale.Rows[rowIndex];
				selectedRow.Cells[3].Value = Convert.ToInt32(selectedRow.Cells[3].Value) + 1;
				Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) + Convert.ToInt32(price));
			}
			else
			{
				Grd_Sale.Rows.Add(pid,pictureBox.Name, price);
				this.price = Convert.ToInt32(price);
				//Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) + Convert.ToInt32(price));
			}
		}

		//private void ClearData()
		//{
		//	Expense_ID.Text = "";
		//	Expense_Name.Text = "";
		//	Expense_Amount.Text = "";
		//	Expense_Date.Text = "";
		//	Expense_Comment.Text = "";
		//}

		private void MyMouseHover(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			//string name = Convert.ToString(pictureBox.Tag);
			//int place = name.LastIndexOf('-');
			//name = name.Substring(place+1);

			ToolTip tt = new ToolTip();
			tt.SetToolTip(pictureBox,pictureBox.Name);
		}

		private void Delete_Button_Click(object sender, EventArgs e)
		{
			//	try
			//	{
			//		if (Expense_ID.Text == String.Empty)
			//		{
			//			MessageBox.Show("Please select the expense first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//		}
			//		else if (MessageBox.Show("Are you sure you want to Delete this expense?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			//		{
			//			expense.DeleteExpense(Convert.ToInt32(Expense_ID.Text));
			//			ClearData();
			//			expense.GetData(Grd_Expense, "select * from Expenses");
			//		}
			//	}
			//	catch (Exception ex)
			//	{
			//		MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			
	     
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//categoryPanel.Controls.Clear();
			//this.Controls.Remove(categoryPanel);
			productPanel.Controls.Clear();
			this.Controls.Remove(productPanel);
			//CreateAllProducts(400, 230);
			//CreateCategories(30, 230);
		}
		
		private void Grd_Sale_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.ColumnIndex == 4)
			//{
			//	int index = e.RowIndex;
			//	if (index > -1)
			//	{
			//		DataGridViewRow selectedRow = Grd_Sale.Rows[index];
			//		selectedRow.Cells[3].Value = Convert.ToInt32(selectedRow.Cells[3].Value) + 1;
			//		Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) + Convert.ToInt32(selectedRow.Cells[2].Value));
			//	}
			//}
			//if (e.ColumnIndex == 5)
			//{
			//	int index = e.RowIndex;
			//	if (index > -1)
			//	{
			//		DataGridViewRow selectedRow = Grd_Sale.Rows[index];
			//		if (Convert.ToInt32(selectedRow.Cells[3].Value) > 1)
			//		{
			//			selectedRow.Cells[3].Value = Convert.ToInt32(selectedRow.Cells[3].Value) - 1;
			//			Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) - Convert.ToInt32(selectedRow.Cells[2].Value));
			//		}
			//		else
			//		{
			//			MessageBox.Show("Quantity can never be zero", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//		}
			//	}
			//}
			if (e.ColumnIndex == 4)
			{
				int index = e.RowIndex;
				DataGridViewRow selectedRow = Grd_Sale.Rows[index];
				int quantity = Convert.ToInt32(selectedRow.Cells[3].Value);
				int price = Convert.ToInt32(selectedRow.Cells[2].Value);
				int deduct = price * quantity;
				Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) - deduct);
				int rowNumber = Convert.ToInt32(e.RowIndex);
				//MessageBox.Show(""+rowNumber);
				Grd_Sale.Rows.RemoveAt(rowNumber);
			}
		}

		private void Sale_PaidAmount_Leave(object sender, EventArgs e)
		{
			//try
			//{
			//	int netAmount = Convert.ToInt32(Sale_TotalAmount.Text) - Convert.ToInt32(Sale_Discount.Text);
			//	Sale_Balance.Text = Convert.ToString(netAmount - Convert.ToInt32(Sale_PaidAmount.Text));
			//}
			//catch (Exception)
			//{
			//	MessageBox.Show("Please enter Discount first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void Sale_Discount_Leave(object sender, EventArgs e)
		{
			if (Sale_Discount.Text == "")
			{
				MessageBox.Show("Please enter Discount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (Convert.ToInt32(Sale_Discount.Text) < Convert.ToInt32(Sale_TotalAmount.Text))
			{

			}
			else
			{
				MessageBox.Show("Discount must be less than the TotalAmount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Sale_Discount.BackColor = Color.Red;
			}
		}

		private void Sale_Button_Click(object sender, EventArgs e)
		{
			if (product.AddSale(Convert.ToInt32(Sale_Customer.SelectedValue),Convert.ToInt32(Sale_TotalAmount.Text), Convert.ToInt32(Sale_Discount.Text), Convert.ToInt32(Sale_PaidAmount.Text), Convert.ToInt32(Sale_Balance.Text)))
			{
				if (product.AddSaleItem(Grd_Sale))
				{
					if (Convert.ToInt32(Sale_Balance.Text) > 0)
					{
						customer.UpdateBalance(Convert.ToInt32(Sale_Customer.SelectedValue), Convert.ToInt32(Sale_Balance.Text));
						ClearData();
					}
				}
			}
		}

		private void ClearData()
		{
			Grd_Sale.Rows.Clear();
			Sale_Balance.Text = "";
			Sale_Discount.Text = "";
			Sale_PaidAmount.Text = "";
			Sale_TotalAmount.Text = "";

			customer.FillCombo(Sale_Customer);
		}

		private void Sales_KeyPress(object sender, KeyPressEventArgs e)
		{
			//if (e.KeyChar == (char)Keys.B)
			//{
			//	MessageBox.Show("B Pressed");
			//}

			//MessageBox.Show(e.KeyChar.ToString()+" Pressed");

			//label3.Text = e.KeyChar.ToString();

			if (!releaseKeys)
			{
				if (char.IsLetter(e.KeyChar))
				{
					SingleProductEntity productEntity = product.GetProduct(e.KeyChar);
					if (productEntity.Id > 0)
					{
						totalAmount = Convert.ToInt32(Sale_TotalAmount.Text);
						int rowIndex = -1;
						foreach (DataGridViewRow row in Grd_Sale.Rows)
						{
							if (row.Cells[0].Value.ToString().Equals(productEntity.Id.ToString()))
							{
								rowIndex = row.Index;
								break;
							}
						}
						if (rowIndex != -1)
						{
							DataGridViewRow selectedRow = Grd_Sale.Rows[rowIndex];
							selectedRow.Cells[3].Value = Convert.ToInt32(selectedRow.Cells[3].Value) + 1;
							Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) + productEntity.Price);
						}
						else
						{
							Grd_Sale.Rows.Add(productEntity.Id, productEntity.Name, productEntity.Price);
							price = productEntity.Price;
							//Sale_TotalAmount.Text = Convert.ToString(Convert.ToInt32(Sale_TotalAmount.Text) + productEntity.Price);
						}
					}
				}

				if (!char.IsLetter(e.KeyChar))
				{
					//MessageBox.Show(e.KeyChar.ToString());
					int name = Convert.ToInt32(e.KeyChar.ToString());
					if (Grd_Sale.Rows.Count > 0)
					{
						switch (name)
						{
							case 0:
								DataGridViewRow row0 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row0.Cells[3].Value = row0.Cells[3].Value + "0";
								break;
							case 1:
								DataGridViewRow row1 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row1.Cells[3].Value = row1.Cells[3].Value + "1";
								break;
							case 2:
								DataGridViewRow row2 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row2.Cells[3].Value = row2.Cells[3].Value + "2";
								break;
							case 3:
								DataGridViewRow row3 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row3.Cells[3].Value = row3.Cells[3].Value + "3";
								break;
							case 4:
								DataGridViewRow row4 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row4.Cells[3].Value = row4.Cells[3].Value + "4";
								break;
							case 5:
								DataGridViewRow row5 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row5.Cells[3].Value = row5.Cells[3].Value + "5";
								break;
							case 6:
								DataGridViewRow row6 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row6.Cells[3].Value = row6.Cells[3].Value + "6";
								break;
							case 7:
								DataGridViewRow row7 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row7.Cells[3].Value = row7.Cells[3].Value + "7";
								break;
							case 8:
								DataGridViewRow row8 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row8.Cells[3].Value = row8.Cells[3].Value + "8";
								break;

							default:
								DataGridViewRow row9 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
								row9.Cells[3].Value = row9.Cells[3].Value + "9";
								break;
						}



						DataGridViewRow r = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];

						int quantity = Convert.ToInt32(r.Cells[3].Value);
						int price = Convert.ToInt32(r.Cells[2].Value);
						int deduct = price * quantity;

						Sale_TotalAmount.Text = Convert.ToString(totalAmount + (Convert.ToInt32(Sale_TotalAmount.Text) + deduct) - Convert.ToInt32(Sale_TotalAmount.Text));

					}
				}

				if (e.KeyChar == (char)Keys.F1)
				{
					Sale_PaidAmount.Focus();
				}
				if (e.KeyChar == (char)Keys.Enter)
				{
					Sale_Button.Focus();
				}
			}
		}

		private void Sales_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void Sale_PaidAmount_KeyUp(object sender, KeyEventArgs e)
		{
			bool check = false;
			if (Sale_PaidAmount.TextLength == 0)
			{
				Sale_Balance.Text = "";
				ReturnLabel.Text = "";
			}
			else
			{
				try
				{
					int netAmount = Convert.ToInt32(Sale_TotalAmount.Text) - Convert.ToInt32(Sale_Discount.Text);
					int amount = netAmount - Convert.ToInt32(Sale_PaidAmount.Text);
					if (amount < 0)
					{
						ReturnLabel.Text = "Return him " + Math.Abs(amount);
						check = true;
					}
					if (check)
					{
						Sale_Balance.Text = "";
					}
					else
					{
						Sale_Balance.Text = Convert.ToString(amount);
					}

				}
				catch (Exception)
				{
					MessageBox.Show("Please enter Discount first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void BtnC_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;

			int name = Convert.ToInt32(button.Name.Substring(3));

			switch (name)
			{
				case 0:
				    DataGridViewRow row0 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row0.Cells[3].Value = row0.Cells[3].Value + "0";
					break;
				case 1:
					DataGridViewRow row1 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row1.Cells[3].Value = row1.Cells[3].Value + "1";
					break;
				case 2:
					DataGridViewRow row2 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row2.Cells[3].Value = row2.Cells[3].Value + "2";
					break;
				case 3:
					DataGridViewRow row3 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row3.Cells[3].Value = row3.Cells[3].Value + "3";
					break;
				case 4:
					DataGridViewRow row4 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row4.Cells[3].Value = row4.Cells[3].Value + "4";
					break;
				case 5:
					DataGridViewRow row5 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row5.Cells[3].Value = row5.Cells[3].Value + "5";
					break;
				case 6:
					DataGridViewRow row6 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row6.Cells[3].Value = row6.Cells[3].Value + "6";
					break;
				case 7:
					DataGridViewRow row7 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row7.Cells[3].Value = row7.Cells[3].Value + "7";
					break;
				case 8:
					DataGridViewRow row8 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row8.Cells[3].Value = row8.Cells[3].Value + "8";
					break;

				default:
					DataGridViewRow row9 = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];
					row9.Cells[3].Value = row9.Cells[3].Value + "9";
					break;
			}



			//DataGridViewRow r = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];

			//int quantity = Convert.ToInt32(r.Cells[3].Value);
			//int price = Convert.ToInt32(r.Cells[2].Value);
			//int deduct = price * quantity;
		
			//Sale_TotalAmount.Text =  Convert.ToString( totalAmount + (Convert.ToInt32(Sale_TotalAmount.Text) + deduct) - Convert.ToInt32(Sale_TotalAmount.Text));

			DataGridViewRow r = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];

			int quantity = Convert.ToInt32(r.Cells[3].Value);
			int price = Convert.ToInt32(r.Cells[2].Value);
			int deduct = price * quantity;

			Sale_TotalAmount.Text = Convert.ToString(totalAmount + (Convert.ToInt32(Sale_TotalAmount.Text) + deduct) - Convert.ToInt32(Sale_TotalAmount.Text));

		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			NewCustomer customer = new NewCustomer();
			customer.Show();
		}

		private void Sale_SetPrice_CheckedChanged(object sender, EventArgs e)
		{
			if (Sale_SetPrice.Checked)
			{
				Grd_Sale.ReadOnly = false;
			}
			else
			{
				Grd_Sale.ReadOnly = true;
			}
		}

		private void Sales_Load(object sender, EventArgs e)
		{
			this.Focus();
			this.KeyPreview = true;
		}

		private void Grd_Sale_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow r = Grd_Sale.Rows[Grd_Sale.Rows.Count - 1];

			//int id = Convert.ToInt32(r.Cells[0].Value);
			int price = Convert.ToInt32(r.Cells[2].Value);
			//int deduct = price * quantity;

		}

		private void Sale_NumPad_CheckedChanged(object sender, EventArgs e)
		{
			if (Sale_NumPad.Checked)
			{
				releaseKeys = true;
			}
			else
			{
				releaseKeys = false;
			}
		}

		private void Sale_PaidAmount_Enter(object sender, EventArgs e)
		{
			Sale_NumPad.Checked = true;
		}

		//private void Grd_Expense_CellContentClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	try
		//	{
		//		int index = e.RowIndex;
		//		if (index > -1)
		//		{                                             
		//			DataGridViewRow selectedRow = Grd_Expense.Rows[index];
		//			Expense_ID.Text = Grd_Expense.Rows[e.RowIndex].Cells[0].Value.ToString();
		//			Expense_Name.Text = selectedRow.Cells[1].Value.ToString();
		//			Expense_Amount.Text = selectedRow.Cells[2].Value.ToString();
		//		//	Expense_Date.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
		//			Expense_Comment.Text = selectedRow.Cells[4].Value.ToString();
		//		}
		//	}
		//	catch (Exception)
		//	{
		//		MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//}

		//private void Expense_Search_TextChanged(object sender, EventArgs e)
		//{
		//	if (Expense_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
		//	{
		//		//invalid
		//		MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	else
		//	{
		//		//valid
		//		expense.SearchExpense(Grd_Expense, Expense_Search.Text);
		//	}

		//}
	}
}
