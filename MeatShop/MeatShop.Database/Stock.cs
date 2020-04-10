using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class Stock
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		Product product = new Product();
		public void UpdateStock(int quantity, ProductEntity productEntity, int price, int productID, bool isPriceUpdated)
		{
			//int oldQuantity = productEntity.oldQuantity;
			//int id = productEntity.Id;
			//bool check = false;
			//using (SQLiteConnection sql = new SQLiteConnection(con))
			//{
			//	try
			//	{
			//		sql.Open();
			//		SQLiteCommand cmd = new SQLiteCommand("select Id,Quantity from Stock where Product_Id = @Id", sql);
			//		cmd.Parameters.AddWithValue("@Id", productID);
			//		SQLiteDataReader reader = cmd.ExecuteReader();
			//		while (reader.Read())
			//		{
			//			id = reader.GetInt32(0);
			//			oldQuantity = reader.GetInt32(1);
			//			check = true;
			//		}
			//		sql.Close();
			//	}
			//	catch (Exception ex)
			//	{
			//		MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}

			if (AddStockUpdate(quantity, price, productEntity.oldQuantity))
			{
				bool isSuccess = false;
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					try
					{
						//if (check)
						//{
						sql.Open();
						int finalQuantity = productEntity.oldQuantity + quantity;
						SQLiteCommand cmd = new SQLiteCommand("update Stock set Quantity=@Quantity where Id=@Id", sql);
						cmd.Parameters.AddWithValue("@Quantity", finalQuantity);
						cmd.Parameters.AddWithValue("@Id", productEntity.Id);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Stock Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
						sql.Close();
						isSuccess = true;
						//}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						isSuccess = false;
					}
				}

				if (isPriceUpdated)
				{
					if (isSuccess)
					{
						product.UpdatePrice(productID, price);
					}
				}
			}
		}

		public void AddStock(int productID, int quantity,int price,bool isPriceUpdated)
		{
			if (AddStockUpdate(quantity,price,0))
			{
				bool isSuccess = false;
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					try
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("insert into Stock(Product_Id,Quantity) values(@Product_Id,@Quantity)", sql);
						cmd.Parameters.AddWithValue("@Product_Id", productID);
						cmd.Parameters.AddWithValue("@Quantity", quantity);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Stock Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
						sql.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (isPriceUpdated)
				{
					if (isSuccess)
					{
						product.UpdatePrice(productID, price);
					}
				}
			}
		}

		public bool AddStockUpdate(int newQuantity,int price, int oldQuantity)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("insert into Stock_Update(Quantity,Price,Datetime,Last_Available) values(@Quantity,@Price,@Datetime,@Last_Available)", sql);
					cmd.Parameters.AddWithValue("@Quantity", newQuantity);
					cmd.Parameters.AddWithValue("@Datetime", DateTime.Now.Date.ToOADate());
					cmd.Parameters.AddWithValue("@Price", price);
					cmd.Parameters.AddWithValue("@Last_Available", oldQuantity);
					cmd.ExecuteNonQuery();
					sql.Close();
					return true;
				}
				catch (Exception ex)                                                                                                                                                                                                                                                                                                                                                                                                              
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

			}

		}
	}
}
