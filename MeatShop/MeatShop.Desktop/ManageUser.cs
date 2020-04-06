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
		
		private void Delete_Button_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	if (MessageBox.Show("Are you sure you want to Delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			//	{
			//		businessData = new DataTable();//business.DeleteData(businessData, Convert.ToInt32(Business_ID.Text));
			//		ClearData(); 
			//		MessageBox.Show("Business Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//		Grd_User.DataSource = businessData;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void Business_Search_TextChanged(object sender, EventArgs e)
		{
			//if (User_Search.Text.Length > 0)
			//{
			//	if (Checking())
			//	{
			//	}
			//	else
			//	{
			//		if (!isError)
			//		{
			//			MessageBox.Show("No Record Found For this Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//			isError = true;
			//		}
			//	}

			//}
			//else if (User_Search.Text.Length == 0)
			//{
			//	Grd_User.DataSource = businessData;
			//	isError = false;
			//}
		}

		private void Grd_Appointment_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//try
			//{
			//	int index = e.RowIndex;
			//	if (index > -1)
			//	{
			//		DataGridViewRow selectedRow = Grd_User.Rows[index];
			//		User_ID.Text = Grd_User.Rows[e.RowIndex].Cells[0].Value.ToString();
			//		User_Name.Text = selectedRow.Cells[1].Value.ToString();
			//		User_Username.Text = selectedRow.Cells[2].Value.ToString();
			//		User_Password.Text = selectedRow.Cells[3].Value.ToString();
			//		Business_Address.Text = selectedRow.Cells[4].Value.ToString();
			//		Business_Website.Text = selectedRow.Cells[5].Value.ToString();
			//		Business_OperationaHours.Text = selectedRow.Cells[6].Value.ToString();
			//		Business_Image.Image = Image.FromFile(selectedRow.Cells[7].Value.ToString());
			//		oldPath = selectedRow.Cells[7].Value.ToString();
			//	}
			//}
			//catch (Exception)
			//{
			//	MessageBox.Show("Please Choose the Cell....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void Update_Button_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	if (isImageUpdated)
			//	{
			//		//businessData = business.UpdateData(businessData, Convert.ToInt32(Business_ID.Text), Business_Name.Text, Business_Phone.Text, Business_Email.Text, Business_Address.Text, Business_Website.Text, Business_OperationaHours.Text,opf.FileName);
			//		ClearData();
			//		MessageBox.Show("Business Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//		Grd_User.DataSource = businessData;
			//	}
			//	else
			//	{
			//		//businessData = business.UpdateData(businessData, Convert.ToInt32(Business_ID.Text), Business_Name.Text, Business_Phone.Text, Business_Email.Text, Business_Address.Text, Business_Website.Text, Business_OperationaHours.Text,oldPath);
			//		ClearData();
			//		MessageBox.Show("Business Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//		Grd_User.DataSource = businessData;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private bool Checking()
		{
			//if (businessData.Rows.Count > 0)
			//{
			//	string searchExpression = string.Format("Name like '{0}%'", User_Search.Text);
				
			//	DataRow[] foundRows = businessData.Select(searchExpression);
			//	DataTable dt = new DataTable();// business.GenerateTempTableSchema();
			//	foreach (var row in foundRows)
			//	{
			//		dt.ImportRow(row);	
			//	}
			//	Grd_User.DataSource = dt;
			//	return true;
			//}
			//else
			//{
				return false;
			//}
		}

		private void Browse_Button_Click(object sender, EventArgs e)
		{
			//opf.Filter = "Choose Image(*.jpg;*.png;)|*.jpg;*.png;";

			//if (opf.ShowDialog() == DialogResult.OK)
			//{
			//	Business_Image.Image = Image.FromFile(opf.FileName);
			//	isImageUpdated = true;
			//}
			//else
			//{
			//	isImageUpdated = false;
			//}
		}
		private void Business_Email_Leave(object sender, EventArgs e)
		{
			//if (business.IsEmailValid(Business_Email.Text))
			//{
			//	Business_Email.BackColor = SystemColors.Window;
			//}
			//else
			//{

			//	MessageBox.Show("Please Enter the correct format of Email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	Business_Email.BackColor = Color.Red;
			//}
		}

		private void Business_Email_Click(object sender, EventArgs e)
		{
			User_Password.BackColor = SystemColors.Window;
		}

		private void Business_Phone_Leave(object sender, EventArgs e)
		{
			//if (business.IsPhoneValid(Business_Phone.Text))
			//{
			//	Business_Phone.BackColor = SystemColors.Window;
			//}
			//else
			//{

			//	MessageBox.Show("Please Enter the correct format of Phone like this XXXX-XXXXXXX", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	Business_Phone.BackColor = Color.Red;
			//}
		}

		private void Business_Phone_Click(object sender, EventArgs e)
		{
			User_Username.BackColor = SystemColors.Window;
		}

	}
}
