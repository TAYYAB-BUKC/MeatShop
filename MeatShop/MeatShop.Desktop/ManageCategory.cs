﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;
using MeatShop.Database;

namespace MeatShop
{
	public partial class ManageCategory : Form
	{
		Category category = new Category();
		public ManageCategory()
		{
			InitializeComponent();
			category.GetData(Grd_Category,"select * from Categories");
		}

		private void ClearData()
		{
			Category_ID.Text = "";
			Category_Name.Text = "";
			Category_Search.Text = "";
		}
		
	
		private void Update_Button_Click(object sender, EventArgs e)
		{
			category.UpdateCategory(Convert.ToInt32(Category_ID.Text), Category_Name.Text);
			ClearData();
			category.GetData(Grd_Category, "select * from Categories");
		}

		private void User_Search_TextChanged(object sender, EventArgs e)
		{
			if (Category_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				category.SearchCategory(Grd_Category, Category_Search.Text);
			}
			
		}

		private void Grd_User_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			try
			{
				int index = e.RowIndex;
				if (index > -1)
				{
					DataGridViewRow selectedRow = Grd_Category.Rows[index];
					Category_ID.Text = Grd_Category.Rows[e.RowIndex].Cells[0].Value.ToString();
					Category_Name.Text = selectedRow.Cells[1].Value.ToString();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Delete_Button_Click(object sender, EventArgs e)
		{
			if (Category_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the user first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else if (MessageBox.Show("Are you sure you want to Delete this User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				category.DeleteCategory(Convert.ToInt32(Category_ID.Text));
				ClearData();
				category.GetData(Grd_Category, "select * from Categories");
			}
		}
	}
}