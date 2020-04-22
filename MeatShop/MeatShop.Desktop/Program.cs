using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop.Desktop
{
	static class Program                                                                                                                                                                                                                                                                                                                                                                                        
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Home(false));
			//Application.Run(new Sales());
			//Application.Run(new ManageProduct());
		}
	}
}
