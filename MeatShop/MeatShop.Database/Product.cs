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

		public bool AddProduct(string name, int price, string imageurl, int categoryID,int unitID)
		{
			if (name == ""  || price > -1 || categoryID < 0 || unitID < 0)
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
						return true;
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
						finalPath = newpath + "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
						File.Copy(imageurl, finalPath);

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
		public bool UpdateProduct(int id, string name, int price, string oldPath, string newPath, int categoryID, int unitID)
		{
			if (name == "" || price < -1 || categoryID < 0 || unitID < 0)
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
						return true;
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

					if (File.Exists(oldPath))
					{
						try
						{
							GC.Collect();
							GC.WaitForPendingFinalizers();
							File.Delete(oldPath);

							string path = Path.GetDirectoryName(Application.StartupPath);
							string newpath = path.Substring(0, (Application.StartupPath.Length - 10));
							finalPath = newpath + "\\ProductImages\\" + Guid.NewGuid() + ".jpg";
							File.Copy(newPath, finalPath);

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
							return true;
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
		public void DeleteProduct(int id,FileInfo path,string oldPath)
		{
			bool isFileDeleted = false;
			try
			{
				if (!IsFileLocked(path))
				{
					if (File.Exists(oldPath))
					{
						GC.Collect();
						GC.WaitForPendingFinalizers();
						File.Delete(oldPath);
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
					SQLiteConnection sql = new SQLiteConnection(con);
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("delete from Products where Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
	}
}
