using MeatShop.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop
{
	public partial class AddProduct : Form
	{
		OpenFileDialog opf = new OpenFileDialog();
		bool isImageSelected = false;
		string imageUrl = String.Empty;
		Category category = new Category();
		Unit unit = new Unit();
		Product product = new Product();
		string finalPath;
		public AddProduct()
		{
			InitializeComponent();
			unit.FillCombo(Product_Unit);
			category.FillCombo(Product_Category);
			string path = Path.GetDirectoryName(Application.StartupPath);
			string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
			finalPath = newpath + "\\Resources\\Default_Image_Thumbnail.png";
			Product_Image.Image = Image.FromFile(finalPath);
		}
		private void Save_Button_Click(object sender, EventArgs e)
		{

			try
			{
				if (isImageSelected)
				{
					product.AddProduct(Product_Name.Text, Convert.ToInt32(Product_Price.Text), imageUrl, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue));
					ClearData();
				}
				else
				{
					product.AddProduct(Product_Name.Text, Convert.ToInt32(Product_Price.Text), finalPath, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue));
					ClearData();
				}


			}
			catch (Exception)
			{
				MessageBox.Show("Something went wrong Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		//	MessageBox.Show("Unit: "+ Product_Unit.SelectedValue+"Category "+Product_Category.SelectedValue, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void ClearData()
		{
			Product_Name.Text = "";
			Product_Price.Text = "";
			Product_Category.Text = "";
			Product_Unit.Text = "";
			string path = Path.GetDirectoryName(Application.StartupPath);
			string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
			string finalPath = newpath + "\\Resources\\Default_Image_Thumbnail.png";
			Product_Image.Image = Image.FromFile(finalPath);
			isImageSelected = false;
			imageUrl = "";

		}
		private void Browse_Button_Click(object sender, EventArgs e)
		{
			opf.Filter = "Choose Image(*.jpg;*.png;)|*.jpg;*.png;";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				Product_Image.Image = Image.FromFile(opf.FileName);
				isImageSelected = true;
				imageUrl = opf.FileName;
			}
		}
	}
}
