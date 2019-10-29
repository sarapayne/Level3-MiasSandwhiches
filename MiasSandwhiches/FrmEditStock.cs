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
    public partial class FrmEditStock : FrmBaseStock
    {
        private BindingList<string> listStockName = new BindingList<string>();
        private string name;
        private string cat0;
        private string cat1;
        private string cat2;
        private string cat3;
        private decimal price;
        private int quant;
        Image image;
        private int stockID;
        private bool enteredPriceLessThanZero;
        private bool enteredQuantityLessThanZero;
        private bool hasMoreThan2Decimals;

        public FrmEditStock()
        {
            InitializeComponent();
        }

        private void FrmEditStock_Load(object sender, EventArgs e)
        {
            Program.ProcessStorage.SortStockFile();
            GenDisplayList();
        }

        private void GenDisplayList()
        {
            listBoxStockNames.ClearSelected();
            foreach (Stock stock in Program.ProcessStorage.ListStock)
            {//adds the name of each object in the stock list to another list matching the index order
                listStockName.Add(stock.Name);
            }
            listBoxStockNames.DataSource = listStockName;
        }

        private void FetchStockItem()
        {//fetches all info from select stock and stores in variables. 
            Stock stockItem = new Stock();
            stockItem = Program.ProcessStorage.ListStock[stockID];
            name = stockItem.Name;
            cat0 = stockItem.Catagory0;
            cat1 = stockItem.Catagory1;
            cat2 = stockItem.Catagory2;
            cat3 = stockItem.Catagory3;
            price = stockItem.Price;
            quant = stockItem.Quantity;
            image = stockItem.Image;
            labelName.Text = name;
            textBoxPrice.Text = Convert.ToString(price); //converted to string to display on text box. 
            textBoxQuantity.Text = Convert.ToString(quant);
            pictureBoxImage.Image = image;
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ValidateEntries()
        {//validates all entries on the form then saves if ok
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
            {
                price = numberDec;
                quant = numberInt;
                image = pictureBoxImage.Image;
                AmendStock();
            }
            else
            {
                if (!isDec) MessageBox.Show("The price you entered is not a decimal number", "Price Invalid");
                else if (!isInt) MessageBox.Show("The quantity you entered is not a valid whole number", "Quantity Invalid");
                else if (enteredPriceLessThanZero) MessageBox.Show("The price you entered is less than 0. Please amend", "Price Error");
                else if (enteredQuantityLessThanZero) MessageBox.Show("The quantity you entered is less than 0. Please amend", "Quantity Error");
                else if (pictureBoxImage.Image == null) MessageBox.Show("Please select a product image then try again.", "Picture Missing");
                else if (hasMoreThan2Decimals) MessageBox.Show("The price you entered has more than 2 decimal places, please adjust and try again", "price eror");
            }
        }

        private void AmendStock()
        {//makes new stock item with current values then makes the main stock file match it. 
            Stock stockToSend = new Stock();
            stockToSend.Name = name;
            stockToSend.Catagory0 = cat0;
            stockToSend.Catagory1 = cat1;
            stockToSend.Catagory2 = cat2;
            stockToSend.Catagory3 = cat3;
            stockToSend.Price = price;
            stockToSend.Quantity = quant;
            stockToSend.Image = image;
            Program.ProcessStorage.ListStock[stockID] = stockToSend;
            Program.ProcessStorage.SaveStockDataFile();
            Program.ProcessStorage.SortStockFile();
            MessageBox.Show("Your Changes have been saved", "Save Confirmation");
        }

        public override void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delte this item, this action could effect the running of the application and can not be undone!", 
                "Item Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {//deletes the selected item from both the displayed list and stock list if the user confirms yes.
                Program.ProcessStorage.ListStock.RemoveAt((listBoxStockNames.SelectedIndex));
                Program.ProcessStorage.SaveStockDataFile();
                listStockName.RemoveAt(listBoxStockNames.SelectedIndex);
                Program.ProcessStorage.SortStockFile();
                GenDisplayList();
            }
        }

        private void listBoxStockNames_Click(object sender, EventArgs e)
        {//selects the required stock and displays it. 
            stockID = listBoxStockNames.SelectedIndex;
            FetchStockItem();
        }

        public override void BtnOk_Click(object sender, EventArgs e)
        {
            //button validates entries then saves
            ValidateEntries();
        }

        public override void BtnStaffMenu_Click(object sender, EventArgs e)
        { //button back to staff menu
            ReturnToStaffMenu();
        }

        private void pictureBoxImage_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show the Open File dialog. If the user clicks OK, load the
                // picture that the user chose.
                pictureBoxImage.Load(openFileDialog1.FileName);
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
