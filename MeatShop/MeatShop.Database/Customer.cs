using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class Customer
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		bool isError = false;
		public bool AddCustomer(string name, string phone)
		{
			if (name == "")
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				int date = Convert.ToInt32(DateTime.Now.Date.ToOADate());
				try
				{
					using (SQLiteConnection sql = new SQLiteConnection(con))
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("insert into Customer(Name,Phone,Date,Balance) values(@Name,@Phone,@Date,@Balance)", sql);
						cmd.Parameters.AddWithValue("@Name", name);
						cmd.Parameters.AddWithValue("@Phone", phone);
						cmd.Parameters.AddWithValue("@Date", date);
						cmd.Parameters.AddWithValue("@Balance", 0);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Customer Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		}

		public int GetID()
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("select max(Id) from Customer", sql);
				int ID = Convert.ToInt32(cmd.ExecuteScalar());
				sql.Close();
				return ID;
			}


		}

		public bool IsPhoneValid(string phone)
		{
			if (phone != null && phone.Length > 0 && !Regex.IsMatch(phone, "^[0-9]{4}-[0-9]{7}$"))
			{
				return false;
			}
			else
			{
				return true;
			}

		}

		private DataTable GetData(string query)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand(query, sql);
					cmd.ExecuteNonQuery();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);
					sql.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception Occurs " + ex.Message);
			}
			return dt;
		}

		public void FillCombo(ComboBox a)
		{
			DataTable dt = GetData("select Id,Name from Customer");
			a.DataSource = dt;
			a.DisplayMember = "Name";
			a.ValueMember = "Id";
		}

		public void UpdateBalance(int customerID, int balance)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("Update Customer set Balance = @Balance where Id=@Id", sql);
					cmd.Parameters.AddWithValue("@Balance", balance);
					cmd.Parameters.AddWithValue("@Id", customerID);
					cmd.ExecuteNonQuery();
					sql.Close();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void DeleteCustomer(int id)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("delete from Customer where Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					sql.Close();
					MessageBox.Show("Customer Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool UpdateCustomer(int id, string name, string phone, string balance)
		{
			if (name == "" || balance == "")
			{
				MessageBox.Show("Please fill the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				try
				{
					using (SQLiteConnection sql = new SQLiteConnection(con))
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("update Customer set Name=@Name,Phone=@Phone,Balance=@Balance where Id=@Id", sql);
						cmd.Parameters.AddWithValue("@Name", name);
						cmd.Parameters.AddWithValue("@Phone", phone);
						cmd.Parameters.AddWithValue("@Balance", balance);
						cmd.Parameters.AddWithValue("@Id", id);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Customer Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		}

		public void SearchCustomer(BunifuCustomDataGrid dataGrid, string name)
		{
			if (name.Length > 0)
			{
				//if (name == "w" || name == "W")
				//{
				//	MessageBox.Show("No Record Found For this Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
				//else
				//{
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

				//}
			}
			else if (name.Length == 0)
			{
				GetData(dataGrid, "select * from Customer order by Name");
			}
		}

		private bool Checking(BunifuCustomDataGrid dataGrid, string name)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Customer where Name like '" + name + "%' order by Name", sql);
				//da.SelectCommand.Parameters.AddWithValue("@Name", txt_search.Text);
				DataTable dt = new DataTable();
				if (da != null)
				{
					da.Fill(dt);
				}
				if (dt.Rows.Count > 0)
				{
					string searchExpression = "Id = 1";

					DataRow[] foundRows = dt.Select(searchExpression);
					foreach (DataRow dr in foundRows)
					{
						dt.Rows.Remove(dr);
					}

					dataGrid.Columns["Id"].Visible = false;
					dataGrid.Columns["Date"].Visible = false;
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
					if (dt.Rows.Count > 0)
					{
						string searchExpression = "Id = 1";

						DataRow[] foundRows = dt.Select(searchExpression);
						foreach (DataRow dr in foundRows)
						{
							dt.Rows.Remove(dr);
						}
						//dt.Rows[0].Delete();
						//dt.AcceptChanges();
					}
					dataGrid.DataSource = dt;
					sql.Close();
					dataGrid.Columns["Id"].Visible = false;
					dataGrid.Columns["Date"].Visible = false;


				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception Occurs in datagridView Code.........." + ex.Message);
			}
		}

	}
}
	