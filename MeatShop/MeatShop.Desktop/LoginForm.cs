using MeatShop.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop
{
	public partial class Login : Form
	{
		User User = new User();

		public Login()
		{
			InitializeComponent();
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(Username, "Enter username");
			toolTip.SetToolTip(Password, "Enter password");
		}

		private void Login_Button_Click(object sender, EventArgs e)
		{
			if (User.Login(Username.Text, Password.Text))
			{
				this.Hide();
				Home home = new Home(false);
				MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				home.Show();
			}
			else
			{
				MessageBox.Show("Invalid credentials please try again later", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void Email_Click(object sender, EventArgs e)
		{
			Username.Text = "";
		}

		private void Password_Click(object sender, EventArgs e)
		{
			Password.Text = "";
		}

		private void Password_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				if (User.Login(Username.Text, Password.Text))
				{
					this.Hide();
					Home home = new Home(false);
					MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					home.Show();
				}
				else
				{
					MessageBox.Show("Invalid credentials please try again later", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
			