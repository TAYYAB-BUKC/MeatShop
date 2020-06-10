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
using System.Data.SQLite;
using MeatShop.Database;

namespace MeatShop
{
	public partial class DailySalesReport : Form
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		Expense expense = new Expense();
		Product product = new Product();
		Stock stock = new Stock();
		Double dailyDiscount;
		Double dailyExpenses; 
		
		public DailySalesReport()
		{
			InitializeComponent();
		}

		private void DailySalesReport_Load(object sender, EventArgs e)
		{
			#region Updated Code
			//try
			//{
			using (SQLiteConnection sql = new SQLiteConnection(con))
			{
				sql.Open();
				////SQLiteCommand cmd = new SQLiteCommand("select Products.Name as ProductName,Categories.Name as Category,Products.Price,sum(SaleItem.Quantity) as SaleQuantity,Stock.Quantity as TodaysStock,(Stock.Quantity - sum(SaleItem.Quantity)) as AvailableQuantity from Products inner join Categories on Products.CategoryID = Categories.Id inner join Stock on Stock.Product_Id = Products.Id inner join Stock_Update on Stock_Update.ProductID = Products.Id inner join SaleItem on Products.Id = SaleItem.ProductID inner join Sale on Sale.Id = SaleItem.SaleID where Sale.Datetime = @Datetime group by Products.Name", sql);

				////SQLiteCommand cmd = new SQLiteCommand("select Products.Name as ProductName,Categories.Name as Category,Products.Price,sum(SaleItem.Quantity) as SaleQuantity,Stock.Quantity as TodaysStock,(Stock.Quantity - sum(SaleItem.Quantity)) as AvailableQuantity from Products inner join Categories on Products.CategoryID = Categories.Id inner join Stock on Stock.Product_Id = Products.Id inner join SaleItem on Products.Id = SaleItem.ProductID inner join Sale on Sale.Id = SaleItem.SaleID where Sale.Datetime = @Datetime group by Products.Id,SaleItem.ProductID", sql);

				//working query   
				//SQLiteCommand cmd = new SQLiteCommand("select Products.Name as ProductName,Categories.Name as Category,Products.Price as SalePrice,sum(SaleItem.Price) as TotalSale,sum(SaleItem.Quantity) as SaleQuantity,(select sum(Quantity) from stock_update where ProductID=Products.Id and Datetime='43946') as TodaysStock,((select sum(Quantity) from stock_update where ProductID=Products.Id and Datetime='43946') - sum(SaleItem.Quantity)) as AvailableQuantity from Products inner join Categories on Products.CategoryID = Categories.Id inner join Stock on Stock.Product_Id = Products.Id inner join SaleItem on Products.Id = SaleItem.ProductID inner join Sale on Sale.Id = SaleItem.SaleID where Sale.Datetime = '43946' group by Products.Id,SaleItem.ProductID", sql);

				//Final Query  
				//SQLiteCommand cmd = new SQLiteCommand("select Products.Name as ProductName,Products.Price as SalePrice,sum(SaleItem.Price) as TotalSale,sum(SaleItem.Quantity) as SaleQuantity,(select sum(Quantity) from stock_update where ProductID=Products.Id and Datetime=@Datetime) as TodaysStock,((select sum(Quantity) from stock_update where ProductID=Products.Id and Datetime=@Datetime) - sum(SaleItem.Quantity)) as AvailableQuantity from Products left join Stock on Stock.Product_Id = Products.Id inner join SaleItem on Products.Id = SaleItem.ProductID inner join Sale on Sale.Id = SaleItem.SaleID where Sale.Datetime = @Datetime group by Products.Id,SaleItem.ProductID", sql);

				//Updated Query
				SQLiteCommand cmd = new SQLiteCommand("select Products.Name as ProductName,Products.Price as SalePrice,sum(SaleItem.Price) as TotalSale,sum(SaleItem.Quantity) as SaleQuantity from Products inner join SaleItem on Products.Id = SaleItem.ProductID inner join Sale on Sale.Id = SaleItem.SaleID where Sale.Datetime = @Datetime group by Products.Id,SaleItem.ProductID", sql);

				cmd.Parameters.AddWithValue("@Datetime", Convert.ToInt32(DateTime.Now.Date.ToOADate()));
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{

					TotalSaleQuantity.Text = "Total SaleQuantity: " + dt.Compute("sum(SaleQuantity)", "");
					TotalSale.Text = "Total Sale: " + dt.Compute("sum(TotalSale)", "");
					NetAmount.Text = "NetAmount: " + (Convert.ToInt32(dt.Compute("sum(TotalSale)", "")) - dailyDiscount - dailyExpenses);
				

					Grd_DailySales.DataSource = dt;

					sql.Close();
				}
				else
				{
					sql.Close();
				}
			}

			#endregion

			#region PopulateLabels
			dailyExpenses = expense.DailyExpense();
			dailyDiscount = product.DailyDiscount();

			TotalExpense.Text = "Total Expense: " + dailyExpenses;
			TotalDiscount.Text = "Total Discount: " + dailyDiscount;

			GetSpecificStock beef = stock.GetStock("Beef", "" + Convert.ToInt32(DateTime.Now.Date.ToOADate()));
			int remainingBeef = stock.GetRemainingStock("Beef");
			RemainingBeef.Text = "Remaining Beef: " + remainingBeef;
			if (beef != null)
			{
				TotalBeefPrice.Text = "Total Beef Stock Price: " + beef.Price;

				TotalBeefQuantity.Text = "Total Beef Stock Quantity: " + beef.Quantity;

			}
			GetSpecificStock mutton = stock.GetStock("Mutton", "" + Convert.ToInt32(DateTime.Now.Date.ToOADate()));
			int remainingMutton = stock.GetRemainingStock("Mutton");
			RemainingMutton.Text = "Remaining Mutton: " + remainingMutton;
			if (mutton != null)
			{
				TotalMuttonPrice.Text = "Total Mutton Stock Price: " + mutton.Price;

				TotalMuttonQuantity.Text = "Total Mutton Stock Quantity: " + mutton.Quantity;

			}
			GetSpecificStock chicken = stock.GetStock("Chicken", "" + Convert.ToInt32(DateTime.Now.Date.ToOADate()));
			int remainingChicken = stock.GetRemainingStock("Chicken");
			RemainingChicken.Text = "Remaining Chicken: " + remainingChicken;

			if (chicken != null)
			{
				TotalChickenPrice.Text = "Total Chicken Stock Price: " + chicken.Price;

				TotalChickenQuantity.Text = "Total Chicken Stock Quantity: " + chicken.Quantity;

			}


			#endregion

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
