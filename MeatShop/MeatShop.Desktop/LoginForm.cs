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
		}

		private void Login_Button_Click(object sender, EventArgs e)
		{
			if (User.Login(Username.Text, Password.Text))
			{
				Home home = new Home(false);
				MessageBox.Show("Logged In Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				home.Show();
			}
			else
			{
				MessageBox.Show("Invalid credentials please try again later", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//pictureBox4.Hide();

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}


		private void Email_Click(object sender, EventArgs e)
		{
			Username.Text = "";
		}

		private void Password_Click(object sender, EventArgs e)
		{
			Password.Text = "";
		}
	}
}
			