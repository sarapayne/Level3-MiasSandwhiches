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
    public partial class FrmAddProductCategories : FrmBase
    {
        //binding lists used to make sure listbox's update with changes to the list
        private List<string> listLevel0;
        private List<StockCategory> existingStockCatagories;
        private string level0Selection;
        private BindingList<string> listLevel1Choices;
        private string level1Selection;
        private BindingList<string> listLevel2Choices;
        private string level2Selection;
        private BindingList<string> listLevel3Choices;
        private string level3Selection;
        private int newIndex;

        public FrmAddProductCategories()
        {
            InitializeComponent();
        }

        private void FrmAddProductCategories_Load(object sender, EventArgs e)
        {
            GetExistingCatagories();
            InitLevel0();
        }

        private void GetExistingCatagories()
        { //fetches existing list and checks its ok
            existingStockCatagories = new List<StockCategory>();
            existingStockCatagories = Program.ProcessStorage.ListStockCatagories;
            if (existingStockCatagories.Count == 0) EmergencyRecorvery();
        }

        private void InitLevel0()
        { //sets level 0 display
            listLevel0 = new List<string>() { "Bread", "Filling", "Salad", "Sauce", "Spread" };
            textBoxEntry.Text = "";
            EnableLevel0AndDisableOthers();
            listBoxLevel0.DataSource = listLevel0;
        }

        private void InitLevel1()
        {  //sets level 1 display
            DisableLevel0AndEnableLevel1();
            textBoxEntry.Text = "";
            listLevel1Choices = new BindingList<string>();
            GenLevel1Choices();
            listBoxLevel1.DataSource = listLevel1Choices;
        }

        private void InitLevel2()
        {//sets level 2 display
            DisableLevel1AndEnableLevel2();
            textBoxEntry.Text = "";
            listLevel2Choices = new BindingList<string>();
            GenLevel2Choices();
            listBoxLevel2.DataSource = listLevel2Choices;
        }

        private void InitLevel3()
        {//sets level 3 display
            DisableLevel2AndEnableLevel3();
            textBoxEntry.Text = "";
            listLevel3Choices = new BindingList<string>();
            GenLevel3Choices();
            listBoxLevel3.DataSource = listLevel3Choices;
        }

        private void GenLevel1Choices()
        {// generates existing choices for level 1
            listLevel1Choices = new BindingList<string>();
            listLevel1Choices.Clear();
            foreach (StockCategory item in existingStockCatagories)
            {
                if (item.Catagory0 == level0Selection)
                {
                    if (listLevel1Choices.Contains(item.Catagory1))
                    {
                        //why does this function not allow !.Contains.. grrr
                    }
                    else listLevel1Choices.Add(item.Catagory1);
                }
            }
            listBoxLevel1.DataSource = listLevel1Choices;
        }

        private void GenLevel2Choices()
        { //generates existing choices for level 2 based on level0 and 1 choice
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
        {// generates existing choces for level 3 based on 0,1 and 2
            listLevel3Choices = new BindingList<string>();
            listLevel3Choices.Clear();
            foreach (StockCategory item in existingStockCatagories)
            {
                if (item.Catagory0 == level0Selection && item.Catagory1 == level1Selection && item.Catagory2 == level2Selection)
                {
                    if (listLevel3Choices.Contains(item.Catagory3))
                    {
                        // why does this function not allow !.Contains.. grrr
                    }
                    else listLevel3Choices.Add(item.Catagory3);
                }
            }
            listBoxLevel3.DataSource = listLevel3Choices;
        }

        private void EnableLevel0AndDisableOthers()
        { //sets visibility and enabled settings for controls when choosing level 0
            listBoxLevel0.Enabled = true;
            listBoxLevel0.Visible = true;
            listBoxLevel1.Enabled = false;
            listBoxLevel1.Visible = false;
            listBoxLevel2.Enabled = false;
            listBoxLevel2.Visible = false;
            listBoxLevel3.Enabled = false;
            listBoxLevel3.Visible = false;
            BtnAddLevel1.Enabled = false;
            BtnAddLevel1.Visible = false;
            BtnAddLevel2.Enabled = false;
            BtnAddLevel2.Visible = false;
            BtnAddLevel3.Enabled = false;
            BtnAddLevel3.Visible = false;
            BtnSave.Enabled = false;
            BtnSave.Visible = false;
            BtnLevel2Unused.Enabled = false;
            BtnLevel2Unused.Visible = false;
            BtnLevel3Unused.Enabled = false;
            BtnLevel3Unused.Visible = false;
        }

        private void DisableLevel0AndEnableLevel1()
        {//sets visibility and enabled settings for controls when choosing level 1
            listBoxLevel0.Enabled = false;
            listBoxLevel1.Enabled = true;
            listBoxLevel1.Visible = true;
            BtnAddLevel1.Enabled = true;
            BtnAddLevel1.Visible = true;
        }

        private void DisableLevel1AndEnableLevel2()
        {//sets visibility and enabled settings for controls when choosing level 2
            listBoxLevel1.Enabled = false;
            BtnAddLevel1.Enabled = false;
            BtnAddLevel1.Visible = false;
            listBoxLevel2.Enabled = true;
            listBoxLevel2.Visible = true;
            BtnAddLevel2.Enabled = true;
            BtnAddLevel2.Visible = true;
            BtnLevel2Unused.Enabled = true;
            BtnLevel2Unused.Visible = true;
        }

        private void DisableLevel2AndEnableLevel3()
        {//sets visibility and enabled settings for controls when choosing level 3
            listBoxLevel2.Enabled = false;
            BtnAddLevel2.Enabled = false;
            BtnAddLevel2.Visible = false;
            listBoxLevel3.Enabled = true;
            listBoxLevel3.Visible = true;
            BtnAddLevel3.Enabled = true;
            BtnAddLevel3.Visible = true;
            BtnLevel2Unused.Enabled = false;
            BtnLevel2Unused.Visible = false;
            BtnLevel3Unused.Enabled = true;
            BtnLevel3Unused.Visible = true;
        }

        private void DisableLevel3AndEnableSave()
        {// disable level 3 box and enable save, 
            BtnAddLevel3.Enabled = false;
            BtnAddLevel3.Visible = false;
            BtnLevel3Unused.Enabled = false;
            BtnLevel3Unused.Visible = false;
            listBoxLevel3.Enabled = false;
            BtnSave.Enabled = true;
            BtnSave.Visible = true;
        }

        private void EmergencyRecorvery()
        { //if the stock categories doesn't exist or is corrupt make an emergency set of objects to avoid crashes.
            InitLevel0();
            MessageBox.Show("No Stock Catagories Found, reverting to defaults. " +
                "If this is not the first time running this application contact support now!", "Stock Catagories Error");
            for (int i = 0; i < listLevel0.Count; i++)
            {
                string name = listLevel0[i] + "Unused" + "Unused" + "Unused";
                AddStockCatagory(name, listLevel0[i], "Unsed", "Unused", "Unused");
            }
            MessageBox.Show("This page will now reset", "PageReset");
        }

        private void PageReset()
        { // reloads this form allowing for duplicate object names
            if (this.Name == "frmProductCatagories")
            {
                FrmAddProductCategories frmAddProductCategories1 = new FrmAddProductCategories();
                this.Hide();
                frmAddProductCategories1.ShowDialog();
                this.Close();
            }
            else
            {
                FrmAddProductCategories frmAddProductCategories = new FrmAddProductCategories();
                this.Hide();
                frmAddProductCategories.ShowDialog();
                this.Close();
            }
        }

        private bool ChkDuplicateStockCatagoryItem(string catName)
        { //checks to make sure the stock category being made does not already exist
            bool catFound = false;
            foreach (StockCategory catagory in Program.ProcessStorage.ListStockCatagories)
            {
                if (catagory.Name == catName)
                {
                    catFound = true;
                    break;
                }
            }
            return catFound;
        }

        private void AddStockCatagory(string name, string level0, string level1, string level2, string level3)
        { //adds the new stock to the stock list and saves to hdd
            StockCategory stockCatagory = new StockCategory();
            stockCatagory.Name = name;
            stockCatagory.Catagory0 = level0;
            stockCatagory.Catagory1 = level1;
            stockCatagory.Catagory2 = level2;
            stockCatagory.Catagory3 = level3;
            Program.ProcessStorage.ListStockCatagories.Add(stockCatagory); //saves to main stock list
            Program.ProcessStorage.SaveStockCatagoriesDataFile(); //saves the datafile to hdd
        }

        private void listBoxLevel0_Click(object sender, EventArgs e)
        {// when listbox is clicked call intilevel1
            int selectedIndex = listBoxLevel0.SelectedIndex;
            level0Selection = listLevel0[selectedIndex];
            InitLevel1();
        }

        private void listBoxLevel1_Click(object sender, EventArgs e)
        {// when listbox is clicked call intilevel2
            int selectedIndex = listBoxLevel1.SelectedIndex;
            level1Selection = listLevel1Choices[selectedIndex];
            InitLevel2();
        }

        private void listBoxLevel2_Click(object sender, EventArgs e)
        {// when listbox is clicked call intilevel3
            int selectedIndex = listBoxLevel2.SelectedIndex;
            level2Selection = listLevel2Choices[selectedIndex];
            InitLevel3();
        }

        private void listBoxLevel3_Click(object sender, EventArgs e)
        { //level 3 list box click, enables save
            int selectedIndex = listBoxLevel3.SelectedIndex;
            level3Selection = listLevel3Choices[selectedIndex];
            DisableLevel3AndEnableSave();
        }

        private void BtnAddLevel1_Click(object sender, EventArgs e)
        {//come here when add level 1 button clicked
            if (textBoxEntry.Text != "" && textBoxEntry != null)
            {//do this if both text box is not a null value or just blank
                level1Selection = textBoxEntry.Text;
                listLevel1Choices.Add(level1Selection);
                for (int i = 0; i < listLevel1Choices.Count; i++)
                {
                    if (listLevel1Choices[i] == level1Selection) newIndex = i;
                }
                listBoxLevel1.SelectedIndex = newIndex;
                InitLevel2();
            }
            else MessageBox.Show("You must enter the name in the entry box first", "no name entered");
        }

        private void BtnAddLevel2_Click(object sender, EventArgs e)
        {//come here when add level 2 button clicked
            if (textBoxEntry.Text != "" && textBoxEntry != null)
            {//do this if both text box is not a null value or just blank
                level2Selection = textBoxEntry.Text;
                listLevel2Choices.Add(level2Selection);
                for (int i = 0; i < listLevel2Choices.Count; i++)
                {
                    if (listLevel2Choices[i] == level2Selection) newIndex = i; //adds selection
                }
                listBoxLevel2.SelectedIndex = newIndex;
                InitLevel3();
            }
        }

        private void BtnAddLevel3_Click(object sender, EventArgs e)
        {//come here when add level 3 button clicked
            if (textBoxEntry.Text != "" && textBoxEntry != null)
            {//do this if both text box is not a null value or just blank
                level3Selection = textBoxEntry.Text;
                listLevel3Choices.Add(level3Selection); 
                for (int i = 0; i < listLevel3Choices.Count; i++)
                {
                    if (listLevel3Choices[i] == level3Selection) newIndex = i; //adds selection
                }
                listBoxLevel3.SelectedIndex = newIndex;
            }
            DisableLevel3AndEnableSave();
        }


        private void BtnLevel2Unused_Click(object sender, EventArgs e)
        {//adds unused value to level 2 
            level2Selection = "Unused";
            listLevel2Choices.Add(level2Selection);
            InitLevel3();
        }

        private void BtnLevel3Unused_Click(object sender, EventArgs e)
        {//adds unused value to level 3
            level3Selection = "Unused";
            listLevel3Choices.Add(level3Selection);
            DisableLevel3AndEnableSave();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = level0Selection + " - " + level1Selection + " - " + level2Selection + " - " + level3Selection; //generates the new name string
            bool alreadyExists = ChkDuplicateStockCatagoryItem(name);
            if (!alreadyExists)
            {//if not a duplicate 
                AddStockCatagory(name, level0Selection, level1Selection, level2Selection, level3Selection); //sends info to the save function
                MessageBox.Show("StockCatagory Entry Saved", "Save Confirmation");
                PageReset();
            }
            else MessageBox.Show("You are trying to add an item which already exists, save aborted.", "Save Aborted");//reports duplicate to user. 
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PageReset();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ReturnToStaffMenu();
        }
    }
}
