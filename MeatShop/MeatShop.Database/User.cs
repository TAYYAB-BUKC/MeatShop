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
	public class User
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

		public bool Login(string username, string password)
		{
			SQLiteConnection sql = new SQLiteConnection(con);
			sql.Open();
			SQLiteCommand cmd = new SQLiteCommand("select * from Users where Username = @Username and Password = @Password", sql);
			cmd.Parameters.AddWithValue("@Username", username);
			cmd.Parameters.AddWithValue("@Password", password);
			SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows.Count == 1)
			{
				return true;
			}
			else
			{
				return false;
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


		public void AddUser(string name, string username, string password, int role)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("insert into Users(Name,Username,Password,Role) values(@Name,@Username,@Password,@Role)", sql);
				cmd.Parameters.AddWithValue("@Name", name);
				cmd.Parameters.AddWithValue("@Username", username);
				cmd.Parameters.AddWithValue("@Password", password);
				cmd.Parameters.AddWithValue("@Role", role);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sql.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

}