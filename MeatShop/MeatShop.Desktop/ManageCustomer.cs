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
	public partial class ManageCustomer : Form
	{
		Customer customer = new Customer();
		public ManageCustomer()
		{
			InitializeComponent();
			customer.GetData(Grd_Customer,"select * from Customer order by Name");
		}

		private void ClearData()
		{
			Customer_ID.Text = "";
			Customer_Name.Text = "";
			Customer_Search.Text = "";
			Customer_Phone.Text = "";
			Customer_Balance.Text = "";

		}

		private void Update_Button_Click(object sender, EventArgs e)
		{
			if (Customer_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the customer first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (customer.UpdateCustomer(Convert.ToInt32(Customer_ID.Text), Customer_Name.Text, Customer_Phone.Text, Customer_Balance.Text))
				{
					ClearData();
					customer.GetData(Grd_Customer, "select * from Customer order by Name");
				}
			}
		}
		private void Delete_Button_Click(object sender, EventArgs e)
		{
			if (Customer_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the customer first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (MessageBox.Show("Are you sure you want to Delete this Customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				DataGridViewRow selectedRow = Grd_Customer.Rows[Grd_Customer.CurrentCell.RowIndex];

				if (selectedRow.Cells[4].Value.ToString() == "0")
				{
					customer.DeleteCustomer(Convert.ToInt32(Customer_ID.Text));
					ClearData();
					customer.GetData(Grd_Customer, "select * from Customer order by Name");

				}
				else
				{
					MessageBox.Show("You are not allowed to delete this Customer because balance is pending", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Grd_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int index = e.RowIndex;
				if (index >= 0)
				{
					DataGridViewRow selectedRow = Grd_Customer.Rows[index];
					Customer_ID.Text = Grd_Customer.Rows[e.RowIndex].Cells[0].Value.ToString();
					Customer_Name.Text = selectedRow.Cells[1].Value.ToString();
					Customer_Phone.Text = selectedRow.Cells[2].Value.ToString();
					Customer_Balance.Text = selectedRow.Cells[4].Value.ToString();
				}
			}
			catch (Exception ex)
			{
				//	MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
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

		private void Customer_Phone_KeyPress(object sender, KeyPressEventArgs e)
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

		private void Customer_Search_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = false;
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
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

		private void Customer_Search_TextChanged(object sender, EventArgs e)
		{
			if (Customer_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				customer.SearchCustomer(Grd_Customer, Customer_Search.Text);
			}
		}
	}
}
