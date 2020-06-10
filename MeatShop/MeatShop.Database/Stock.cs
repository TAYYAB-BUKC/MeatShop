using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

			if (AddStockUpdate(quantity, price, productEntity.oldQuantity,productID))
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
			if (AddStockUpdate(quantity,price,0,productID))
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

		public bool AddStockUpdate(int newQuantity,int price, int oldQuantity,int productID)
		{
			int date = Convert.ToInt32(DateTime.Now.Date.ToOADate());
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("insert into Stock_Update(productID,Quantity,Price,Datetime,Last_Available) values(@productID,@Quantity,@Price,@Datetime,@Last_Available)", sql);
					cmd.Parameters.AddWithValue("@productID", productID);
					cmd.Parameters.AddWithValue("@Quantity", newQuantity);
					cmd.Parameters.AddWithValue("@Datetime", date);
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

		public GetSpecificStock GetStock(string name, string date)
		{
			GetSpecificStock stock = new GetSpecificStock();
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select sum(Quantity) as Quantity,(sum(Price * Quantity)) as Price from stock_update where ProductID=@ProductID and Datetime=@Datetime", sql);
					cmd.Parameters.AddWithValue("@ProductID", name);
					cmd.Parameters.AddWithValue("@Datetime", date);
					cmd.ExecuteNonQuery();
					DataTable dt = new DataTable();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow row in dt.Rows)
						{
							if (row["Quantity"].ToString() == "")
							{
								row["Quantity"] = 0;
								row["Price"] = 0;
							}
							else
							{
								stock.Quantity = Convert.ToDouble(row["Quantity"]);
								stock.Price = Convert.ToDouble(row["Price"]);
							}
						}

						sql.Close();
						return stock;
					}
					else
					{
						sql.Close();
						return stock;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception Occurs in datagridView Code.........." + ex.Message);
				return stock;
			}
		}

		public int GetRemainingStock(string product)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select Quantity from Stock where Product_Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", product);
					SQLiteDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						ProductEntity productEntity = new ProductEntity();
						while (reader.Read())
						{
							productEntity.oldQuantity = reader.GetInt32(0);
						}
						sql.Close();
						return productEntity.oldQuantity;

					}
					else
					{
						sql.Close();
						return 0;
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql.Close();
					return 0;
				}

			}
		}

		public bool DateWiseStock(BunifuCustomDataGrid dataGrid, int date)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select Stock_Update.Id, Stock.Product_Id as Name, Stock_Update.Quantity, Stock_Update.Price, Stock_Update.Datetime, Stock_Update.Last_Available, Stock.Quantity as StockQuantity, Stock.Product_Id as ProductID from Stock inner join Stock_Update on Stock_Update.ProductID = Stock.Product_Id where Stock_Update.Datetime = @Datetime order by Stock_Update.Datetime", sql);
				da.SelectCommand.Parameters.AddWithValue("@Datetime", date);
				DataTable dt = new DataTable();
				if (da != null)
				{
					da.Fill(dt);
				}
				if (dt.Rows.Count > 0)
				{
					foreach (DataRow row in dt.Rows)
					{
						double sdate = Convert.ToDouble(row["Datetime"]);
						var sfinal = DateTime.FromOADate(sdate);
						row["Datetime"] = sfinal.ToString("dd-MM-yyyy");
					}
					dataGrid.DataSource = dt;
					sql.Close();
					dataGrid.Columns["StockQuantity"].Visible = false;
					dataGrid.Columns["ProductID"].Visible = false;
					dataGrid.Columns["Id"].Visible = false;

					return true;

				}
				else
				{
					sql.Close();
					return false;
				}
			}
		}

		public bool AllStock(BunifuCustomDataGrid dataGrid)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select Stock_Update.Id, Stock.Product_Id as Name, Stock_Update.Quantity, Stock_Update.Price, Stock_Update.Datetime, Stock_Update.Last_Available, Stock.Quantity as StockQuantity, Stock.Product_Id as ProductID from Stock inner join Stock_Update on Stock_Update.ProductID = Stock.Product_Id order by Stock_Update.Datetime", sql);
				DataTable dt = new DataTable();
				if (da != null)
				{
					da.Fill(dt);
				}
				if (dt.Rows.Count > 0)
				{
					foreach (DataRow row in dt.Rows)
					{
						double sdate = Convert.ToDouble(row["Datetime"]);
						var sfinal = DateTime.FromOADate(sdate);
						row["Datetime"] = sfinal.ToString("dd-MM-yyyy");
					}

					dataGrid.DataSource = dt;
					sql.Close();
					dataGrid.Columns["StockQuantity"].Visible = false;
					dataGrid.Columns["ProductID"].Visible = false;
					dataGrid.Columns["Id"].Visible = false;

					return true;

				}
				else
				{
					sql.Close();
					return false;
				}
			}
		}
	}

	public class GetSpecificStock
	{
		public Double Quantity { get; set; }
		public Double Price { get; set; }
	}
}
