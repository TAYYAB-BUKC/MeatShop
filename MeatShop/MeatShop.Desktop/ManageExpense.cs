using System;
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
using MeatShop.Database;

namespace MeatShop
{
	public partial class ManageExpense : Form
	{
		Expense expense = new Expense();
		public ManageExpense()
		{
			InitializeComponent();
			expense.GetData(Grd_Expense, "select * from Expenses");
		}

		private void ClearData()
		{
			Expense_ID.Text = "";
			Expense_Name.Text = "";
			Expense_Amount.Text = "";
			Expense_Date.Text = "";
			Expense_Comment.Text = "";
		}

		private void Delete_Button_Click(object sender, EventArgs e)
		{
			try
			{
				if (Expense_ID.Text == String.Empty)
				{
					MessageBox.Show("Please select the expense first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (MessageBox.Show("Are you sure you want to Delete this expense?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					expense.DeleteExpense(Convert.ToInt32(Expense_ID.Text));
					ClearData();
					expense.GetData(Grd_Expense, "select * from Expenses");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Grd_Expense_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int index = e.RowIndex;
				if (index > -1)
				{
					DataGridViewRow selectedRow = Grd_Expense.Rows[index];
					Expense_ID.Text = Grd_Expense.Rows[e.RowIndex].Cells[0].Value.ToString();
					Expense_Name.Text = selectedRow.Cells[1].Value.ToString();
					Expense_Amount.Text = selectedRow.Cells[2].Value.ToString();
					Expense_Date.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
					Expense_Comment.Text = selectedRow.Cells[4].Value.ToString();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Expense_Search_TextChanged(object sender, EventArgs e)
		{
			if (Expense_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				expense.SearchExpense(Grd_Expense, Expense_Search.Text);
			}

		}

	}
}
