using Bunifu.Framework.UI;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class Expense
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		bool isError = false;

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
						foreach (DataRow row in dt.Rows)
						{
							double sdate = Convert.ToDouble(row["Datetime"]);
							var sfinal = DateTime.FromOADate(sdate);
							//row["Datetime"] = sfinal.ToString("dd-MM-yyyy");
							row["Datetime"] = sfinal.ToString("dd-MM-yyyy");

						}
					}
					dataGrid.DataSource = dt;
					sql.Close();
					dataGrid.Columns["Id"].Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception Occurs in datagridView Code.........." + ex.Message);
			}
		}

		public bool AddExpense(string name, int amount, string date, string comment)
		{
			if (amount < 0)
			{
				MessageBox.Show("Please enter the valid amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (name == "" || date == "")
			{
				MessageBox.Show("Please Fill All the Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				try
				{
					using (SQLiteConnection sql = new SQLiteConnection(con))
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("insert into Expenses(Name,Amount,Datetime,Comment) values(@Name,@Amount,@Datetime,@Comment)", sql);
						cmd.Parameters.AddWithValue("@Name", name);
						cmd.Parameters.AddWithValue("@Amount", amount);
						cmd.Parameters.AddWithValue("@Datetime", date);
						cmd.Parameters.AddWithValue("@Comment", comment);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Expense Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		public void SearchExpense(BunifuCustomDataGrid dataGrid, string name)
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
				GetData(dataGrid, "select * from Expenses");
			}
		}

		private bool Checking(BunifuCustomDataGrid dataGrid, string name)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Expenses where Name like '" + name + "%'", sql);
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

					return true;

				}
				else
				{
					sql.Close();
					return false;
				}
			}
		}

		public void DeleteExpense(int id)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("delete from Expenses where Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Expense Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sql.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public double DailyExpense()
		{
			string dailyExpense = "";
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select sum(Amount) from Expenses where Datetime = @Datetime", sql);
					cmd.Parameters.AddWithValue("@Datetime", Convert.ToInt32(DateTime.Now.Date.ToOADate()));
					dailyExpense = Convert.ToString(cmd.ExecuteScalar());
					sql.Close();
					if (dailyExpense == "")
					{
						return 0;
					}
					else
					{
						return Convert.ToDouble(dailyExpense);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
		}

		public bool AllExpenses(BunifuCustomDataGrid dataGrid)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Expenses order by Datetime", sql);
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

					return true;

				}
				else
				{
					sql.Close();
					return false;
				}
			}
		}

		public bool DateWiseExpenses(BunifuCustomDataGrid dataGrid, int date)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Expenses where Datetime=@Datetime", sql);
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
}