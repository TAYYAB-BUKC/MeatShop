﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop
{
    public partial class Home : Form
    {
		private bool Check;
        public Home(bool check)
        {
			InitializeComponent();
            hideSubMenu();
			if (check)
			{
				button2.Hide();
				button3.Hide();
				//button5.Hide();
				//button6.Hide();
				btnTools.Hide();
				//btnEqualizer.Hide();
				//button7.Hide();
			}
		}

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
           // panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            User_Panel.Visible = false;
            Category_Panel.Visible = false;
            Units_Panel.Visible = false;
            Product_Panel.Visible = false;


        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
           
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());

           hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
           // showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
           
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelMediaSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
            hideSubMenu();
        }

		private void button5_Click_1(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
			hideSubMenu();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
            hideSubMenu();

        }

		private void button1_Click_1(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
			hideSubMenu();
		}

		private void btnTools_Click_1(object sender, EventArgs e)
		{
			showSubMenu(panelToolsSubMenu);

		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			//showSubMenu(panel1);
				}

		private void button11_Click(object sender, EventArgs e)
		{
			hideSubMenu();


		}

		private void button10_Click_1(object sender, EventArgs e)
		{
			hideSubMenu();

		}

		private void btnEqualizer_Click_1(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
			hideSubMenu();


		}

		private void button7_Click_2(object sender, EventArgs e)
		{
			openChildForm(new ManageCategory());
			hideSubMenu();
		}

		private void button13_Click_1(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
			hideSubMenu();
		}

		private void button12_Click_1(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
			hideSubMenu();
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			openChildForm(new AddCategory());
			hideSubMenu();
		}

        private void btnTools_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void User_Click(object sender, EventArgs e)
        {
            showSubMenu(User_Panel);
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            openChildForm(new AddUser());
            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageUser());
            hideSubMenu();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            showSubMenu(Category_Panel);
        }

        private void button7_Click_3(object sender, EventArgs e)
        {
            openChildForm(new AddCategory());
            hideSubMenu();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            openChildForm(new ManageCategory());
            hideSubMenu();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            openChildForm(new AddUnit());
            hideSubMenu();
        }

        private void Unit_Click(object sender, EventArgs e)
        {
            showSubMenu(Units_Panel);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageUnit());
            hideSubMenu();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            showSubMenu(Product_Panel);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AddProduct());
            hideSubMenu();
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            openChildForm(new ManageProduct());
            hideSubMenu(); 
        }
    }
}
