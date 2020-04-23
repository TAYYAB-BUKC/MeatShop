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
		public DailySalesReport()
		{
			InitializeComponent();
		}

		private void DailySalesReport_Load(object sender, EventArgs e)
		{
			try
			{
				using (SQLiteConnection sql = new SQLiteConnection(con))
				{
					sql.Open();
					SQLiteCommand cmd = new SQLiteCommand("select Products.Name as ProductName,Categories.Name as Category,Products.Price,sum(SaleItem.Quantity) as SaleQuantity,Stock_Update.Quantity as TodaysStock,(Stock_Update.Quantity - sum(SaleItem.Quantity)) as AvailableQuantity from Products inner join Categories on Products.CategoryID = Categories.Id inner join Stock on Stock.Product_Id = Products.Id inner join Stock_Update on Stock_Update.ProductID = Products.Id inner join SaleItem on Products.Id = SaleItem.ProductID inner join Sale on Sale.Id = SaleItem.SaleID where Sale.Datetime = @Datetime group by Products.Name", sql);
					cmd.Parameters.AddWithValue("@Datetime", Convert.ToInt32(DateTime.Now.Date.ToOADate()));
					cmd.ExecuteNonQuery();
					DataTable dt = new DataTable();
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
					da.Fill(dt);
					Grd_DailySales.DataSource = dt;
					TotalSale.Text = "Total SaleQuantity: " + dt.Compute("sum(SaleQuantity)", "");
					TotalStock.Text = "Total Stock: " + dt.Compute("sum(TodaysStock)", "");
					TotalAvailable.Text = "Total AvailableQuantity: " + dt.Compute("sum(AvailableQuantity)", "");
					sql.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception Occurs in datagridView Code.........." + ex.Message);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
