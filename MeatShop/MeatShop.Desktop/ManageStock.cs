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
	public partial class ManageStock : Form
	{
		Stock stock = new Stock();
		public ManageStock()
		{
			InitializeComponent();
			stock.GetData(Grd_Stock, "select Stock_Update.Id,Stock.Product_Id as Name,Stock_Update.Quantity,Stock_Update.Price,Stock_Update.Datetime,Stock_Update.Last_Available,Stock.Quantity as StockQuantity,Stock.Product_Id as ProductID from Stock inner join Stock_Update on Stock_Update.ProductID = Stock.Product_Id where Stock_Update.Datetime = @Datetime", "" + Convert.ToInt32(DateTime.Now.Date.ToOADate()));
		}
		      
		private void Delete_Button_Click(object sender, EventArgs e)
		{
			//#region OldCode 
			//if (Grd_Stock.Rows.Count > 0)
			//{
			//	if (MessageBox.Show("Are you sure you want to Delete this Stock?", "Delete Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			//	{
			//		DataGridViewRow row = Grd_Stock.Rows[Grd_Stock.CurrentCell.RowIndex];
				
			//		Double finalQuantity = Convert.ToDouble(Convert.ToInt32(row.Cells[6].Value) - Convert.ToInt32(row.Cells[2].Value));
			//		stock.UpdateStock(finalQuantity, Convert.ToInt32(row.Cells[7].Value), Convert.ToInt32(row.Cells[0].Value));
			//		stock.GetData(Grd_Stock, "select Stock_Update.Id,Products.Name,Stock_Update.Quantity,Stock_Update.Price,Stock_Update.Datetime,Stock_Update.Last_Available,Stock.Quantity as StockQuantity,Products.Id as ProductID from Stock inner join Products on Products.Id = Stock.Product_Id inner join Stock_Update on Stock_Update.ProductID = Products.Id where Stock_Update.Datetime = @Datetime", "" + Convert.ToInt32(DateTime.Now.Date.ToOADate()));
			//		Stock_Search.Text = "";
			//	}
			//}
			//#endregion

			#region UpdatedCode 
			if (Grd_Stock.Rows.Count > 0)
			{
				if (MessageBox.Show("Are you sure you want to Delete this Stock?", "Delete Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					DataGridViewRow row = Grd_Stock.Rows[Grd_Stock.CurrentCell.RowIndex];

					Double finalQuantity = Convert.ToDouble(Convert.ToInt32(row.Cells[6].Value) - Convert.ToInt32(row.Cells[2].Value));
					stock.UpdateStock(finalQuantity, row.Cells[7].Value.ToString(), Convert.ToInt32(row.Cells[0].Value));
					stock.GetData(Grd_Stock, "select Stock_Update.Id,Stock.Product_Id as Name,Stock_Update.Quantity,Stock_Update.Price,Stock_Update.Datetime,Stock_Update.Last_Available,Stock.Quantity as StockQuantity,Stock.Product_Id as ProductID from Stock inner join Stock_Update on Stock_Update.ProductID = Stock.Product_Id where Stock_Update.Datetime = @Datetime", "" + Convert.ToInt32(DateTime.Now.Date.ToOADate()));
					Stock_Search.Text = "";
				}
			}
			#endregion


		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Stock_Search_TextChanged(object sender, EventArgs e)
		{
			if (Stock_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				stock.SearchStock(Grd_Stock, Stock_Search.Text);
			}
		}
	}
}
