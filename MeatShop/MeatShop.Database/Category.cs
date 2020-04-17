using Bunifu.Framework.UI;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class Category
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		bool isError = false;
		public bool AddCategory(string name)
		{
			if (name == "")
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
						SQLiteCommand cmd = new SQLiteCommand("insert into Categories(Name) values(@Name)", sql);
						cmd.Parameters.AddWithValue("@Name", name);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Category Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		public void SearchCategory(BunifuCustomDataGrid dataGrid, string name)
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
				GetData(dataGrid, "select * from Categories");
			}
		}

		private bool Checking(BunifuCustomDataGrid dataGrid, string name)
		{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Categories where Name like '" + name + "%'", sql);
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
		public bool UpdateCategory(int id, string name)
		{
			if (name == "")
			{
				MessageBox.Show("Please enter the category name first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				try
				{
					using (SQLiteConnection sql = new SQLiteConnection(con))
					{
						sql.Open();
						SQLiteCommand cmd = new SQLiteCommand("update Categories set Name=@Name where Id=@Id", sql);
						cmd.Parameters.AddWithValue("@Name", name);
						cmd.Parameters.AddWithValue("@Id", id);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Category Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		public CategoryEntity GetCategories()
		{
			DataTable dataTable = GetData("select DISTINCT(Categories.Id),Categories.Name from Categories inner join Products on Products.CategoryID = Categories.Id");
			CategoryEntity categoryEntity = new CategoryEntity();
			categoryEntity.Id = new int[dataTable.Rows.Count];
			categoryEntity.Name = new string[dataTable.Rows.Count];
			int counter = 0;

			foreach (DataRow row in dataTable.Rows)
			{
				categoryEntity.Id[counter] = Convert.ToInt32(row[0]);
				categoryEntity.Name[counter] = Convert.ToString(row[1]);
				counter++;
			}

			return categoryEntity;
		}

		public void DeleteCategory(int id)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("delete from Categories where Id = @Id", sql);
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.ExecuteNonQuery();
					sql.Close();
					MessageBox.Show("Category Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			DataTable dt = GetData("select Id,Name from Categories");
			a.DataSource = dt;
			a.DisplayMember = "Name";
			a.ValueMember = "Id";
		}
	}

	public class CategoryEntity
	{
		public int[] Id { get; set; }
		public string[] Name { get; set; }
	}
}
