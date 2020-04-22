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
	public partial class ManageUser : Form
	{
		User user = new User();
		public ManageUser()
		{
			InitializeComponent();
			user.GetData(Grd_User,"select * from Users");
		}

		private void ClearData()
		{
			User_ID.Text = "";
			User_Name.Text = "";
			User_Username.Text = "";
			User_Password.Text = "";
			User_Role.SelectedIndex = -1;
			User_Search.Text = "";
		}
		
	
		private void Update_Button_Click(object sender, EventArgs e)
		{
			if (User_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the user first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int role = -1;
				if (User_Role.SelectedIndex == 0)
				{
					role = 0;
				}
				else if (User_Role.SelectedIndex == 1)
				{
					role = 1;
				}
				if (user.UpdateUser(Convert.ToInt32(User_ID.Text), User_Name.Text, User_Username.Text, User_Password.Text, role))
				{
					ClearData();
					user.GetData(Grd_User, "select * from Users");
				}
			}
		}

		private void User_Search_TextChanged(object sender, EventArgs e)
		{
			if (User_Search.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
			{
				//invalid
				MessageBox.Show("please type a valid Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//valid
				user.SearchUser(Grd_User, User_Search.Text);
			}
			
		}

		private void Grd_User_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int index = e.RowIndex;
				if (index > -1)
				{
					DataGridViewRow selectedRow = Grd_User.Rows[index];
					User_ID.Text = Grd_User.Rows[e.RowIndex].Cells[0].Value.ToString();
					User_Name.Text = selectedRow.Cells[1].Value.ToString();
					User_Username.Text = selectedRow.Cells[2].Value.ToString();
					User_Password.Text = selectedRow.Cells[3].Value.ToString();
					//if (Convert.ToInt32(selectedRow.Cells[4].Value) == 0)
					//{
					//	User_Role.SelectedIndex = 0;
					User_Role.SelectedIndex = Convert.ToInt32(selectedRow.Cells[4].Value);
					//}	
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Delete_Button_Click(object sender, EventArgs e)
		{
			if (User_ID.Text == String.Empty)
			{
				MessageBox.Show("Please select the user first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else if (MessageBox.Show("Are you sure you want to Delete this User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				user.DeleteUser(Convert.ToInt32(User_ID.Text));
				ClearData();
				user.GetData(Grd_User, "select * from Users");
			}
		}

		private void User_Search_KeyPress(object sender, KeyPressEventArgs e)
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

		private void User_Name_KeyPress(object sender, KeyPressEventArgs e)
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
	}
}
