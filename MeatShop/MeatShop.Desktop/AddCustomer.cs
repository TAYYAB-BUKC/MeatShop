﻿using MeatShop.Database;
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
    public partial class AddCustomer : Form
    {
        Customer customer = new Customer();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void Save_Button_Click(object sender, EventArgs e)
		{
            if (Customer_Phone.BackColor != Color.Red)
            {
                if (customer.AddCustomer(Customer_Name.Text, Customer_Phone.Text))
                {
                    Customer_Name.Text = "";
                    Customer_Phone.Text = "";
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
    }
}