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

namespace MeatShop
{
    public partial class Add_Category : Form
    {
		public static string con = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		public Add_Category()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

		private void Clinic_Load(object sender, EventArgs e)
		{
		
		}

		private void Save_Button_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sql = new SqlConnection(con);
				sql.Open();
				SqlCommand cmd = new SqlCommand("Clinic_Insertion", sql) { CommandType = CommandType.StoredProcedure };
				cmd.Parameters.AddWithValue("@Clinic_Name", SqlDbType.VarChar).Value = Category_Name.Text;
				cmd.ExecuteNonQuery();
				MessageBox.Show("Information saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Category_Name.Text = "";
			}
			catch (Exception)
			{
				MessageBox.Show("Oops! Something went wrong please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//private void hideSubMenu()
		//{
		//	panelMediaSubMenu.Visible = false;
		//	// panelPlaylistSubMenu.Visible = false;
		//	panelToolsSubMenu.Visible = false;
		//}


		private void Update_Button_Click(object sender, EventArgs e)
		{
			//openChildForm(new Clinic_Manipulation());

			//hideSubMenu();
		}
		//private Form activeForm = null;

		//private void openChildForm(Form childForm)
		//{
		//	if (activeForm != null) activeForm.Close();
		//	activeForm = childForm;
		//	childForm.TopLevel = false;
		//	childForm.FormBorderStyle = FormBorderStyle.None;
		//	childForm.Dock = DockStyle.Fill;
		//	panelChildForm.Controls.Add(childForm);
		//	panelChildForm.Tag = childForm;
		//	childForm.BringToFront();
		//	childForm.Show();
		//}
	}
}
