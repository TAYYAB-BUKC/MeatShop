using MeatShop.Database;
using System;
using System.Windows.Forms;

namespace MeatShop
{
	public partial class AddStock : Form
	{
		Product product = new Product();
		Stock stock = new Stock();
		int oldPrice;
		public AddStock()
		{
			InitializeComponent();
			//product.FillCombo(Stock_Product);
			//if (Stock_Product.Items.Count > 0)
			//{
			//	Stock_Product.SelectedIndex = -1;
			Stock_Product.SelectedIndex = 0;
			//}
		}
		private void Save_Button_Click(object sender, EventArgs e)
		{
			//int price = -1;
			//try
			//{
			//	price = Convert.ToInt32(Stock_Price.Text);
			//}
			//catch (Exception)
			//{
			//	MessageBox.Show("please enter amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}

			ProductEntity productEntity = product.IsExist(Stock_Product.Text.ToString());

			if (productEntity.Price == 0 && Stock_Price.Text == "")
			{
				MessageBox.Show("Please Enter the price", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (Convert.ToInt32(Stock_Price.Text) > 0)
			{
				try
				{
					if (productEntity.Id > 0)
					{
						//update stock quantity
						//stock.UpdateStock(Convert.ToInt32(Stock_Product.SelectedValue), Convert.ToInt32(Stock_Quantity.Text),productEntity);
						//if (oldPrice != Convert.ToInt32(Stock_Price.Text))
						//{
							stock.UpdateStock(Convert.ToInt32(Stock_Quantity.Text), productEntity, productEntity.Price, Stock_Product.Text.ToString());
							ClearData();
						//}
						//else
						//{
						//	stock.UpdateStock(Convert.ToInt32(Stock_Quantity.Text), productEntity, Convert.ToInt32(Stock_Price.Text), Convert.ToInt32(Stock_Product.SelectedValue),false);
						//	ClearData();

						//}

					}
					else
					{
						//if (oldPrice != Convert.ToInt32(Stock_Price.Text))
						//{
							//add stock
							stock.AddStock(Stock_Product.Text.ToString(), Convert.ToInt32(Stock_Quantity.Text), productEntity.Price);
							ClearData();
						//}
						//else
						//{
							//stock.AddStock(Convert.ToInt32(Stock_Product.SelectedValue), Convert.ToInt32(Stock_Quantity.Text), Convert.ToInt32(Stock_Price.Text),false);
							//ClearData();
						//}
					}
				}
				catch (Exception ex)
				{
					//MessageBox.Show("Something went wrong Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				//}
				//else
				//{
				//	MessageBox.Show("please type a valid Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}

				//	MessageBox.Show("Unit: "+ Product_Unit.SelectedValue+"Category "+Product_Category.SelectedValue, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

			else
			{
				try
				{
					if (productEntity.Id > 0)
					{
						//update stock quantity
						//stock.UpdateStock(Convert.ToInt32(Stock_Product.SelectedValue), Convert.ToInt32(Stock_Quantity.Text),productEntity);
						//if (oldPrice != Convert.ToInt32(Stock_Price.Text) && Stock_Price.Text != "0")
						//{
						stock.UpdateStock(Convert.ToInt32(Stock_Quantity.Text), productEntity, Convert.ToInt32(Stock_Price.Text), Stock_Product.Text.ToString());
						ClearData();
						//}
						//else
						//{
						//	stock.UpdateStock(Convert.ToInt32(Stock_Quantity.Text), productEntity, Convert.ToInt32(Stock_Price.Text), Convert.ToInt32(Stock_Product.SelectedValue), false);
						//	ClearData();

						//}

					}
					else
					{
						//if (oldPrice != Convert.ToInt32(Stock_Price.Text))
						//{
						//add stock
						stock.AddStock(Stock_Product.Text.ToString(), Convert.ToInt32(Stock_Quantity.Text), Convert.ToInt32(Stock_Price.Text));
						ClearData();
						//}
						//else
						//{
						//	stock.AddStock(Stock_Product.Text.ToString(), Convert.ToInt32(Stock_Quantity.Text), Convert.ToInt32(Stock_Price.Text));
						//	ClearData();
						//}
					}
				}
				catch (Exception ex)
				{
					//MessageBox.Show("Something went wrong Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ClearData()
		{
			Stock_Price.Text = "";
			Stock_Quantity.Text = "";
			//product.FillCombo(Stock_Product);
			Stock_Product.SelectedIndex = 0;

		}

		//private void Stock_Product_SelectedIndexChanged(object sender, EventArgs e)
		//{



		//}

		//private void Stock_Product_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	if (Stock_Product.Text.Equals("System.Data.DataRowView"))
		//	{

		//	}
		//	else
		//	{
		//		int price = product.GetDetails(Convert.ToInt32(Stock_Product.SelectedValue));
		//		if (price > -1)
		//		{
		//			Stock_Price.Text = Convert.ToString(price);
		//			oldPrice = price;
		//		}

		//	}
		//}

		private void Stock_Price_KeyPress(object sender, KeyPressEventArgs e)
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

		private void Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
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
