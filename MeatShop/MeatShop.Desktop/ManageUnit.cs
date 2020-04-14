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
	public partial class ManageUnit : Form
	{
		Unit unit = new Unit();
		public ManageUnit()
		{
			InitializeComponent();
			unit.GetData(Grd_Unit,"select * from Units");
		}

		private void ClearData()
		{
			Unit_ID.Text = "";
			Unit_Name.Text = "";
			Unit_Prefix.Text = "";
			Unit_Search.Text = "";
		}
		
	
		private void Update_Button_Click(object sender, EventArgs e)
		{
			if (Unit_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the unit first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (unit.UpdateUnit(Convert.ToInt32(Unit_ID.Text), Unit_Name.Text, Unit_Prefix.Text))
				{
					ClearData();
					unit.GetData(Grd_Unit, "select * from Units");
				}
			}
		}

		private void User_Search_TextChanged(object sender, EventArgs e)
		{
			if (Unit_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				unit.SearchUnit(Grd_Unit, Unit_Search.Text);
			}
			
		}

		private void Grd_User_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int index = e.RowIndex;
				if (index > -1)
				{
					DataGridViewRow selectedRow = Grd_Unit.Rows[index];
					Unit_ID.Text = Grd_Unit.Rows[e.RowIndex].Cells[0].Value.ToString();
					Unit_Name.Text = selectedRow.Cells[1].Value.ToString();
					Unit_Prefix.Text = selectedRow.Cells[2].Value.ToString();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Delete_Button_Click(object sender, EventArgs e)
		{
			if (Unit_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the unit first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (MessageBox.Show("Are you sure you want to Delete this User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				unit.DeleteUnit(Convert.ToInt32(Unit_ID.Text));
				ClearData();
				unit.GetData(Grd_Unit, "select * from Units");
			}
		}
	}
}
