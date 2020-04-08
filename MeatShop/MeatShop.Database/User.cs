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
		bool isError = false;
		public bool Login(string username, string password)
		{
			if (username == "" || password == "")
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
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


		public bool AddUser(string name, string username, string password, int role)
		{
			if (name == "" || username == "" || password == "" || role == -1)
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
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
					return true;
				}
				catch (Exception)
				{
					MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

			}
		}

		public void SearchUser(BunifuCustomDataGrid dataGrid, string name)
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
				GetData(dataGrid,"select * from Users");
			}
		}

		private bool Checking(BunifuCustomDataGrid dataGrid, string name)
		{
			SQLiteConnection sql = new SQLiteConnection(con);
			sql.Open();
			SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Users where Name like '" + name + "%'", sql);
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
		public bool UpdateUser(int id,string name, string username, string password, int role)
		{
			if (id > 0 || name == "" || username == "" || password == "" || role == -1)
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				try
				{
					SQLiteConnection sql = new SQLiteConnection(con);
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("update Users set Name=@Name,Username=@Username,Password=@Password,Role=@Role where Id=@Id", sql);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Username", username);
					cmd.Parameters.AddWithValue("@Password", password);
					cmd.Parameters.AddWithValue("@Role", role);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show("User Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sql.Close();
					return true;
				}
				catch (Exception)
				{
					MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}

		public void DeleteUser(int id)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("delete from Users where Id = @Id", sql);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
	