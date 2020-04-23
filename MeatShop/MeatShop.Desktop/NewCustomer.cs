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
    public partial class NewCustomer : Form
    {
        Customer customer = new Customer();
        private Sales sales;
        public NewCustomer(Sales form)
        {
            InitializeComponent();
            sales = form;
        }

		private void Save_Button_Click(object sender, EventArgs e)
		{
            if (Customer_Phone.BackColor != Color.Red)
            {
                if (customer.AddCustomer(Customer_Name.Text, Customer_Phone.Text))
                {
                    int id = customer.GetID();
                    customer.FillCombo(sales.Sale_Customer);
                    sales.Sale_Customer.SelectedValue = id;
                    sales.ActiveControl = null;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter the correct format of Phone like this XXXX-XXXXXXX", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Customer_Phone_Leave(object sender, EventArgs e)
        {
            if (customer.IsPhoneValid(Customer_Phone.Text))
            {
                Customer_Phone.BackColor = SystemColors.Window;
            }
            else
            {
                MessageBox.Show("Please Enter the correct format of Phone like this XXXX-XXXXXXX", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Customer_Phone.BackColor = Color.Red;
            }
        }

        private void Customer_Phone_Click(object sender, EventArgs e)
        {
            Customer_Phone.BackColor = SystemColors.Window;
        }

        private void Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Customer_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
