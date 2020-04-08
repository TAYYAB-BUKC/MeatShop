using MeatShop.Database;
using System;
using System.Windows.Forms;

namespace MeatShop
{
	public partial class AddExpense : Form
	{
		Expense expense = new Expense();
		public AddExpense()
		{
			InitializeComponent();
			Expense_Date.Value = DateTime.Now;
		}
		private void Save_Button_Click(object sender, EventArgs e)
		{
			try
			{
				string date = ""+Expense_Date.Value.ToOADate();

				if (expense.AddExpense(Expense_Name.Text, Convert.ToInt32(Expense_Amount.Text), date, Expense_Comment.Text))
				{
					ClearData();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Something went wrong Please try again later.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClearData()
		{
			Expense_Name.Text = "";
			Expense_Amount.Text = "";
			Expense_Comment.Text = "";
			Expense_Date.Value = DateTime.Now;
		}
	}
}
