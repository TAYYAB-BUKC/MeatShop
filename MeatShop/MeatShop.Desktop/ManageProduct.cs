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

		public ManageProduct()
		{
			InitializeComponent();
			unit.FillCombo(Product_Unit);
			category.FillCombo(Product_Category);
			product.GetData(Grd_Product, "select * from Products");
		}

		private void ClearData()
		{
			Product_ID.Text = "";
			Product_Name.Text = "";
			Product_Price.Text = "";
			Product_Image.Image = null;
			unit.FillCombo(Product_Unit);
			category.FillCombo(Product_Category);
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
					FileInfo fileInfo = new FileInfo(oldPath);
					product.DeleteProduct(Convert.ToInt32(Product_ID.Text),fileInfo,oldPath);
					ClearData();
					product.GetData(Grd_Product, "select * from Products");
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
							if (product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, price, oldPath, newPath, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue)))
							{
								ClearData();
								product.GetData(Grd_Product, "select * from Products");
							}
						}
						else
						{
							if (product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, price, null, oldPath, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue)))
							{
								ClearData();
								product.GetData(Grd_Product, "select * from Products");
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

		private void Grd_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int index = e.RowIndex;
				if (index > -1)
				{
					DataGridViewRow selectedRow = Grd_Product.Rows[index];
					Product_ID.Text = Grd_Product.Rows[e.RowIndex].Cells[0].Value.ToString();
					Product_Name.Text = selectedRow.Cells[1].Value.ToString();
					Product_Price.Text = selectedRow.Cells[2].Value.ToString();
					Product_Unit.SelectedValue = selectedRow.Cells[5].Value;
					Product_Category.SelectedValue = selectedRow.Cells[4].Value;
					//if (selectedRow.Cells[3].Value.ToString() == "")
					//{
					//	Product_Image.Image = null;
					//	oldPath = "";
					//}
					//else
					//{
					//using (var file = selectedRow.Cells[3].Value.ToString())
					//{
					//	Product_Image.Image = file;
					//	oldPath = selectedRow.Cells[3].Value.ToString();
					//}

					using (var fs = new System.IO.FileStream(selectedRow.Cells[3].Value.ToString(), FileMode.Open))
					{
						var bmp = new Bitmap(fs);
						Product_Image.Image = (Bitmap)bmp.Clone();
						oldPath = selectedRow.Cells[3].Value.ToString();
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
	}
}

