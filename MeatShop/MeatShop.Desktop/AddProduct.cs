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
					if (isImageSelected)
					{
						if (product.AddProduct(Product_Name.Text, price, imageUrl, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue)))
						{
							ClearData();
						}
					}
					else
					{
						if (product.AddProduct(Product_Name.Text, price, finalPath, Convert.ToInt32(Product_Category.SelectedValue), Convert.ToInt32(Product_Unit.SelectedValue)))
						{
							ClearData();
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Something went wrong Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				MessageBox.Show("please type a valid Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				using (var fs = new FileStream(opf.FileName, FileMode.Open))
				{
					var bmp = new Bitmap(fs);
					Product_Image.Image = (Bitmap)bmp.Clone();
					isImageSelected = true;
					imageUrl = opf.FileName;
				}
			}
		}
	}
}
