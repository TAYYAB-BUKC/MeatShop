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
	public partial class DailyStockReport : Form
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		Stock stock = new Stock();
		public DailyStockReport()
		{
			InitializeComponent();
			Stock_Date.Value = DateTime.Now;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void All_Expenses_Button_Click(object sender, EventArgs e)
		{
			stock.AllStock(Grd_Stock);
		}

		private void TodayExpenses_Button_Click(object sender, EventArgs e)
		{
			stock.DateWiseStock(Grd_Stock, Convert.ToInt32(DateTime.Now.Date.ToOADate()));
		}

		private void RandomExpenses_Button_Click(object sender, EventArgs e)
		{
			stock.DateWiseStock(Grd_Stock, Convert.ToInt32(Stock_Date.Value.Date.ToOADate()));
		}
	}
}
