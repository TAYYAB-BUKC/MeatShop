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
	}
}

