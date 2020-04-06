﻿using Bunifu.Framework.UI;
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
	public class Unit
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		bool isError = false;
		public void AddUnit(string name,string prefix)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("insert into Units(Name,Unit_prefix) values(@Name,@Unit_prefix)", sql);
				cmd.Parameters.AddWithValue("@Name", name);
				cmd.Parameters.AddWithValue("@Unit_prefix", prefix);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Unit Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sql.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		public void SearchUnit(BunifuCustomDataGrid dataGrid, string name)
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
				GetData(dataGrid, "select * from Units");
			}
		}

		private bool Checking(BunifuCustomDataGrid dataGrid, string name)
		{
			SQLiteConnection sql = new SQLiteConnection(con);
			sql.Open();
			SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Units where Name like '" + name + "%'", sql);
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
		public void UpdateUnit(int id, string name,string prefix)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("update Units set Name=@Name,Unit_Prefix=@Unit_Prefix where Id=@Id", sql);
				cmd.Parameters.AddWithValue("@Name", name);
				cmd.Parameters.AddWithValue("@Unit_prefix", prefix);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Unit Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sql.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the fields Correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void DeleteUnit(int id)
		{
			try
			{
				SQLiteConnection sql = new SQLiteConnection(con);
				sql.Open();
				SQLiteCommand cmd = new SQLiteCommand("delete from Units where Id = @Id", sql);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Unit Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
