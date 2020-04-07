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
	}
}
