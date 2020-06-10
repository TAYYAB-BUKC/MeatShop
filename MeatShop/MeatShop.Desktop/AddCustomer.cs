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
            if (customer.AddCustomer(Customer_Name.Text, Customer_Phone.Text))
            {
                Customer_Name.Text = "";
                Customer_Phone.Text = "";
            }
        }

        //private void Customer_Phone_Leave(object sender, EventArgs e)
        //{
        //    if (customer.IsPhoneValid(Customer_Phone.Text))
        //    {
        //        Customer_Phone.BackColor = SystemColors.Window;
        //    }
        //    else
        //    {

        //        MessageBox.Show("Please Enter the correct format of Phone like this XXXX-XXXXXXX", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Customer_Phone.BackColor = Color.Red;
        //    }
        //}

        //private void Customer_Phone_Click(object sender, EventArgs e)
        //{
        //    Customer_Phone.BackColor = SystemColors.Window;
        //}

        private void Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
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
