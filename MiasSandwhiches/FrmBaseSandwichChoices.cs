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
    public partial class FrmBaseSandwichChoices : FrmBase
    {
        /*
        main control script for all selections made while while creating a sandwich
        
        Ordering Overview
        =================
        1. Customer picks from displayed bread options (only instock items show). This is saved as a bread stock in the order process class
        2. Customer picks from displayed spread options (only instock items show). This is saved as a spread stock in the order process class
        3. Customer picks from displayed sauce options (only instock items show). This is saved as a sauce stock in the order process class
        4. Customer Picks Multiple Fillings (only instock items show), these are combined into a fillings list and stored in the OrderProcess class
        5. Customer picks from multiple salad items (only instock items show), these are added to a salad items list and stored in the OrderProcess class
        6. Customer confirms sandwihch, at which point all above is combined into a sandwhich object, which is then added to a list or sandwiches
        7. Sandwhich creation variables cleared
        8. Customer makes more sandwhiches if required, above steps repate
        9. At checkout the list of sandwhich objects is used to display costs and is all combined into an orders object with date, time, price.
        10. Customer pays and prints  recipt if required
        12. Order object is added to the orders list.

        Stock Control Overview
        =======================
        When an item is selected the stock value for this item is reduced by 1. A record of this is placed in the reserved stock list. 
        If the customer completes the transaction the reserved list is cleard.
        If they don't for any reasons the reserved list is used to reset the stock levels before its cleared. Including system crashes or power cuts
        Only instock items are ever displayed to customers.
        This method prevents out of stock sales, and with just a small change would still protect even in a multi user enviroment. 
        */

        public string ActiveMainCatagory { get; set; } //used by each of the forms which inherits this one so the script knows whether 
        //it is dealing with bread, spread, sauce, filling or salad
        private BindingList<Stock> listCat0Items = new BindingList<Stock>(); //list of stock items with Cat0 matching the active category
        private BindingList<Stock> listCat1SelectedItems = new BindingList<Stock>(); //list of stock items with Cat1 matching the active category and cat0 choice
        private BindingList<Stock> listCat2SelectedItems = new BindingList<Stock>(); //list of stock items with Cat2 matching the active category and cat2 choice
        private BindingList<Stock> listCat3SelectedItems = new BindingList<Stock>(); //list of stock items with Cat3 matching the active category and cat2 choice
        private BindingList<string> listAvailCat1 = new BindingList<string>(); //list of availible items based on Cat0 Choice
        private BindingList<string> listAvailCat2 = new BindingList<string>();//list of availible items based on Cat0 and Cat1 Choice
        private BindingList<string> listAvailCat3 = new BindingList<string>();//list of availible items based on Cat0 , Cat1 and Cat2 Choices
        private string cat1Choice;
        private string cat2Choice; // names of each slection level made
        private string cat3Choice;
        public bool allowContinue = false; //controls allow move to next form
        private Stock chosenCat3Item = new Stock(); //final selection

        private int stockID; //index of the chosen item in the stock list
        private string stockName; //name pulled from the stock list base on the index
        private int quant; //quanity before this selection
        private int newStockQuant; //quantity after this selection

        //store filling in list of fillings properties.
        List<Stock> listChosenCat3Items = new List<Stock>();
        BindingList<string> listChosenCat3Names = new BindingList<string>();

        public FrmBaseSandwichChoices()
        {
            InitializeComponent();
        }

        private void FrmBaseSandwichChoices_Load(object sender, EventArgs e)
        {

        }

        public void Init()
        {
            GetAllCat0Stock(); //populate cat0 stock choices based on active type
            GenListCat1Avail(); // gen list of availible cat1 items based on the above list
            listBoxCat1.DataSource = listAvailCat1; //display cat1 items in cat1 list
            if (listAvailCat1.Count == 0) OutOfStock("Cat1"); //security agaisnt the possibility there is no stock... can cause crashes without this.
            listChosenCat3Names.Clear(); //not sure why this is needed but it clears the list at the start.. not having this produced unexpected results
            listBoxChosenFillings.DataSource = listChosenCat3Names; //initially sets the data source for the cat3 box. 
        }

        private void GenListCat1Avail()
        { //generates cat 1 availible items by looping through the cat0 items and the active category
            listAvailCat1.Clear();
            foreach (Stock item in listCat0Items)
            {
                if (!listAvailCat1.Contains(item.Catagory1) && item.Quantity > 0) //filters out out of stock items and prevents duplicates
                {
                    listAvailCat1.Add(item.Catagory1); //adds cat1 name to list
                }
            }
        }

        private void GenlistCat2Avail()
        {//generates a list of availible cat2 items based on active category and choice from cat1 
            listAvailCat2.Clear();
            foreach (Stock item in listCat1SelectedItems)
            {
                if (!listAvailCat2.Contains(item.Catagory2) && item.Quantity > 0) //filters out of stock items and prevents duplicates
                {
                    listAvailCat2.Add(item.Catagory2); //adds cat2 name to availible list
                }
            }
        }

        private void GenListCat3Avail()
        { //generates a list of availible cat3 items base on active category and choices from cat1 and cat2
            listAvailCat3.Clear();
            foreach (Stock item in listCat2SelectedItems)
            {
                if (!listAvailCat3.Contains(item.Catagory3) && item.Quantity > 0) //filters out of stock items and prevents duplicates
                {
                    listAvailCat3.Add(item.Catagory3); //adds cat3 name to the availible list
                }
            }
        }

        private void GenlistCat1SelectedItems()
        { //generates a list of stock objects which have selected Cat0 the cat1 Choice. 
            listCat1SelectedItems = new BindingList<Stock>();
            foreach (Stock item in listCat0Items)
            {
                if (item.Catagory1 == cat1Choice && item.Quantity > 0)//filters out of stock items
                {
                    listCat1SelectedItems.Add(item);
                }
            }
        }

        private void GenlistCat2SelectedItems()
        {//generates a list of stock objects which have selected Cat0 the cat1 & cat2 Choice. 
            listCat2SelectedItems = new BindingList<Stock>();
            foreach (Stock item in listCat1SelectedItems)
            {
                if (item.Catagory2 == cat2Choice && item.Quantity > 0)//filters out of stock items
                {
                    listCat2SelectedItems.Add(item);
                }
            }
        }

        private void GenlistCat3SelectedItems()
        {//generates a list of stock objects which have selected Cat0 the cat1, 2 and 3 Choice.  - should always be one item
            listCat3SelectedItems = new BindingList<Stock>();
            foreach (Stock item in listCat2SelectedItems)
            {
                if (item.Catagory3 == cat3Choice && item.Quantity > 0)//filters out of stock items
                {
                    listCat3SelectedItems.Add(item);
                }
            }
        }

        private void GetAllCat0Stock()
        {
            listCat0Items = new BindingList<Stock>();
            foreach (Stock item in Program.ProcessStorage.ListStock)
            { //loops through the stock list finind all Cat0 items matching the active category
                if (item.Catagory0 == ActiveMainCatagory && item.Quantity > 0)
                {
                    listCat0Items.Add(item);
                }
            }
        }

        private void SetLablePrice()
        { //sets the text property of the price label 
            decimal displayPrice = chosenCat3Item.Price;
            string priceLabel = "Item Price: £" + Convert.ToString(chosenCat3Item.Price);
            labelItemPrice.Text = priceLabel;
        }

        private void OutOfStock(string catagory)
        { //prevents empty clickable lists which otherwise can produce crashes. 
            if (catagory == "Cat1")
            { //when no cat1 stock is found with the given choice, locks later choices and informs the user to try again
                listAvailCat1.Clear();
                listAvailCat1.Add("Out Of Stock");
                listBoxCat1.DataSource = listAvailCat1;
                listBoxCat1.Enabled = false;
                listBoxCat2.Enabled = false;
                listBoxCat3.Enabled = false;
                MessageBox.Show("A primary catagory of a sandwhich such as bread is showing as out of stock. Please seek staff help. Press ok to return to the main menu.", "out of stock");
                Program.ProcessStorage.RestoreReservedItems();
                ReturnToMainMenu();
            }
            else if (catagory == "Cat2")
            {//when no cat2 stock is found with the given choice, locks later choices and informs the user to try again
                listAvailCat2.Clear();
                listAvailCat2.Add("Out Of Stock");
                listBoxCat2.DataSource = listAvailCat2;
                listBoxCat2.Enabled = false;
                listBoxCat3.Enabled = false;
                MessageBox.Show("The item you chose is out of stock. Please choose another from the previous choices", "Out of Stock");
            }
            else if (catagory == "Cat3")
            {//when no cat3 stock is found with the given choice, locks later choices and informs the user to try again
                listAvailCat3.Clear();
                listAvailCat3.Add("Out Of Stock");
                listBoxCat3.DataSource = listAvailCat3;
                listBoxCat3.Enabled = false;
                MessageBox.Show("The item you chose is out of stock. Please choose another from the previous choices", "Out of Stock");
            }
        }

        public void SendCat3ToStorageClass()
        { //selects the active category and then sends the list to a temp store in the OrderProcess Class
            decimal cat3Price = 0; 
            foreach (Stock item in listChosenCat3Items)
            { //calculates the total price of the selected fillings / salad items
                cat3Price += item.Price;
            }
            if (ActiveMainCatagory == "Filling")
            { //creates a new filling object and sends to storage in the OrderProcess Class
                Filling newFilling = new Filling();
                newFilling.Price = cat3Price;
                newFilling.Fillings = listChosenCat3Items;
                Program.ProcessOrder.ChosenFilling = newFilling;
            }
            else if (ActiveMainCatagory == "Salad")
            {// creates a new salad object and sends to storage in the OrderProces Class.
                Salad newSalad = new Salad();
                newSalad.Price = cat3Price;
                newSalad.SaladItems = listChosenCat3Items;
                Program.ProcessOrder.ChosenSalad = newSalad;
            }
        }

        private void ResetFillingEntry()
        { // resets all variables to allow for entry of new filling / salad items
            listCat1SelectedItems.Clear();
            listCat2SelectedItems.Clear();
            listCat3SelectedItems.Clear();
            listAvailCat1.Clear();
            listAvailCat2.Clear();
            listAvailCat3.Clear();
            cat1Choice = null;
            cat2Choice = null;
            cat3Choice = null;
            chosenCat3Item = null;
            GenListCat1Avail();
            listBoxCat1.DataSource = listAvailCat1;
            ResetVisibilityAndEnableDisableSettings();
        }

        private void ResetVisibilityAndEnableDisableSettings()
        { //resets the clickability and visiblity of list box's to allow for entry of multiple items
            listBoxCat3.Enabled = false;
            listBoxCat3.Visible = false;
            listBoxCat2.Enabled = false;
            listBoxCat2.Visible = false;
            listBoxCat1.Enabled = true;
            listBoxCat1.Visible = true;
        }

        public void SaveCat3ItemInCat3List()
        {//adds the current selected item to the list of selected items (either filling or salad)
            listChosenCat3Items.Add(chosenCat3Item);
            GenChosenFillingsList();
        }

        private void GenChosenFillingsList()
        {// uses the selected items in the cat3 selected items list to generate and dispalay names in the list box
            listBoxCat3.Enabled = false;
            listBoxCat3.Visible = false;
            listChosenCat3Names.Clear();
            List<Stock> listChosenFillingsToProcess = new List<Stock>();
            listChosenFillingsToProcess = listChosenCat3Items;
            foreach (Stock item in listChosenFillingsToProcess)
            {
                listChosenCat3Names.Add(item.Name);
            }
            listBoxChosenFillings.DataSource = listChosenCat3Names;
            allowContinue = true;
        }

        private void Cat1Confirm()
        { //come here when cat1 list is clicked
            listBoxCat2.Enabled = true;
            labelItemPrice.Visible = false; //enable and display cat2 list box
            allowContinue = false; //blocks contiue button
            int selectedIndex = listBoxCat1.SelectedIndex;//sets selected index based on user selection
            cat1Choice = listAvailCat1[selectedIndex]; //sets the users choice
            GenlistCat1SelectedItems(); //makes item list of all posible stock based on active catagory and cat1 choice
            GenlistCat2Avail(); //uses the above list to make a list of all availible cat2 choices
            listBoxCat2.DataSource = listAvailCat2; //displays above list in cat2 list box
            if (listAvailCat2.Count == 0) OutOfStock("Cat2"); //this avoids crashes, message box and try again
            else if (listAvailCat2.Count == 1 && listAvailCat2[0] == "Unused")
            { //prevents list box's displaying "Unused", auto confirms as there is only 1 choice. 
              //Improves the user experience
                listBoxCat2.Enabled = false;
                listBoxCat2.Visible = false;
                Cat2Confirm(); //same as if the user clicked to confirm Cat2
            }
            else
            { //displays Cat3 list box and enables it. 
                listBoxCat2.Visible = true;
                listBoxCat3.Enabled = false;
                listBoxCat3.Visible = false;
            }
        }

        private void Cat2Confirm()
        {
            allowContinue = false; //prevents continue button 
            listBoxCat3.Enabled = true; //enables cat3 list box
            labelItemPrice.Visible = false; //makes sure the price is hidden untill cat3 is selected
            int selectedIndex = listBoxCat2.SelectedIndex; //sets selected index based on user selection
            cat2Choice = listAvailCat2[selectedIndex];//sets the users choice
            GenlistCat2SelectedItems(); //makes item list of all posible stock based on active catagory cat1 and cat2 choices
            GenListCat3Avail();//uses the above list to make a list of all availible cat3 choices
            listBoxCat3.DataSource = listAvailCat3; //displays above list in cat3 list box
            if (listAvailCat3.Count == 0) OutOfStock("Cat3");//this avoids crashes, message box and try again
            else if (listAvailCat3.Count == 1 && listAvailCat3[0] == "Unused")
            {//prevents list box's displaying "Unused", auto confirms as there is only 1 choice. 
             //Improves the user experience
                listBoxCat3.Enabled = false; //displays Cat3 list box and enables it
                listBoxCat3.Visible = false;
                Cat3Confirm(); //same as if the user clicked to confirm Cat3
            }
            else listBoxCat3.Visible = true;//displays Cat3 list box
        }

        private void Cat3Confirm()
        {
            allowContinue = true; // enables the continue button, 
            labelItemPrice.Visible = true; //displays the price label
            int selectedIndex = listBoxCat3.SelectedIndex; //sets the selected index for cat3 choices based on user selection
            cat3Choice = listAvailCat3[selectedIndex]; //sets the cat 3 choice based on the above index
            GenlistCat3SelectedItems(); //makes a list of all posible stock items
            if (listCat3SelectedItems.Count != 1)
            {//error checking, nothing more. 
                MessageBox.Show("More thank one item selected. This should not be possible, contact support.", "Debug");
            }
            chosenCat3Item = listCat3SelectedItems[0]; //sets the chosen item 
            AdjustStockLevels(); //reduces the stock level for this item
            SetLablePrice(); //sets the text on the price label to display this items price

            if (ActiveMainCatagory == "Bread" || ActiveMainCatagory == "Spread" || ActiveMainCatagory == "Sauce")
            {// these three are single item selections so we prevent the user breaking the app by being click happy. 
             //Then save the selection to the OrderProcess Class
                listBoxCat1.Enabled = false; //turns of clickability of listbox
                listBoxCat2.Enabled = false; //turns of clickability of listbox
                listBoxCat3.Enabled = false; //turns of clickability of listbox
                SaveStock(); // saves the stock to the OrderProces 
            }
            else if (ActiveMainCatagory == "Filling" || ActiveMainCatagory == "Salad")
            { //These two can have multiple items. Selected items list box is displayed, along with items chosen. 
              //Listbox's visiblity and clickability adjusted to allow for new item choices
                listBoxCat3.Enabled = false; //prevent clicks for now
                listBoxCat3.Visible = false; //make list box visible
                listBoxChosenFillings.Enabled = true; //enable chosen items list box
                listBoxChosenFillings.Visible = true; //make chosen items list box visible
                if (ActiveMainCatagory == "Salad") LableFillings.Text = "Chosen Salad Items";// small user experience thing
                LableFillings.Visible = true; //set the label visible
                SaveCat3ItemInCat3List(); //save chosen item in the chosen items list
                ResetVisibilityAndEnableDisableSettings(); //allows for further selections of this type
                ResetFillingEntry(); //allows for further selections of this type
            }
        }

        private void SaveStock()
        { // chooses where to save based on active category and then saves to ProcessOrder Class
            Stock stockToSave = new Stock();
            stockToSave = chosenCat3Item;
            if (ActiveMainCatagory == "Bread") Program.ProcessOrder.ChosenBread = stockToSave;
            else if (ActiveMainCatagory == "Spread") Program.ProcessOrder.ChosenSpread = stockToSave;
            else if (ActiveMainCatagory == "Sauce") Program.ProcessOrder.ChosenSauce = stockToSave;
        }

        private void AdjustStockLevels()
        { // makes a new reserved stock holding just the name and quantity used for the chosen stock item. 
          // Saves to the reserved stock list in the Storage Class. Adjusts the quantity value in the 
          // corresponding stock object in the stock list in the Storage Class
            ReservedStock reservedStock = new ReservedStock();
            reservedStock.Name = chosenCat3Item.Name; //copies the name from the chosen item to the reserved stock object
            reservedStock.Quantity = 1; //for now this is always 1, but having it here allows for future expansion.
            Program.ProcessStorage.ListReservedStock.Add(reservedStock); //adds to the reserved stock list in the Storage Class
            stockName = chosenCat3Item.Name; 
            newStockQuant = quant - 1; //sets the new quantity
            for (int i = 0; i < Program.ProcessStorage.ListStock.Count; i++)
            {
                if (Program.ProcessStorage.ListStock[i].Name == stockName)
                { //loop through the stock list untill we find an object with the same name attribute. 
                    stockID = i; //set the stock id for this item
                    break; //drop out of the loop as we are done. 
                }
            }
            Stock stockItem = new Stock(); //make new stock item
            stockItem = Program.ProcessStorage.ListStock[stockID]; //copy the details from the original stock list
            quant = stockItem.Quantity; //gets and sets the current quantity
            newStockQuant = quant - 1;//sets the new quantity
            Program.ProcessStorage.ListStock[stockID].Quantity = newStockQuant; //sets the new quantity in the stock list
            Program.ProcessStorage.SaveStockDataFile(); //saves the stock file to the hdd
        }

        private void listBoxCat1_Click(object sender, EventArgs e)
        { //come here when listbox cat1 clicked
            Cat1Confirm();
        }

        private void listBoxCat2_Click(object sender, EventArgs e)
        {//come here when listbox cat2 clicked
            Cat2Confirm();
        }

        private void listBoxCat3_Click(object sender, EventArgs e)
        {//come here when listbox cat3 clicked
            Cat3Confirm();
        }

        public virtual void BtnCancelOrder_Click(object sender, EventArgs e)
        { //clears all temp variables and returns to the main menu
            CancelOrder();
            ReturnToMainMenu();
        }

        public virtual void BtnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
