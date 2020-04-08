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
    public partial class AddUnit : Form
    {
        Unit unit = new Unit();
        public AddUnit()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void Save_Button_Click(object sender, EventArgs e)
		{
            if (unit.AddUnit(Unit_Name.Text, Unit_Prefix.Text))
            {
                Unit_Name.Text = "";
                Unit_Prefix.Text = "";
            }
        }
	}
}
