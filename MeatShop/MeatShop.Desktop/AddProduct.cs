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
		//string finalPath;
		public AddProduct()
		{
			InitializeComponent();
			//unit.FillCombo(Product_Unit);
			Product_Unit.SelectedIndex = 0;
			category.FillCombo(Product_Category);
			//string path = Path.GetDirectoryName(Application.StartupPath);
			//string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
			//finalPath = newpath + "\\Resources\\Default_Image_Thumbnail.png";
			//Product_Image.Image = Image.FromFile(finalPath);
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
						if (Product_ShortCode.BackColor != Color.Red)
						{
							if (Product_ShortCode.Text == "")
							{
								if (product.AddProduct(Product_Name.Text, price, imageUrl, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, ""))
								{
									ClearData();
								}
							}
							else
							{
								if (product.AddProduct(Product_Name.Text, price, imageUrl, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, Product_ShortCode.Text))
								{
									ClearData();
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
								if (product.AddProduct(Product_Name.Text, price, imageUrl, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, ""))
								{
									ClearData();
								}
							}
							else
							{
								if (product.AddProduct(Product_Name.Text, price, imageUrl, Convert.ToInt32(Product_Category.SelectedValue), Product_Unit.Text, Product_ShortCode.Text))
								{
									ClearData();
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
					//	MessageBox.Show("Something went wrong Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			Product_Category.SelectedIndex = 0;
			Product_Unit.SelectedIndex = 0;
			//string path = Path.GetDirectoryName(Application.StartupPath);
			//string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
			//string finalPath = newpath + "\\Resources\\Default_Image_Thumbnail.png";
			//Product_Image.Image = Image.FromFile(finalPath);
			Product_Image.Image = null;
			isImageSelected = false;
			imageUrl = "";
			Product_ShortCode.Text = "";

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

		private void Product_ShortCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			//int isNumber = 0;
			//e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				//e.Handled = true;
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
			if (!char.IsLetterOrDigit(e.KeyChar))
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
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		private void Product_ShortCode_Click(object sender, EventArgs e)
		{
			Product_ShortCode.Text = "";
			Product_ShortCode.BackColor = SystemColors.Window;
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

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
