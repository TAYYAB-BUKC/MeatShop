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
	public partial class DailyExpenseReport : Form
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		Expense expense = new Expense();
		public DailyExpenseReport()
		{
			InitializeComponent();
			Expense_Date.Value = DateTime.Now;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void All_Expenses_Button_Click(object sender, EventArgs e)
		{
			expense.AllExpenses(Grd_Expense);
		}

		private void TodayExpenses_Button_Click(object sender, EventArgs e)
		{
			expense.DateWiseExpenses(Grd_Expense, Convert.ToInt32(DateTime.Now.Date.ToOADate()));
		}

		private void RandomExpenses_Button_Click(object sender, EventArgs e)
		{
			expense.DateWiseExpenses(Grd_Expense, Convert.ToInt32(Expense_Date.Value.Date.ToOADate()));
		}
	}
}
