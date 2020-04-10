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
			product.FillCombo(Stock_Product);
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

			if (Convert.ToInt32(Stock_Price.Text) > 0)
			{
				try
				{
					ProductEntity productEntity = product.IsExist(Convert.ToInt32(Stock_Product.SelectedValue));
					if (productEntity.Id > 0)
					{
						//update stock quantity
						//stock.UpdateStock(Convert.ToInt32(Stock_Product.SelectedValue), Convert.ToInt32(Stock_Quantity.Text),productEntity);
						if (oldPrice != Convert.ToInt32(Stock_Price.Text))
						{
							stock.UpdateStock(Convert.ToInt32(Stock_Quantity.Text), productEntity, Convert.ToInt32(Stock_Price.Text), Convert.ToInt32(Stock_Product.SelectedValue), true);
							ClearData();
						}
						else
						{
							stock.UpdateStock(Convert.ToInt32(Stock_Quantity.Text), productEntity, Convert.ToInt32(Stock_Price.Text), Convert.ToInt32(Stock_Product.SelectedValue),false);
							ClearData();

						}

					}
					else
					{
						if (oldPrice != Convert.ToInt32(Stock_Price.Text))
						{
							//add stock
							stock.AddStock(Convert.ToInt32(Stock_Product.SelectedValue), Convert.ToInt32(Stock_Quantity.Text), Convert.ToInt32(Stock_Price.Text),true);
							ClearData();
						}
						else
						{
							stock.AddStock(Convert.ToInt32(Stock_Product.SelectedValue), Convert.ToInt32(Stock_Quantity.Text), Convert.ToInt32(Stock_Price.Text),false);
							ClearData();
						}
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
		}
		private void ClearData()
		{
			Stock_Price.Text = "";
			Stock_Quantity.Text = "";
			product.FillCombo(Stock_Product);

		}

		//private void Stock_Product_SelectedIndexChanged(object sender, EventArgs e)
		//{


		//}

		private void Stock_Product_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Stock_Product.Text.Equals("System.Data.DataRowView"))
			{

			}
			else 
			{
				int price = product.GetDetails(Convert.ToInt32(Stock_Product.SelectedValue));
				if (price > -1)
				{
					Stock_Price.Text = Convert.ToString(price);
					oldPrice = price;
				}
				
			}
		}
	}
}
