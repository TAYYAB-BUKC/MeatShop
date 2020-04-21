using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class Product
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		bool isError = false;

		public bool AddProduct(string name, int price, string imageurl, int categoryID, string unitID,char shortCode)
		{
			if (name == "" || price < -1 || categoryID < 0)
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				if (imageurl == "")
				{
					try
					{
						using (SQLiteConnection sql = new SQLiteConnection(con))
						{
							sql.Open();
							SQLiteCommand cmd = new SQLiteCommand("insert into Products(Name,Price,ImageUrl,CategoryID,UnitID,ShortCode) values(@Name,@Price,@ImageUrl,@CategoryID,@UnitID,@ShortCode)", sql);
							cmd.Parameters.AddWithValue("@Name", name);
							cmd.Parameters.AddWithValue("@Price", price);
							cmd.Parameters.AddWithValue("@ImageUrl", imageurl);
							cmd.Parameters.AddWithValue("@CategoryID", categoryID);
							cmd.Parameters.AddWithValue("@UnitID", unitID);
							cmd.Parameters.AddWithValue("@ShortCode", shortCode);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							sql.Close();
							return true;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				else
				{
					string finalPath = String.Empty;
					try
					{
						string path = Path.GetDirectoryName(Application.StartupPath);
						string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
						string relativepPath = "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
						finalPath = newpath + relativepPath;
						File.Copy(imageurl, finalPath); 
						using (SQLiteConnection sql = new SQLiteConnection(con))
						{
							sql.Open();
							SQLiteCommand cmd = new SQLiteCommand("insert into Products(Name,Price,ImageUrl,CategoryID,UnitID,ShortCode) values(@Name,@Price,@ImageUrl,@CategoryID,@UnitID,@ShortCode)", sql);
							cmd.Parameters.AddWithValue("@Name", name);
							cmd.Parameters.AddWithValue("@Price", price);
							cmd.Parameters.AddWithValue("@ImageUrl", relativepPath);
							cmd.Parameters.AddWithValue("@CategoryID", categoryID);
							cmd.Parameters.AddWithValue("@UnitID", unitID);
							cmd.Parameters.AddWithValue("@ShortCode", shortCode);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							sql.Close();
							return true;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}
		}

		public bool AddProduct(string name, int price, string imageurl, int categoryID, string unitID,string shortCode)
		{
			if (name == "" || price < -1 || categoryID < 0)
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				if (imageurl == "")
				{
					try
					{
						using (SQLiteConnection sql = new SQLiteConnection(con))
						{
							sql.Open();
							SQLiteCommand cmd = new SQLiteCommand("insert into Products(Name,Price,ImageUrl,CategoryID,UnitID,ShortCode) values(@Name,@Price,@ImageUrl,@CategoryID,@UnitID,@ShortCode)", sql);
							cmd.Parameters.AddWithValue("@Name", name);
							cmd.Parameters.AddWithValue("@Price", price);
							cmd.Parameters.AddWithValue("@ImageUrl", imageurl);
							cmd.Parameters.AddWithValue("@CategoryID", categoryID);
							cmd.Parameters.AddWithValue("@UnitID", unitID);
							cmd.Parameters.AddWithValue("@ShortCode", shortCode);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							sql.Close();
							return true;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				else
				{
					string finalPath = String.Empty;
					try
					{
						string path = Path.GetDirectoryName(Application.StartupPath);
						string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
						string relativepPath = "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
						finalPath = newpath + relativepPath;
						File.Copy(imageurl, finalPath); 
						using (SQLiteConnection sql = new SQLiteConnection(con))
						{
							sql.Open();
							SQLiteCommand cmd = new SQLiteCommand("insert into Products(Name,Price,ImageUrl,CategoryID,UnitID,ShortCode) values(@Name,@Price,@ImageUrl,@CategoryID,@UnitID,@ShortCode)", sql);
							cmd.Parameters.AddWithValue("@Name", name);
							cmd.Parameters.AddWithValue("@Price", price);
							cmd.Parameters.AddWithValue("@ImageUrl", relativepPath);
							cmd.Parameters.AddWithValue("@CategoryID", categoryID);
							cmd.Parameters.AddWithValue("@UnitID", unitID);
							cmd.Parameters.AddWithValue("@ShortCode", shortCode);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							sql.Close();
							return true;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}
		}

		public ProductEntity IsExist(int id)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select * from Stock where Product_Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					SQLiteDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						ProductEntity productEntity = new ProductEntity();
						while (reader.Read())
						{
							productEntity.Id = reader.GetInt32(0);
							productEntity.oldQuantity = reader.GetInt32(2);
						}
						sql.Close();
						return productEntity;

					}
					else
					{
						sql.Close();
						return new ProductEntity();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql.Close();
					return new ProductEntity();
				}

			}
		}

		public void GetData(BunifuCustomDataGrid dataGrid, string query)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand(query, sql);
					cmd.ExecuteNonQuery();
					DataTable dt = new DataTable();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);
					dataGrid.DataSource = dt;
					sql.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception Occurs in datagridView Code.........." + ex.Message);
			}
		}

		public void SearchProduct(BunifuCustomDataGrid dataGrid, string name)
		{
			if (name.Length > 0)
			{
				if (Checking(dataGrid, name))
				{
				}
				else
				{
					if (!isError)
					{
						MessageBox.Show("No Record Found For this Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						isError = true;
					}
				}

			}
			else if (name.Length == 0)
			{
				GetData(dataGrid, "select * from Products");
			}
		}

		private bool Checking(BunifuCustomDataGrid dataGrid, string name)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Products where Name like '" + name + "%'", sql);
				//da.SelectCommand.Parameters.AddWithValue("@Name", txt_search.Text);
				DataTable dt = new DataTable();
				if (da != null)
				{
					da.Fill(dt);
				}
				if (dt.Rows.Count > 0)
				{
					dataGrid.DataSource = dt;
					sql.Close();

					return true;
				}
				else
				{
					sql.Close();
					return false;
				}
			}
		}
		//public bool UpdateProduct(int id, string name, int price, string oldPath, string newPath, int categoryID, string unitID,char shortCode)
		//{
		//	if (name == "" || price < -1 || categoryID < 0)
		//	{
		//		MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//		return false;
		//	}
		//	else
		//	{
		//		if (oldPath == null)
		//		{
		//			try
		//			{
		//				using (SQLiteConnection sql = new SQLiteConnection(con))
		//				{
		//					sql.Open();
		//					SQLiteCommand cmd = new SQLiteCommand("update Products set Name=@Name,Price=@Price,ImageUrl=@ImageUrl,CategoryID=@CategoryID,UnitID=@UnitID,ShortCode=@ShortCode where Id=@Id", sql);
		//					cmd.Parameters.AddWithValue("@Name", name);
		//					cmd.Parameters.AddWithValue("@Price", price);
		//					cmd.Parameters.AddWithValue("@ImageUrl", newPath);
		//					cmd.Parameters.AddWithValue("@CategoryID", categoryID);
		//					cmd.Parameters.AddWithValue("@UnitID", unitID);
		//					cmd.Parameters.AddWithValue("@ShortCode", shortCode);
		//					cmd.Parameters.AddWithValue("@Id", id);
		//					cmd.ExecuteNonQuery();
		//					MessageBox.Show("Product Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//					sql.Close();
		//					return true;
		//				}
		//			}
		//			catch (Exception ex)
		//			{
		//				//MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//				return false;
		//			}
		//		}
		//		//else
		//		//{ 
		//		//if (File.Exists(oldPath))
		//		//{
		//		//	File.Delete(oldPath);
		//		//}
		//		else
		//		{
		//			string finalPath = String.Empty;
		//			string path = Path.GetDirectoryName(Application.StartupPath);
		//			string newpath = path.Substring(0, (Application.StartupPath.Length - 10));

		//			if (File.Exists(newpath + oldPath))
		//			{
		//				try
		//				{
		//					GC.Collect();
		//					GC.WaitForPendingFinalizers();
		//					File.Delete(newpath + oldPath);

		//					string relativepPath = "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
		//					finalPath = newpath + relativepPath;
		//					File.Copy(newPath, finalPath);

		//					using (SQLiteConnection sql = new SQLiteConnection(con))
		//					{
		//						sql.Open();
		//						SQLiteCommand cmd = new SQLiteCommand("update Products set Name=@Name,Price=@Price,ImageUrl=@ImageUrl,CategoryID=@CategoryID,UnitID=@UnitID,ShortCode=@ShortCode where Id=@Id", sql);
		//						cmd.Parameters.AddWithValue("@Name", name);
		//						cmd.Parameters.AddWithValue("@Price", price);
		//						cmd.Parameters.AddWithValue("@ImageUrl", relativepPath);
		//						cmd.Parameters.AddWithValue("@CategoryID", categoryID);
		//						cmd.Parameters.AddWithValue("@UnitID", unitID);
		//						cmd.Parameters.AddWithValue("@ShortCode", shortCode);
		//						cmd.Parameters.AddWithValue("@Id", id);
		//						cmd.ExecuteNonQuery();
		//						MessageBox.Show("Product Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//						sql.Close();
		//						return true;
		//					}
		//				}
		//				catch (Exception ex)
		//				{
		//					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//					return false;
		//				}
		//			}
		//			return false;
		//		}
		//	}
		//}

		public bool UpdateProduct(int id, string name, int price, string oldPath, string newPath, int categoryID, string unitID, string shortCode)
		{
			if (name == "" || price < -1 || categoryID < 0)
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				if (oldPath == null)
				{
					try
					{
						using (SQLiteConnection sql = new SQLiteConnection(con))
						{
							sql.Open();
							SQLiteCommand cmd = new SQLiteCommand("update Products set Name=@Name,Price=@Price,ImageUrl=@ImageUrl,CategoryID=@CategoryID,UnitID=@UnitID,ShortCode=@ShortCode where Id=@Id", sql);
							cmd.Parameters.AddWithValue("@Name", name);
							cmd.Parameters.AddWithValue("@Price", price);
							cmd.Parameters.AddWithValue("@ImageUrl", newPath);
							cmd.Parameters.AddWithValue("@CategoryID", categoryID);
							cmd.Parameters.AddWithValue("@UnitID", unitID);
							cmd.Parameters.AddWithValue("@ShortCode", shortCode);
							cmd.Parameters.AddWithValue("@Id", id);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							sql.Close();
							return true;
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				//else
				//{ 
				//if (File.Exists(oldPath))
				//{
				//	File.Delete(oldPath);
				//}
				else
				{
					string finalPath = String.Empty;
					string path = Path.GetDirectoryName(Application.StartupPath);
					string newpath = path.Substring(0, (Application.StartupPath.Length - 10));

					if (File.Exists(newpath + oldPath))
					{
						try
						{
							GC.Collect();
							GC.WaitForPendingFinalizers();
							File.Delete(newpath + oldPath);

							string relativepPath = "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
							finalPath = newpath + relativepPath;
							File.Copy(newPath, finalPath);

							using (SQLiteConnection sql = new SQLiteConnection(con))
							{
								sql.Open();
								SQLiteCommand cmd = new SQLiteCommand("update Products set Name=@Name,Price=@Price,ImageUrl=@ImageUrl,CategoryID=@CategoryID,UnitID=@UnitID,ShortCode=@ShortCode where Id=@Id", sql);
								cmd.Parameters.AddWithValue("@Name", name);
								cmd.Parameters.AddWithValue("@Price", price);
								cmd.Parameters.AddWithValue("@ImageUrl", relativepPath);
								cmd.Parameters.AddWithValue("@CategoryID", categoryID);
								cmd.Parameters.AddWithValue("@UnitID", unitID);
								cmd.Parameters.AddWithValue("@ShortCode", shortCode);
								cmd.Parameters.AddWithValue("@Id", id);
								cmd.ExecuteNonQuery();
								MessageBox.Show("Product Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
								sql.Close();
								return true;
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return false;
						}
					}
					return false;
				}
			}
		}


		public void DeleteProduct(int id, FileInfo path, string oldPath)
		{
			bool isFileDeleted = false;
			try
			{
				if (!IsFileLocked(path))
				{
					string p = Path.GetDirectoryName(Application.StartupPath);
					string newpath = p.Substring(0, (Application.StartupPath.Length - 10));

					if (File.Exists(newpath + oldPath))
					{
						GC.Collect();
						GC.WaitForPendingFinalizers();
						File.Delete(newpath + oldPath);
						isFileDeleted = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (isFileDeleted)
				{
					using (SQLiteConnection sql = new SQLiteConnection(con))
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("delete from Products where Id = @Id", sql);
						cmd.Parameters.AddWithValue("@Id", id);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Product Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
						sql.Close();
					}
				}
				else
				{
					MessageBox.Show("Sorry file is used by another process so please try again later or try to close the application", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private Boolean IsFileLocked(FileInfo file)
		{
			FileStream stream = null;

			try
			{
				//Don't change FileAccess to ReadWrite, 
				//because if a file is in readOnly, it fails.
				stream = file.Open
				(
					FileMode.Open,
					FileAccess.Read,
					FileShare.None
				);
			}
			catch (IOException)
			{
				//the file is unavailable because it is:
				//still being written to
				//or being processed by another thread
				//or does not exist (has already been processed)
				return true;
			}
			finally
			{
				if (stream != null)
					stream.Close();
			}

			//file is not locked
			return false;
		}

		private DataTable GetData(string query)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				DataTable dt = new DataTable();
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand(query, sql);
					cmd.ExecuteNonQuery();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);
					sql.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception Occurs " + ex.Message);
				}
				return dt;
			}
		}

		public void FillCombo(ComboBox a)
		{
			DataTable dt = GetData("select Id,Name from Products");
			a.DataSource = dt;
			a.DisplayMember = "Name";
			a.ValueMember = "Id";
		}

		//	public bool GetDetails(TextBox price, int id)
		//	{
		//		using (SQLiteConnection sql = new SQLiteConnection(con))
		//		{
		//			try
		//			{
		//				sql.Open();
		//				SQLiteCommand cmd = new SQLiteCommand("select Price from Products where Id = @Id", sql);
		//				cmd.Parameters.AddWithValue("@Id", id);
		//				SQLiteDataReader reader = cmd.ExecuteReader();
		//				while (reader.Read())
		//				{
		//					price.Text = Convert.ToString(reader.GetInt32(0));
		//					sql.Close();
		//					return true;
		//				}
		//				sql.Close();
		//				return false;
		//			}
		//			catch (Exception ex)
		//			{
		//				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//				sql.Close();
		//				return false;
		//			}
		//		}
		//	}
		//}

		public int GetDetails(int id)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select Price from Products where Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					SQLiteDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						int price = -1;
						while (reader.Read())
						{
							//price.Text = Convert.ToString(reader.GetInt32(0));
							price = reader.GetInt32(0);
						}
						if (price > -1)
						{
							sql.Close();
							return price;
						}
						else
						{
							sql.Close();
							return -1;
						}
					}
					else
					{
						sql.Close();
						return -1;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql.Close();
					return -1;
				}
			}
		}
		public void UpdatePrice(int id, int price)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("update Products set Price=@Price where Id=@Id", sql);
					cmd.Parameters.AddWithValue("@Price", price);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					sql.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public ProductCategoryEntity getProductsByCategory(int id)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				DataTable dt = new DataTable();
				ProductCategoryEntity entity = new ProductCategoryEntity();
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select Id,Name,ImageUrl,Price,UnitID from Products where CategoryID = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);

					if (dt.Rows.Count > 0)
					{
						entity.Id = new int[dt.Rows.Count];
						entity.Name = new string[dt.Rows.Count];
						entity.ImageUrl = new string[dt.Rows.Count];
						entity.Price = new int[dt.Rows.Count];
						entity.Unit = new string[dt.Rows.Count];

						int counter = 0;

						foreach (DataRow row in dt.Rows)
						{
							entity.Id[counter] = Convert.ToInt32(row[0]);
							entity.Name[counter] = Convert.ToString(row[1]);
							entity.ImageUrl[counter] = Convert.ToString(row[2]);
							entity.Price[counter] = Convert.ToInt32(row[3]);
							entity.Unit[counter] = Convert.ToString(row[4]);
							counter++;
						}

						sql.Close();
						return entity;
					}
					else
					{
						sql.Close();
						return entity;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception Occurs " + ex.Message);
					sql.Close();
					return entity;
				}
			}
		}

		public ProductCategoryEntity getProducts()
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				DataTable dt = new DataTable();
				ProductCategoryEntity entity = new ProductCategoryEntity();
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select Id,Name,ImageUrl,Price,UnitID from Products", sql);
					cmd.ExecuteNonQuery();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);

					if (dt.Rows.Count > 0)
					{
						entity.Id = new int[dt.Rows.Count];
						entity.Name = new string[dt.Rows.Count];
						entity.ImageUrl = new string[dt.Rows.Count];
						entity.Price = new int[dt.Rows.Count];
						entity.Unit = new string[dt.Rows.Count];
						int counter = 0;

						foreach (DataRow row in dt.Rows)
						{
							entity.Id[counter] = Convert.ToInt32(row[0]);
							entity.Name[counter] = Convert.ToString(row[1]);
							entity.ImageUrl[counter] = Convert.ToString(row[2]);
							entity.Price[counter] = Convert.ToInt32(row[3]);
							entity.Unit[counter] = Convert.ToString(row[4]);
							counter++;
						}

						sql.Close();
						return entity;
					}
					else
					{
						sql.Close();
						return entity;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception Occurs " + ex.Message);
					sql.Close();
					return entity;
				}
			}
		}

		public bool AddSale(int customerID, int totalAmount, int discount, int paidAmount, int balance)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("insert into Sale(Datetime,CustomerID,TotalAmount,Discount,PaidAmount,Balance) values(@Datetime,@CustomerID,@TotalAmount,@Discount,@PaidAmount,@Balance)", sql);
					cmd.Parameters.AddWithValue("@Datetime", DateTime.Now.Date.ToOADate());
					cmd.Parameters.AddWithValue("@CustomerID", customerID);
					cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
					cmd.Parameters.AddWithValue("@Discount", discount);
					cmd.Parameters.AddWithValue("@PaidAmount", paidAmount);
					cmd.Parameters.AddWithValue("@Balance", balance);
					cmd.ExecuteNonQuery();
					sql.Close();
					return true;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool AddSaleItem(BunifuCustomDataGrid dataGrid)
		{
			int saleID;
			bool check = false;
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select max(Id) from Sale", sql);
					saleID = Convert.ToInt32(cmd.ExecuteScalar());
					sql.Close();
				}

				for (int j = 0; j < dataGrid.Rows.Count; j++)
				{
					using (SQLiteConnection sql = new SQLiteConnection(con))
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("insert into SaleItem(SaleID,ProductID,Price,Quantity) values(@SaleID,@ProductID,@Price,@Quantity)", sql);
						cmd.Parameters.AddWithValue("@SaleID", saleID);
						cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(dataGrid.Rows[j].Cells[0].Value));
						cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(dataGrid.Rows[j].Cells[2].Value));
						cmd.Parameters.AddWithValue("@Quantity", dataGrid.Rows[j].Cells[3].Value);
						cmd.ExecuteNonQuery();
						sql.Close();
						check = true;
					}
				}
				if (check)
				{
					MessageBox.Show("Sale Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public Image DrawText(String text, Font font, Color textColor, Color backColor)
		{
			//first, create a dummy bitmap just to get a graphics object
			Image img = new Bitmap(1, 1);
			Graphics drawing = Graphics.FromImage(img);

			//measure the string to see how big the image needs to be
			SizeF textSize = drawing.MeasureString(text, font);

			//free up the dummy image and old graphics object
			img.Dispose();
			drawing.Dispose();

			//create a new image of the right size
			img = new Bitmap((int)textSize.Width, (int)textSize.Height);

			drawing = Graphics.FromImage(img);

			//paint the background
			drawing.Clear(backColor);

			//create a brush for the text
			Brush textBrush = new SolidBrush(textColor);

			drawing.DrawString(text, font, textBrush, 0, 0);

			drawing.Save();

			textBrush.Dispose();
			drawing.Dispose();

			return img;

		}

		public bool IsShortExist(char c)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("select ShortCode from Products where ShortCode != @ShortCode", sql);
				cmd.Parameters.AddWithValue("@ShortCode", "");
				SQLiteDataReader reader = cmd.ExecuteReader(); 
				while (reader.Read())
				{
					string s = reader.GetString(0);
					char ch = Convert.ToChar(s);
					if (ch == c)
					{
						sql.Close();
						return true;
					}
				}
				sql.Close();
				return false; 
			}
		}

		public SingleProductEntity GetProduct(char ch)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				try
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select Id,Name,Price,UnitID from Products where ShortCode = @ShortCode", sql);
					cmd.Parameters.AddWithValue("@ShortCode", ch.ToString());
					SQLiteDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						SingleProductEntity productEntity = new SingleProductEntity();
						while (reader.Read())
						{
							productEntity.Id = reader.GetInt32(0);
							productEntity.Name = reader.GetString(1);
							productEntity.Price = reader.GetInt32(2);
							productEntity.Unit = reader.GetString(3);
						}
						sql.Close();
						return productEntity;

					}
					else
					{
						sql.Close();
						return new SingleProductEntity();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sql.Close();
					return new SingleProductEntity();
				}

			}
		}
	}


	public class ProductEntity
	{
		public int Id { get; set; }
		public int oldQuantity { get; set; }
	}
		
	public class ProductCategoryEntity
	{
		public int[] Id { get; set; }
		public int[] Price { get; set; }
		public string[] Name { get; set; }
		public string[] ImageUrl { get; set; }
		public string[] Unit { get; set; }
	}

	public class SingleProductEntity
	{
		public int Id { get; set; }
		public int Price { get; set; }
		public string Name { get; set; }
		public string Unit { get; set; }
	}

}
