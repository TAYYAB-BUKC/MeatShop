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
		//DataTable businessData = new DataTable();
		//Business business = new Business();
		bool isError = false;
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
				if (MessageBox.Show("Are you sure you want to Delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					//businessData = business.DeleteData(businessData, Convert.ToInt32(Product_ID.Text));
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
			try
			{
				if (isImageUpdated)
				{
					//Delete old file first then update 
					product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, Convert.ToInt32(Product_Price.Text), oldPath,newPath, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue));
					ClearData();
					product.GetData(Grd_Product, "select * from Products");
				}
				else
				{
					//businessData = business.UpdateData(businessData, Convert.ToInt32(Product_ID.Text), Product_Name.Text, Product_Price.Text, Business_Email.Text, Business_Address.Text, Product_Unit.Text, Product_Category.Text, oldPath);
					product.UpdateProduct(Convert.ToInt32(Product_ID.Text), Product_Name.Text, Convert.ToInt32(Product_Price.Text), null, oldPath, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue));
					ClearData();
					product.GetData(Grd_Product, "select * from Products");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool Checking()
		{
			//if (businessData.Rows.Count > 0)
			//{
			//	string searchExpression = string.Format("Name like '{0}%'", Product_Search.Text);

			//	DataRow[] foundRows = businessData.Select(searchExpression);
			//	DataTable dt = business.GenerateTempTableSchema();
			//	foreach (var row in foundRows)
			//	{
			//		dt.ImportRow(row);	
			//	}
			//	Grd_Product.DataSource = dt;
			//	return true;
			//}
			//else
			//{
			//	return false;
			//}
			return false;
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

