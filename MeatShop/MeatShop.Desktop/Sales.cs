using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MeatShop.Database;
using MeatShop.Desktop.Properties;
using System.IO;

namespace MeatShop
{
	public partial class Sales : Form
	{
		Customer customer = new Customer();
		Category category = new Category();
		Product product = new Product();
		Button[] categoryButtons;
		PictureBox[] pictureBoxes;
		CategoryEntity categoryEntity;
		ProductCategoryEntity products;
		Panel categoryPanel;
		Panel productPanel;

		public Sales()
		{
			InitializeComponent();
			//expense.GetData(Grd_Expense, "select * from Expenses");
			CreateProducts();
			CreateCategories();
			customer.FillCombo(Sale_Customer);
			
		}

		private void CreateProducts()
		{
			//int x = 12, y = 124, px= 12,py = 14;

			products = product.getProducts();
			if (products.Id != null)
			{
				Panel panel = new Panel();
				panel.Location = new Point(242, 190);
				panel.Size = new Size(398, 446);
				panel.AutoScroll = true;
				this.Controls.Add(panel);
				
				pictureBoxes = new PictureBox[products.Id.Length];
				int px = 13, py = 3;
				for (int i = 0; i < products.Id.Length; i++)
				{
					if (i == 0)
					{
						PictureBox pictureBox = new PictureBox();
						//pictureBox.Name = (i + 1).ToString();
						//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
						pictureBox.Name = products.Name[i];
						pictureBox.Tag = Convert.ToString(products.Id[i]) + "-"+ Convert.ToString(products.Price[i]);						
						pictureBox.Location = new Point(px, py);
						pictureBox.Size = new Size(185, 104);
						pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
						using (var fs = new FileStream(products.ImageUrl[i], FileMode.Open))
						{
							var bmp = new Bitmap(fs);
							pictureBox.Image = (Bitmap)bmp.Clone();
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
						pictureBoxes[i] = pictureBox;
					}
					else
					{
						if (i % 2 != 0)
						{
							//x += 199;
							//px += 199;
							px += 175;

							PictureBox pictureBox = new PictureBox();
							pictureBox.Location = new Point(px, py);
							pictureBox.Size = new Size(185, 104);
							pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
							//pictureBox.Image = Resources.Default_Image_Thumbnail;
							pictureBox.MouseHover += new EventHandler(MyMouseHover);
							//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
							pictureBox.Name = products.Name[i];
							pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
							using (var fs = new FileStream(products.ImageUrl[i], FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								pictureBox.Image = (Bitmap)bmp.Clone();
							}
							pictureBox.Click += new EventHandler(MyClickEvent);

							//Button button = new Button();
							//button.Location = new Point(x, y);
							//button.Text = "button"+ (i + 1).ToString();
							//button.Size = new Size(185, 43);
							//button.Font = new Font("Microsoft Sans Serif", 10);

							panel.Controls.Add(pictureBox);
							//panel3.Controls.Add(button);
							pictureBoxes[i] = pictureBox;
						}
						else
						{
							//x -= 199;
							//y += 159;
							//px -= 199;
							//py +=159;
							px -= 175;
							py += 141;

							PictureBox pictureBox = new PictureBox();
							//pictureBox.Tag = (i + 1).ToString() + "-Product" + (i + 1).ToString();
							pictureBox.Location = new Point(px, py);
							pictureBox.Size = new Size(185, 104);
							pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
							//pictureBox.Image = Resources.Default_Image_Thumbnail;
							pictureBox.Name = products.Name[i];
							pictureBox.Tag = Convert.ToString(products.Id[i]) + "-" + Convert.ToString(products.Price[i]);
							using (var fs = new FileStream(products.ImageUrl[i], FileMode.Open))
							{
								var bmp = new Bitmap(fs);
								pictureBox.Image = (Bitmap)bmp.Clone();
							}
							pictureBox.MouseHover += new EventHandler(MyMouseHover);
							pictureBox.Click += new EventHandler(MyClickEvent);

							//Button button = new Button();
							//button.Location = new Point(x, y);
							//button.Text = "button" + (i + 1).ToString();
							//button.Size = new Size(185, 43);
							//button.Font = new Font("Microsoft Sans Serif", 10);

							panel.Controls.Add(pictureBox);
							//panel3.Controls.Add(button);
							pictureBoxes[i] = pictureBox;
						}
					}
				}
				productPanel = panel;
			}
		}

		private void CreateCategories()
		{
			//int x = 12, y = 124, px= 12,py = 14;
			categoryEntity = category.GetCategories();

			if (categoryEntity.Id != null)
			{
				Panel panel = new Panel();
				panel.Location = new Point(16, 190);
				panel.Size = new Size(220, 446);
				panel.AutoScroll = true;
				this.Controls.Add(panel);
				categoryButtons = new Button[categoryEntity.Id.Length];
				int px = 4, py = 3;
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
						button.Size = new Size(200, 48);
						button.Font = new Font("Microsoft Sans Serif", 10);
						button.Click += new EventHandler(MyButtonClick);
						button.ForeColor = Color.LightGray;
						button.FlatStyle = FlatStyle.Flat;
						button.BackColor = Color.FromArgb(24, 22, 34);
						button.UseVisualStyleBackColor = false;
						//panel4.Controls.Add(button);
						//panel3.Controls.Add(button);
						panel.Controls.Add(button);

						categoryButtons[i] = button;
					}
					else
					{
							//x -= 199;
							//y += 159;
							//px -= 199;
							//py +=159;

							py += 54;

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
							button.Size = new Size(200, 48);
							button.Font = new Font("Microsoft Sans Serif", 10);
							button.Click += new EventHandler(MyButtonClick);
							button.ForeColor = Color.LightGray;
							button.FlatStyle = FlatStyle.Flat;
							button.BackColor = Color.FromArgb(24, 22, 34);
							button.UseVisualStyleBackColor = false;
						//panel4.Controls.Add(pictureBox);
						//panel3.Controls.Add(button);
						    panel.Controls.Add(button);
							categoryButtons[i] = button;
					}
				}
				categoryPanel = panel;
			}
		}

		private void MyButtonClick(object sender, EventArgs e)
		{
			//Button button = sender as Button;
			//ProductCategoryEntity productCategory = product.getProductsByCategory(Convert.ToInt32(button.Tag));

			//for (int i = 0; i < pictureBoxes.Length; i++)
			//{
				productPanel.Controls.Clear();
			//}
			MessageBox.Show("Controls cleared");
			
			//MessageBox.Show(""+button.Tag);
		}

		private void MyClickEvent(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			string price = Convert.ToString(pictureBox.Tag);
			int place = price.LastIndexOf('-');
			price = price.Substring(place + 1);

			Grd_Sale.Rows.Add(pictureBox.Name, price);
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
			CreateProducts();
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
