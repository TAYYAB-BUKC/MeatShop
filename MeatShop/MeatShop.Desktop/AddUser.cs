using MeatShop.Database;
using System;
using System.Windows.Forms;

namespace MeatShop
{
	public partial class AddUser : Form
	{
		User user = new User();
		public AddUser()
		{
			InitializeComponent();
		}
		private void Save_Button_Click(object sender, EventArgs e)
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

			if (user.AddUser(User_Name.Text, User_Username.Text, User_Password.Text, role))
			{
				ClearData();
			}			
		}

		private void ClearData()
		{
			User_Name.Text = "";
			User_Username.Text = "";
			User_Password.Text = "";
			User_Role.SelectedIndex = -1;
		}

		private void User_Name_KeyPress(object sender, KeyPressEventArgs e)
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

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

