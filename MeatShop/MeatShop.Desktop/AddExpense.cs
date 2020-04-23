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
				//string date = ""+Expense_Date.Value.ToOADate();
				string date = "" + Expense_Date.Value.Date.ToOADate();

				//MessageBox.Show("Date: " + date + "\nDate1: " +date1);
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

		private void Expense_Name_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			if (!char.IsLetterOrDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			if (e.KeyChar == (char)Keys.Back)
			{
				e.Handled = false;
			}
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void Expense_Amount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (e.KeyChar == (char)Keys.Back)
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void Expense_Comment_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (!char.IsLetterOrDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
