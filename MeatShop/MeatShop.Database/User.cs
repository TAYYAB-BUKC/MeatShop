using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop.Database
{
	public class User
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

		public bool Login(string username,string password)
		{
			SQLiteConnection sql = new SQLiteConnection(con);
			sql.Open();
			SQLiteCommand cmd = new SQLiteCommand("select * from Users where Username = @Username and Password = @Password", sql);
			cmd.Parameters.AddWithValue("@Username", username);
			cmd.Parameters.AddWithValue("@Password", password);
			SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows.Count == 1)
			{
				return true;
			}
			else
			{
				return false;
  			}
		}
	}
}
