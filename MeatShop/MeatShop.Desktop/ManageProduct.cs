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
using System.IO;

namespace MeatShop
{
	public partial class ManageProduct : Form
	{
		bool isImageUpdated = false;
		OpenFileDialog opf = new OpenFileDialog();
		string oldPath;
		string newPath;
		Category category = new Category();
		Unit unit = new Unit();
		Product product = new Product();
		private char oldShortCode;

		public ManageProduct()
		{
			InitializeComponent();
			//unit.FillCombo(Product_Unit);
			category.FillCombo(Product_Category);
			product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
		}

		private void ClearData()
		{
			Product_ID.Text = "";
			Product_Name.Text = "";
			Product_Price.Text = "";
			Product_Image.Image = null;
			//unit.FillCombo(Product_Unit);
			Product_Unit.SelectedIndex = 0;
			category.FillCombo(Product_Category);
			Product_ShortCode.Text = "";
		}

		private void Delete_Button_Click(object sender, EventArgs e)
		{
			try
			{
				if (Product_ID.Text == String.Empty)
				{
					MessageBox.Show("Please select the product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (MessageBox.Show("Are you sure you want to Delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (oldPath == "")
					{
						product.DeleteProduct(Convert.ToInt32(Product_ID.Text), null, null);
						ClearData();
						product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
					}
					else
					{
					
						string path = Path.GetDirectoryName(Application.StartupPath);
						string newpath = path.Substring(0, (Application.StartupPath.Length - 10));

						FileInfo fileInfo = new FileInfo(newpath + oldPath);
						product.DeleteProduct(Convert.ToInt32(Product_ID.Text), fileInfo, oldPath);
						ClearData();
						product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Update_Button_Click(object sender, EventArgs e)
		{
			if (Product_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int price = -1;
				try
				{
					price = Convert.ToInt32(Product_Price.Text);
				}
				catch (Exception)
				{
					MessageBox.Show("please enter amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				if (price > 0)
				{
					try
					{
						if (isImageUpdated)
						{
							//Delete old file first then update 
							if (Product_ShortCode.BackColor != Color.Red)
							{
								if (Product_ShortCode.Text == "")
								{
									if (product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, price, oldPath, newPath, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, ""))
									{
										ClearData();
										product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
									}
								}
								else
								{
									if (product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, price, oldPath, newPath, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, Product_ShortCode.Text))
									{
										ClearData();
										product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
									}
								}
							}
							else
							{
								MessageBox.Show("please type valid ShortCode or type nothing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							if (Product_ShortCode.BackColor != Color.Red)
							{
								if (Product_ShortCode.Text == "")
								{
									if (product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, price, null, oldPath, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, ""))
									{
										ClearData();
										product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
									}
								}
								else
								{
									if (product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, price, null, oldPath, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, Product_ShortCode.Text))
									{
										ClearData();
										product.GetData(Grd_Product, "select Products.Id,Products.Name,Products.Price,Products.ImageUrl,Categories.Id as CategoryID,Products.UnitID,Products.ShortCode,Categories.Name as Category from Products inner join Categories on Products.CategoryID = Categories.Id");
									}
								}
							}
							else
							{
								MessageBox.Show("please type valid ShortCode or type nothing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("please type a valid Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void Browse_Button_Click(object sender, EventArgs e)
		{
			opf.Filter = "Choose Image(*.jpg;*.png;)|*.jpg;*.png;";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				using (var fs = new FileStream(opf.FileName, FileMode.Open))
				{
					var bmp = new Bitmap(fs);
					Product_Image.Image = (Bitmap)bmp.Clone();
					isImageUpdated = true;
					newPath = opf.FileName;
				}
			}
			else
			{
				isImageUpdated = false;
				newPath = "";
			}   
		}

		private void Product_Search_TextChanged(object sender, EventArgs e)
		{
			if (Product_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				product.SearchProduct(Grd_Product, Product_Search.Text);
			}
		}

		private void Grd_Product_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int index = e.RowIndex;
				string path = Path.GetDirectoryName(Application.StartupPath);
				string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
				if (index >= 0)
				{
					DataGridViewRow selectedRow = Grd_Product.Rows[index];
					Product_ID.Text = Grd_Product.Rows[e.RowIndex].Cells[0].Value.ToString();
					Product_Name.Text = selectedRow.Cells[1].Value.ToString();
					Product_Price.Text = selectedRow.Cells[2].Value.ToString();
					if (selectedRow.Cells[5].Value.ToString() == "Unit")
					{
						Product_Unit.SelectedIndex = 1;
					}
					else
					{
						Product_Unit.SelectedIndex = 0;
					}
					Product_Category.SelectedValue = selectedRow.Cells[4].Value;
					if (selectedRow.Cells[3].Value.ToString() == "")
					{
						Product_Image.Image = null;
						oldPath = "";
					}
					else
					{
						using (var fs = new FileStream(newpath + selectedRow.Cells[3].Value.ToString(), FileMode.Open))
						{
							var bmp = new Bitmap(fs);
							Product_Image.Image = (Bitmap)bmp.Clone();
							oldPath = selectedRow.Cells[3].Value.ToString();
						}
					}

					if (selectedRow.Cells[6].Value.ToString() == "")
					{
						Product_ShortCode.Text = selectedRow.Cells[6].Value.ToString();
						oldShortCode = new char();
					}
					else
					{
						Product_ShortCode.Text = selectedRow.Cells[6].Value.ToString();
						oldShortCode = Convert.ToChar(Product_ShortCode.Text);
					}
					
					//}
				}
			}
			catch (Exception ex)
			{
				//	MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Product_ShortCode_Click(object sender, EventArgs e)
		{
			Product_ShortCode.Text = "";
			Product_ShortCode.BackColor = SystemColors.Window;
		}

		private void Product_ShortCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				//e.Handled = true;
				if (oldShortCode == e.KeyChar)
				{

				}
				else
				{
					if (product.IsShortExist(e.KeyChar))
					{
						MessageBox.Show("ShortCode already exist try another one", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Product_ShortCode.BackColor = Color.Red;
					}
					else
					{
						Product_ShortCode.BackColor = SystemColors.Window;
					}
				}
			}
			if (!char.IsLetterOrDigit(e.KeyChar))
			{
				if (oldShortCode == e.KeyChar)
				{

				}
				else
				{
					if (product.IsShortExist(e.KeyChar))
					{
						MessageBox.Show("ShortCode already exist try another one", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Product_ShortCode.BackColor = Color.Red;
					}
					else
					{
						Product_ShortCode.BackColor = SystemColors.Window;
					}
				}
			}
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

		}

		private void Product_Search_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			if (!char.IsLetterOrDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			if (e.KeyChar == (char)Keys.Back)
			{
				e.Handled = false;
			}
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void Product_Name_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			if (!char.IsLetterOrDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			if (e.KeyChar == (char)Keys.Back)
			{
				e.Handled = false;
			}
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void Product_Price_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (e.KeyChar == (char)Keys.Back)
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
	}
}

