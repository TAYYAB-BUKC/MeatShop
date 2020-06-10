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
			int role = User.Login(Username.Text, Password.Text);
			if (role == 0)
			{
				Username.Text = "";
				Password.Text = "";
				this.Hide();
				Home home = new Home(this);
				MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				home.Show();
			}
			else if (role == 1)
			{
				Username.Text = "";
				Password.Text = "";
				this.Hide();
				Sales sales = new Sales(true);
				MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sales.Show();
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
				int role = User.Login(Username.Text, Password.Text);
				if (role == 0)
				{
					Username.Text = "";
					Password.Text = "";
					Username.Focus();
					this.Hide();
					Home home = new Home(this);
					MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					home.Show();
				}
				else if (role == 1)
				{
					Username.Text = "";
					Password.Text = "";
					Username.Focus();
					this.Hide();
					Sales sales = new Sales(true);
					MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sales.Show();
				}
				else
				{
					MessageBox.Show("Invalid credentials please try again later", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
			