using PrinterUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using PrinterUtility.EscPosEpsonCommands;

namespace MeatShop.Database
{
    class Receipt
    {
        //***********************************************************************
         /// <Printer commands and settings objects are here>
         EscPosEpson obj;
         PrinterSettings ps;
         /// </Printer commands and settings objects are here>
         //***********************************************************************


        //***********************************************************************
        
        string ReceiptHeading       = "AWAMI MEAT SHOP";
        string ReceiptSubHeading    = "Bhains Colony road no. 6 \n GST # ********6083";
        string ReceiptSubHeading2   = "0312 2166052";
        //string ReceiptBarCode       = "0312 2166052";
        string ReceiptFooter        = "------Thank you for shoping------";
        /// </All Receipt Text Here>
        //************************************************************************


        //***********************************************************************
        /// <Printer commands and settings cunstructor here>
        public Receipt()
        {
            obj = new EscPosEpson();
            ps = new PrinterSettings();
        }
        /// </Printer commands and settings cunstructor here>
        //***********************************************************************


        //****************************************************************************************************************************
        /// <BillReceipt>
        public void BillReceipt(List<Items> Items, String ReceiptNo,string discount, string balance, string paid, string retrn, string total_amount)
        {
            double total = 0; // Receipt Total Amount Variable
            
           // int x; // Random Receipt Number Variable Here
          //  Random y = new Random(); // Generating Random Receipt Number Here
          //  x = y.Next(1000,10000); // Random Receipt Number Here
          //  string OrderType = (IsTakeAway == true) ? "Take-Away" : "Dine-in"; // Order Type Here
           // int MachineNo = 003; // Machine Number Here


            // Position of all Receipts' headings here --- Less than 0 is Left Position and Greater than 0 is Right Position
            string OrderNoPosition = "-5"; // {Order No.} Position
            //string OrderTypePosition = "42"; // {Order Type} Position
            string DatePosition = "0"; // {Date} Position
            //string MachineNoPosition = "18"; // {Machine No.} Position
            //string WaiterNoPosition = "0"; // {Waiter No.} Position
           // string TableNoPosition = "39"; // {Table No.} Position
            
            var BytesValue = new byte[0];
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.DoubleWidth2());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.FontSelect.FontA());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Center());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(ReceiptHeading + " \n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(ReceiptSubHeading + " \n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(ReceiptSubHeading2 + " \n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "--------------------------------------------");
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.DoubleWidth2());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Order\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Left());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0," + OrderNoPosition + "}\n", "Order No.  : " + ReceiptNo));
            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0," + DatePosition + "}\n", "Date       : " + DateTime.Now));
            //if (IsTakeAway == false)
            //{
            //    BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0," + WaiterNoPosition + "}{1," + TableNoPosition + ":N2}\n", "Waiter No. : " + WaiterNo, "Table No.  : " + TableNo));
            //}
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "--------------------------------------------");
            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{1,2}{2,8}{3,10}\n", "Item", "QTY", "Price", "Net"));
            //BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-35}{1,6}{2,9}{3,12:N2}\n", "Item", "QTY", "Price", "Net"));
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "--------------------------------------------");
            foreach (var item in Items)
            {
                BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{1,2}{2,8}{3,10}\n", item.ItemName, item.ItemQTY, item.ItemUnitPrice,Convert.ToInt32(Math.Round(Convert.ToDouble(item.ItemQTY) *Convert.ToDouble(item.ItemUnitPrice)))));
                //total += (Convert.ToDouble(item.ItemQTY) * Convert.ToDouble(item.ItemUnitPrice));
            }
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "--------------------------------------------");
            if (discount != "0")
            {
                BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-5}{1,16:N2}\n", "Discount", discount));
                total_amount = (Convert.ToInt32(total_amount)- Convert.ToInt32(discount)).ToString();
            }
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.DoubleWidth2());
            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-5}{1,16:N2}\n", "Total", total_amount));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
         
            if (balance!="0")
            {
                BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-4}{1,16:N2}\n", "Balance", balance));

            }
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "--------------------------------------------");
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Lf());
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Left());
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Center());
            //BytesValue = PrintExtensions.AddBytes(BytesValue, obj.QrCode.Print(ReceiptBarCode, PrinterUtility.Enums.QrCodeSize.Medio));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Center());
            BytesValue = PrintExtensions.AddBytes(BytesValue, ReceiptFooter);
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("\n\n\n\n\n\n\n"));
            string GS = Convert.ToString((char)29);
            string ESC = Convert.ToString((char)27);
            string COMMAND = "";
            COMMAND = ESC + "@";
            COMMAND += GS + "V" + (char)1;
            BytesValue = PrintExtensions.AddBytes(BytesValue, COMMAND);
            RawPrinterHelper.SendFileToPrinter(ps.PrinterName, BytesValue);
        }
        /// </BillReceipt>
        //******************************************************************************************************************************


     
    }
}
