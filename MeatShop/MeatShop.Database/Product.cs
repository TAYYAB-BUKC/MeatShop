using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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

		public void AddProduct(string name, int price, string imageurl, int categoryID,int unitID)
		{
			if (imageurl == "")
			{
				try
				{
					SQLiteConnection sql = new SQLiteConnection(con);
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("insert into Products(Name,Price,ImageUrl,CategoryID,UnitID) values(@Name,@Price,@ImageUrl,@CategoryID,@UnitID)", sql);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Price", price);
					cmd.Parameters.AddWithValue("@ImageUrl", imageurl);
					cmd.Parameters.AddWithValue("@CategoryID", categoryID);
					cmd.Parameters.AddWithValue("@UnitID", unitID);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sql.Close();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				string finalPath = String.Empty;
				try
				{
					string path = Path.GetDirectoryName(Application.StartupPath);
					string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
					finalPath = newpath + "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
					File.Copy(imageurl, finalPath);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					SQLiteConnection sql = new SQLiteConnection(con);
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("insert into Products(Name,Price,ImageUrl,CategoryID,UnitID) values(@Name,@Price,@ImageUrl,@CategoryID,@UnitID)", sql);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Price", price);
					cmd.Parameters.AddWithValue("@ImageUrl", finalPath);
					cmd.Parameters.AddWithValue("@CategoryID", categoryID);
					cmd.Parameters.AddWithValue("@UnitID", unitID);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sql.Close();
				}
			}
			
		}

		public void GetData(BunifuCustomDataGrid dataGrid, string query)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand(query, sql);
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
				da.Fill(dt);
				dataGrid.DataSource = dt;
				sql.Close();
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
			SQLiteConnection sql = new SQLiteConnection(con);
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
		public void UpdateProduct(int id, string name, int price, string oldPath ,string newPath, int categoryID, int unitID)
		{
			if (oldPath == null)
			{
				try
				{
					SQLiteConnection sql = new SQLiteConnection(con);
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("update Products set Name=@Name,Price=@Price,ImageUrl=@ImageUrl,CategoryID=@CategoryID,UnitID=@UnitID where Id=@Id", sql);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Price", price);
					cmd.Parameters.AddWithValue("@ImageUrl", newPath);
					cmd.Parameters.AddWithValue("@CategoryID", categoryID);
					cmd.Parameters.AddWithValue("@UnitID", unitID);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sql.Close();
				}
				catch (Exception)
				{
					MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				if (File.Exists(oldPath))
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
					File.Delete(oldPath);

					try
					{
						string path = Path.GetDirectoryName(Application.StartupPath);
						string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
						finalPath = newpath + "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
						File.Copy(newPath, finalPath);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				try
					{
					SQLiteConnection sql = new SQLiteConnection(con);
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("update Products set Name=@Name,Price=@Price,ImageUrl=@ImageUrl,CategoryID=@CategoryID,UnitID=@UnitID where Id=@Id", sql);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Price", price);
					cmd.Parameters.AddWithValue("@ImageUrl", finalPath);
					cmd.Parameters.AddWithValue("@CategoryID", categoryID);
					cmd.Parameters.AddWithValue("@UnitID", unitID);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sql.Close();
				}
				catch (Exception)
				{
					MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void DeleteProduct(int id,string path)
		{
			try
			{
				if (File.Exists(path))
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
					File.Delete(path);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("delete from Products where Id = @Id", sql);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}
	}
}
