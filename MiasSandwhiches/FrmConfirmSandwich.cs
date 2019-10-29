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
    public partial class FrmConfirmSandwich : FrmBase
    {
        /*
         * This displays the chosen sandwhich across three list boxs and offers the user a choice of 
         * adding it to the cart, 
         * deleting it
         * adding another sandwich
         * checking out
         */

        private decimal price;
        private bool addedToCart = false;

        public FrmConfirmSandwich()
        {
            InitializeComponent();
        }

        private void FrmConfirmSandwich_Load(object sender, EventArgs e)
        {
            FetchSandwhichDetails(); //retrive from temp storage and set total price
            GenBreadSpreadSauceNames(); //makes a list and displayes it in listbox
            GenFillingsNames();//makes a list and displayes it in listbox
            GenSaladNames();//makes a list and displayes it in listbox
            DisplayPrice();//makes a list and displayes it in listbox
            SetPicture(); 
        }

        private void SetPicture()
        { //uses the fetched details to choose a category and display accordingly
            if (Program.ProcessOrder.ChosenBread.Catagory1 == "Bap")
            {
                pictureBoxImage.BackgroundImage = Properties.Resources.bap_sandwhich;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (Program.ProcessOrder.ChosenBread.Catagory1 == "Baguette")
            {
                pictureBoxImage.Image = Properties.Resources.filledBaguette;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (Program.ProcessOrder.ChosenBread.Catagory1 == "Chiabatta")
            {
                pictureBoxImage.Image = Properties.Resources.filledChiabatta;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (Program.ProcessOrder.ChosenBread.Catagory1 == "Panini")
            {
                pictureBoxImage.Image = Properties.Resources.filledPanini;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (Program.ProcessOrder.ChosenBread.Catagory1 == "Sliced Loaf")
            {
                pictureBoxImage.Image = Properties.Resources.filledSliced;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void FetchSandwhichDetails()
        {  // retrieves the saved sandwhich details 
           // makes a new sandwhich object ready to save to the sandwhiches list and sets the price for the sandwhich
            price = Program.ProcessOrder.ChosenBread.Price +
                    Program.ProcessOrder.ChosenSpread.Price +
                    Program.ProcessOrder.ChosenSauce.Price +
                    Program.ProcessOrder.ChosenFilling.Price +
                    Program.ProcessOrder.ChosenSalad.Price; //adds the compoents together to make a price for the sandwich

            Sandwich sandwhich = new Sandwich(); //create new sandwhich object and set the details
            sandwhich.Bread = Program.ProcessOrder.ChosenBread;
            sandwhich.Spread = Program.ProcessOrder.ChosenSpread;
            sandwhich.Sauce = Program.ProcessOrder.ChosenSauce;
            sandwhich.Fillings = Program.ProcessOrder.ChosenFilling;
            sandwhich.SaladItems = Program.ProcessOrder.ChosenSalad;
            sandwhich.Price = price; //price is the price calulate above
        }

        private void GenBreadSpreadSauceNames()
        {// retrieve bread, spread and sauce  names from temp store and add names to a listbox list then display
            List<string> displayBreadSpreadSauce = new List<string>();
            displayBreadSpreadSauce.Add(Program.ProcessOrder.ChosenBread.Name);
            displayBreadSpreadSauce.Add(Program.ProcessOrder.ChosenSpread.Name);
            displayBreadSpreadSauce.Add(Program.ProcessOrder.ChosenSauce.Name);
            listBoxBreadSpreadSauce.DataSource = displayBreadSpreadSauce;
        }

        private void GenFillingsNames()
        {// retrieve the names of all fillings saved to temp store and add names to a listbox list and display
            List<string> dispayFillings = new List<string>();
            List<Stock> listOfFillings = new List<Stock>();
            listOfFillings = Program.ProcessOrder.ChosenFilling.Fillings;
            foreach (Stock item in listOfFillings)
            {
                dispayFillings.Add(item.Name);
            }
            listBoxFillings.DataSource = dispayFillings;
        }

        private void GenSaladNames()
        {// retrieve the names of all salad items saved to temp store and add names to a listbox list and display
            List<string> displaySalad = new List<string>();
            List<Stock> listOfSalad = new List<Stock>();
            int listlength = Program.ProcessOrder.ChosenSalad.SaladItems.Count;
            listOfSalad = Program.ProcessOrder.ChosenSalad.SaladItems;
            foreach (Stock item in listOfSalad)
            {
                displaySalad.Add(item.Name);
            }
            listBoxSalad.DataSource = displaySalad;
        }

        private void DisplayPrice()
        {   //adjust the price label text to display the price
            string displayPrice = "Price: " + Convert.ToString(price);
            labelPrice.Text = displayPrice;
        }

        private void ClearVariablesStartAnotherSandwhich()
        { // clears all temp sandwich variables and returns to the choose bread form abandoning the current sandwhich
            Program.ProcessOrder.ClearTempSandwhichVars();
            FrmChooseBread frmChooseBread = new FrmChooseBread();
            this.Hide();
            frmChooseBread.ShowDialog();
            this.Close();
        }

        private void SaveSandwhich()
        {// uses the current details to make a new object, 
         // apply the details to it and then add the object 
         // to the temp sandwhichs list in the OrderProcess class
         // set saved to cart to enable duplicate adding checks
            Sandwich newSandwhich = new Sandwich();
            newSandwhich.Bread = Program.ProcessOrder.ChosenBread;
            newSandwhich.Spread = Program.ProcessOrder.ChosenSpread;
            newSandwhich.Sauce = Program.ProcessOrder.ChosenSauce;
            newSandwhich.Fillings = Program.ProcessOrder.ChosenFilling;
            newSandwhich.SaladItems = Program.ProcessOrder.ChosenSalad;
            newSandwhich.Price = price;
            Program.ProcessOrder.ChosenSandwhiches.Add(newSandwhich);
            addedToCart = true; 
            MessageBox.Show("Sandwhich Saved, please now press checkout", "Saved Confirmed");
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        { //checkout button clicked
            if (Program.ProcessOrder.ChosenSandwhiches.Count == 0)
            { //if no items saved to cart, there is nothing to checkout, advise the user so they can fix it. 
                MessageBox.Show("You need to save at leas one sandwhich before you can checkout.", "no saved sandwhiches");
            }
            else
            { //close this form and open the checkout form.
                FrmCheckout frmCheckout = new FrmCheckout();
                this.Hide();
                frmCheckout.ShowDialog();
                this.Close();
            }
        }

        private void BtnAddCart_Click(object sender, EventArgs e)
        { // if item has not been added to the cart already save, if it has get customer confirmation they wish to add another identical sandwich.
            if (!addedToCart) SaveSandwhich();
            else
            {
                if (MessageBox.Show("This item has already been added, add another?", "item already added", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveSandwhich();//saves sandwhich to temp sandwiches list.
                    MessageBox.Show("Item Added", "item added");
                }
            }
        }

        private void BtnClearSandwhich_Click(object sender, EventArgs e)
        {
            //clear all temp sandwich variables, clear display lists to show this to the user. 
            Program.ProcessOrder.ClearTempSandwhichVars();
            List<string> emptyList = new List<string>();
            listBoxBreadSpreadSauce.DataSource = emptyList;
            listBoxFillings.DataSource = emptyList;
            listBoxSalad.DataSource = emptyList;
            MessageBox.Show("Item Cleared, please click add another or checkout.", "item cleared");
        }

        private void BtnNewSandwhich_Click(object sender, EventArgs e)
        {// clears all temp variables, then returns to the choose bread form
            if (!addedToCart)
            {
                if (MessageBox.Show("This sandwich has not been added to the cart. If you continue without adding to the cart it will be lost. Do you wish to continue?", "sandwich loss warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearVariablesStartAnotherSandwhich();
                }
            }
            else ClearVariablesStartAnotherSandwhich();
        }
    }
}
