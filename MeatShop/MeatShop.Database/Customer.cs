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
			if (name == "" || phone == "")
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
						SQLiteCommand cmd = new SQLiteCommand("insert into Customer(Name,Phone,Date,Balance) values(@Name,@Phone,@Date,@Balance)", sql);
						cmd.Parameters.AddWithValue("@Name", name);
						cmd.Parameters.AddWithValue("@Phone", phone);
						cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date.ToOADate());
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
	}
}
	