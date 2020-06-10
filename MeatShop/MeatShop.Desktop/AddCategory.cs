using MeatShop.Database;
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
    public partial class AddCategory : Form
    {
        Category category = new Category();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void Save_Button_Click(object sender, EventArgs e)
		{
            if (category.AddCategory(Category_Name.Text))
            {
                Category_Name.Text = "";
            }
        }

        private void Category_Name_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
