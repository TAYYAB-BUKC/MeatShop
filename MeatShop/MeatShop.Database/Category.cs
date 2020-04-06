using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class Category
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

		public void AddCategory(string name)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("insert into Categories(Name) values(@Name)", sql);
				cmd.Parameters.AddWithValue("@Name", name);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Category Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sql.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
