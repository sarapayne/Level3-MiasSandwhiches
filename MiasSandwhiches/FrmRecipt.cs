using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace MiasSandwhiches
{
    public partial class FrmRecipt : FrmBase
    {
        /*
         * Displays the receipt list made on the checkout page in the listBox
         * Gives the user the option to print the receipt
         * finish button returns to the main menu.
        */ 

        public FrmRecipt()
        {
            InitializeComponent();
        }

        private void FrmRecipt_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            listBoxRecipt.DataSource = Program.ProcessOrder.ReciptList; //display saved receipt list in the listbox
            Program.ProcessStorage.ClearReservedStock(); // all items now paid for, clear the reserved items list
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void BtnPrintRecipt_Click(object sender, EventArgs e)
        { //generate a string from the receipt list and send to the default printer
            string recipt = "";
            foreach (string item in Program.ProcessOrder.ReciptList)
            {//loops through the receipt list adding items to a string
                recipt += item;
                recipt += " ";
                recipt += "\n";
            }

            PrintDocument document = new PrintDocument();
            document.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {//performs the print operation
                e1.Graphics.DrawString(recipt, new Font("Times New Roman", 12), new SolidBrush(Color.Black), 
                    new RectangleF(0, 0, document.DefaultPageSettings.PrintableArea.Width, 
                    document.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error printing your receipt, please contact a member of staff for help", "Printing error");
                //throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
