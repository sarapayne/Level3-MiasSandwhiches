using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiasSandwhiches
{
    public partial class FrmCheckout : FrmBase
    {
        /*
         * Displays a list of all ordered sandwiches along with individual prices and the total price
         * Offers the user a choice to pay or cancel the order
         * Payment is not handled in this app, ass this is a kiosk its likely to be a chip and pin card machine.
         * This will mean payments will be procprocessed externally and be beyond the scope of this app.
         * It assume all payment are approved at this stage.
        */

        List<Sandwich> SandwhichesInOrder = new List<Sandwich>();
        BindingList<string> sandwhichNames = new BindingList<string>();
        List<string> reciptList = new List<string>();
        decimal totalPrice = 0;

        public FrmCheckout()
        {
            InitializeComponent();
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            SandwhichesInOrder = Program.ProcessOrder.ChosenSandwhiches; //fetched stored sandwiche list
            CalcTotalPrice(); //add together the price of all sandwiches in the list
            GenSandwhichNames(); //generate a list with all names shown. 
            GenerateReciptList(); //generate a recipt list for the next page based on the sandwhich list
            SaveRecipt(); //store the receipt list in the OrderProcess class.
            listBoxRecipt.DataSource = sandwhichNames; //Display the names list in the listbox
            listBoxRecipt.Enabled = false; //make sure no one can click it!
            SetAmountLable(); //change the text on the amount label to represent the total amount.
        }

        private void CalcTotalPrice()
        {
            foreach (Sandwich sandwhich in Program.ProcessOrder.ChosenSandwhiches)
            {//loops through the list of ordered sandwiches adding the prices together
                totalPrice += sandwhich.Price;
            }
        }

        private void GenSandwhichNames()
        {
            foreach (Sandwich sandwhich in Program.ProcessOrder.ChosenSandwhiches)
            { //loops through the list of chosen sandiches making a string for each one
                string sandwhichName = "£" + Convert.ToString(sandwhich.Price) + " " +
                                        sandwhich.Bread.Catagory2 + " " +
                                        sandwhich.Bread.Catagory3 + " " +
                                        sandwhich.Bread.Catagory1 + " " +
                                        "with" + " " +
                                        sandwhich.Fillings.Fillings[0].Catagory1 + " " +
                                        sandwhich.Fillings.Fillings[0].Catagory2;

                sandwhichNames.Add(sandwhichName); //adds the new string to the list to display
            }
        }

        private void SetAmountLable()
        { //adjusts the text on the total label to show the total value
            string toSet = "Amount to pay £" + Convert.ToString(totalPrice);
            LblOrderTotal.Text = toSet;
        }

        private void GenerateReciptList()
        {  //uses the names list to generate a list to display on the next for as a recipt
            string title = "Mias Sandwhiches Receipt";  
            reciptList.Add(title);
            string date = "Date: " + Convert.ToString(DateTime.Now); 
            reciptList.Add(date);
            reciptList.Add(" ");
            foreach (string item in sandwhichNames)
            {//loops through each name and adds to the list after the title, date and blank line.
                reciptList.Add(item);
            }
            reciptList.Add(" ");//adds a blank line
            string orderTotal = "Order Total £" + Convert.ToString(totalPrice); //makes a string for the totaql
            reciptList.Add(orderTotal);//adds total at the end of the list
        }

        public void SaveRecipt()
        {
            Program.ProcessOrder.ReciptList = reciptList; //saves the receipt list to a temp store in the OrderProcess Class
        }

        private void ReciptPage()
        { //closes this form and loads the receipt form
            FrmRecipt frmRecipt = new FrmRecipt();
            this.Hide();
            frmRecipt.ShowDialog();
            this.Close();
        }

        private void SaveOrder()
        { // makes a new order object, adds the details then saves it to 
          // the orders list in the Storage class, then saves the file to the hdd.
            Order newOrder = new Order(); //new order object
            newOrder.Price = totalPrice; //adds the order price
            newOrder.Date = DateTime.Now;//adds date time now
            newOrder.OrderSandwhiches = Program.ProcessOrder.ChosenSandwhiches;
            Program.ProcessStorage.ListOrders.Add(newOrder); //adds new order to the orders list
            Program.ProcessStorage.SaveOrderDataFile(); //saves orders list to hdd
        }


        private void ClearVars()
        {// clears the temp sandwich variables and chosen sandwich list
            Program.ProcessOrder.ClearTempSandwhichVars();
            Program.ProcessOrder.ChosenSandwhiches.Clear();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please place your card in the slot and enter your pin", "Refer To Payment System"); //assuming chip and pin
            SaveOrder(); //saves the order to the Storage Class
            ClearVars(); //clears all temp variables
            ReciptPage(); //goes to the receipt page.
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            CancelOrder(); //cancels the order
            ReturnToMainMenu(); //returns to the main menu
        }
    }
}
