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
    public partial class FrmAddStock : FrmBaseStock
    {
        private List<string> listLevel0;
        private List<StockCategory> existingStockCatagories;
        private string level0Selection;
        private BindingList<string> listLevel1Choices;
        private string level1Selection;
        private BindingList<string> listLevel2Choices;
        private string level2Selection;
        private BindingList<string> listLevel3Choices;
        private string level3Selection;
        private decimal price;
        private int quant;
        private Image image;
        private string name;
        private bool enteredPriceLessThanZero = false;
        private bool enteredQuantityLessThanZero = false;
        private bool hasMoreThan2Decimals;
        private bool saveBtnEnabled = false;

        public FrmAddStock()
        {
            InitializeComponent();
        }

        private void FrmAddStock_Load(object sender, EventArgs e)
        {
            Program.ProcessStorage.SortStockFile();
            GetExistingCatagories();
            InitLevel0();
        }

        private void GetExistingCatagories()
        {
            existingStockCatagories = new List<StockCategory>();
            existingStockCatagories = Program.ProcessStorage.ListStockCatagories;
        }

        private void InitLevel0()
        {// populates the Catgory0 choices
            listLevel0 = new List<string>() { "Bread", "Filling", "Salad", "Sauce", "Spread" };
            EnableLevel0AndDisableOthers();
            listBoxLevel0.DataSource = listLevel0;
        }

        private void InitLevel1()
        {//sets for controls for level1 entry
            DisableLevel0AndEnableLevel1();
            listLevel1Choices = new BindingList<string>();
            GenLevel1Choices();
            listBoxLevel1.DataSource = listLevel1Choices;
        }

        private void InitLevel2()
        {//sets form controls for level 2 entry
            DisableLevel1AndEnableLevel2();
            listLevel2Choices = new BindingList<string>();
            GenLevel2Choices();
            listBoxLevel2.DataSource = listLevel2Choices;
        }

        private void InitLevel3()
        {//sets form controls for level 3 entry
            DisableLevel2AndEnableLevel3();
            listLevel3Choices = new BindingList<string>();
            GenLevel3Choices();
            listBoxLevel3.DataSource = listLevel3Choices;
        }

        private void GenLevel1Choices()
        { //uses the stock list along with chosed Category0 item to make a list choice for category 1
            listLevel1Choices = new BindingList<string>();
            listLevel1Choices.Clear();
            foreach (StockCategory item in existingStockCatagories)
            {
                if (item.Catagory0 == level0Selection)
                {
                    if (listLevel1Choices.Contains(item.Catagory1))
                    {
                        // why does this function not allow !.Contains.. grrr
                    }
                    else listLevel1Choices.Add(item.Catagory1);
                }
            }
            listBoxLevel1.DataSource = listLevel1Choices;
        }

        private void GenLevel2Choices()
        { //uses the chosen category 0 and category 1 choices to generate a category2 list of choices
            listLevel2Choices = new BindingList<string>();
            listLevel2Choices.Clear();
            foreach (StockCategory item in existingStockCatagories)
            {
                if (item.Catagory0 == level0Selection && item.Catagory1 == level1Selection)
                { 
                    if (listLevel2Choices.Contains(item.Catagory2))
                    {
                        //why does this function not allow !.Contains.. grrr
                    }
                    else listLevel2Choices.Add(item.Catagory2);
                }
            }
            listBoxLevel2.DataSource = listLevel2Choices;
        }

        private void GenLevel3Choices()
        { //uses chosed category 0, category 1 and category 2 to create a choice for category 3
            listLevel3Choices = new BindingList<string>();
            listLevel3Choices.Clear();
            foreach (StockCategory item in existingStockCatagories)
            {
                if (item.Catagory0 == level0Selection && item.Catagory1 == level1Selection && item.Catagory2 == level2Selection)
                {
                    if (listLevel3Choices.Contains(item.Catagory3))
                    {
                        //why does this function not allow !.Contains.. grrr
                    }
                    else listLevel3Choices.Add(item.Catagory3);
                }
            }
            listBoxLevel3.DataSource = listLevel3Choices;
        }

        public void ValidateEntries()
        { //validates all user entry
            bool isDec = decimal.TryParse(textBoxPrice.Text, out decimal numberDec);
            bool isInt = int.TryParse(textBoxQuantity.Text, out int numberInt);
            if (isDec)
            {//assuming we have a decimal price this ensures its only got one or two decimal places
                decimal decTimes100 = numberDec * 100;
                int intTimes100 = (int)decTimes100;

                if (decTimes100 != intTimes100) hasMoreThan2Decimals = true;
                else hasMoreThan2Decimals = false;
            }
            if (numberDec < 0) enteredPriceLessThanZero = true; //checks for the price being less than 0
            else enteredPriceLessThanZero = false;
            if (numberInt < 0) enteredQuantityLessThanZero = true;
            else enteredQuantityLessThanZero = false; // checks for quantity being less than 0
            if (isDec && !hasMoreThan2Decimals && numberDec >= 0 && isInt && numberInt >= 0 && pictureBoxImage.Image != null)
            { //does the actual check and update
                price = numberDec;
                quant = numberInt;
                image = pictureBoxImage.Image;
                SaveStock();
                ResetDisplay();
            }
            else
            { //error messages related to above conditions if they are not met
                if (!isDec) MessageBox.Show("The price you entered is not a decimal number", "Price Invalid");
                else if (!isInt) MessageBox.Show("The quantity you entered is not a valid whole number", "Quantity Invalid");
                else if (enteredPriceLessThanZero) MessageBox.Show("The price you entered is less than 0. Please amend", "Price Error");
                else if (enteredQuantityLessThanZero) MessageBox.Show("The quantity you entered is less than 0. Please amend", "Quantity Error");
                else if (pictureBoxImage.Image == null) MessageBox.Show("Please select a product image then try again.", "Picture Missing");
                else if (hasMoreThan2Decimals) MessageBox.Show("The price you entered has more than 2 decimal places, please adjust and try again", "price eror");
            }
        }

        public void ResetDisplay()
        { //closes this window and opens a fresh copy allowing for duplicated object names
            if (this.Name == "frmAddStock")
            {
                FrmAddStock frmAddStock1 = new FrmAddStock();
                this.Hide();
                frmAddStock1.ShowDialog();
                this.Close();
            }
            else
            {
                FrmAddStock frmAddStock = new FrmAddStock();
                this.Hide();
                frmAddStock.ShowDialog();
                this.Close();
            }
        }

        public void SetName()
        { //uses the entered level names to generate an stock item name
            name = level0Selection + " - " + level1Selection + " - " + level2Selection + " - " + level3Selection;
            labelName.Text = name;
        }

        public void SaveStock()
        {//checks to make sure the item your trying to add does not already exist and saves if it doesnt
            SetName();
            bool alreadyExists = ChkDuplicateStockItem(name);
            if (!alreadyExists)
            {
                AddStock(name, price, quant, level0Selection, level1Selection, level2Selection, level3Selection, image);
                MessageBox.Show("Stock Entry Saved", "Save Confirmation");
            }
            else MessageBox.Show("This stock item already exists, save aborted", "save aborted");
        }

        private void AddStock(string name, decimal price, int quant, string catLevel0, string catLevel1, string catLevel2, string catLevel3, Image image)
        {//add a new stock item with details sent to it
            Stock newStock = new Stock();
            newStock.Name = name;
            newStock.Price = price;
            newStock.Quantity = quant;
            newStock.Catagory0 = catLevel0;
            newStock.Catagory1 = catLevel1;
            newStock.Catagory2 = catLevel2;
            newStock.Catagory3 = catLevel3;
            newStock.Image = image;
            Program.ProcessStorage.ListStock.Add(newStock);
            Program.ProcessStorage.SaveStockDataFile();
        }

        private bool ChkDuplicateStockItem(string stockName)
        { //loops through the stock list checking for duplicates of the one being created,
            bool stockFound = false;
            foreach (Stock stock in Program.ProcessStorage.ListStock)
            {
                if (stock.Name == stockName)
                {
                    stockFound = true;
                    break;
                }
            }
            return stockFound;
        }

        private void EnableLevel0AndDisableOthers()
        {//called at the start, makes sure we only see what is wanted
            listBoxLevel0.Enabled = true;
            listBoxLevel0.Visible = true;
            listBoxLevel1.Enabled = false;
            listBoxLevel1.Visible = false;
            listBoxLevel2.Enabled = false;
            listBoxLevel2.Visible = false;
            listBoxLevel3.Enabled = false;
            listBoxLevel3.Visible = false;
            saveBtnEnabled = false;
        }

        private void DisableLevel0AndEnableLevel1()
        { // enables and dhows levl 1 box
            listBoxLevel0.Enabled = false;
            listBoxLevel1.Enabled = true;
            listBoxLevel1.Visible = true;
        }

        private void DisableLevel1AndEnableLevel2()
        {// enables and showws level 2 box
            listBoxLevel1.Enabled = false;
            listBoxLevel2.Enabled = true;
            listBoxLevel2.Visible = true;
        }

        private void DisableLevel2AndEnableLevel3()
        { //enables and shows level 3 box
            listBoxLevel2.Enabled = false;
            listBoxLevel3.Enabled = true;
            listBoxLevel3.Visible = true;
        }

        private void DisableLevel3AndEnableSave()
        {
            //prevents further editing and enables saving
            listBoxLevel3.Enabled = false;
            saveBtnEnabled = true;
        }

        public override void BtnOk_Click(object sender, EventArgs e)
        {
            if (saveBtnEnabled)
            { //if save is enabled, validates then saves data
                hasMoreThan2Decimals = false;
                ValidateEntries();
            }
            else MessageBox.Show("Sorry but you need to finish entering all information before you can save an item.", "Unfinished");
        }

        public override void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetDisplay();
        }

        public override void BtnStaffMenu_Click(object sender, EventArgs e)
        {
            ReturnToStaffMenu();
        }

        private void listBoxLevel0_Click(object sender, EventArgs e)
        { //do this when listbox level 0 is clicked
            int selectedIndex = listBoxLevel0.SelectedIndex;
            level0Selection = listLevel0[selectedIndex];
            SetName();
            InitLevel1();
        }

        private void listBoxLevel1_Click(object sender, EventArgs e)
        {// do this when listbox level 1 is clicked
            int selectedIndex = listBoxLevel1.SelectedIndex;
            level1Selection = listLevel1Choices[selectedIndex];
            SetName();
            InitLevel2();
        }

        private void listBoxLevel2_Click(object sender, EventArgs e)
        { //do this when listbox level 2 is clicked
            int selectedIndex = listBoxLevel2.SelectedIndex;
            level2Selection = listLevel2Choices[selectedIndex];
            SetName();
            InitLevel3();
        }

        private void listBoxLevel3_Click(object sender, EventArgs e)
        {// do this when listbox level 3 is clicked
            int selectedIndex = listBoxLevel3.SelectedIndex;
            level3Selection = listLevel3Choices[selectedIndex];
            SetName();
            DisableLevel3AndEnableSave();
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        { // do this when the picturebox is clicked
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { //opens a file dialogue to select and image
                pictureBoxImage.Load(openFileDialog1.FileName);
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                image = pictureBoxImage.Image;
            }
        }
    }
}
