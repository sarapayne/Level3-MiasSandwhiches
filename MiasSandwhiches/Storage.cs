using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MiasSandwhiches
{
    [Serializable()]
    public struct ReservedStock
    { //makes a struct used for saving stock which has been selected. Will be used to restore stock levels if an order is abandone or a system crash happens.
        //deliberately a data rather than reference type, as the quantity needs to be independant to allow for future growth of the system.
        public string Name { get; set; }
        public int Quantity { get; set; }
    }


    [Serializable()]
    class Storage
    {
        public List<Stock> ListStock { get; set; } //list of all stock items in the system
        public List<Order> ListOrders { get; set; } //list of all orders in the system
        public List<ReservedStock> ListReservedStock { get; set; } // items added here incase of crashes or time outs.
        public List<StockCategory> ListStockCatagories { get; set; } //list of stock catagories in the system
        private string dataFileNameStock = "stock.bin";
        private string dataFileNameOrders = "orders.bin";
        private string dataFileNameStockCatagories = "stockcatagories.bin";  //data files names used below to load and save the .bin files.
        private string dataFileNameReservedStock = "reserved.bin";

        public Storage()
        {
            /*
             * Stock, Orders, Stock Catagories and reserved stock are loaded from .bin files and saved to their respective lists
             */
            ListStock = new List<Stock>();
            ListOrders = new List<Order>();
            ListStockCatagories = new List<StockCategory>();
            ListReservedStock = new List<ReservedStock>();
            LoadStockDataFile();
            LoadOrderDataFile();
            LoadStockCatagoriesDataFile();
            LoadReservedStockDataFile();
            RestoreReservedItems(); // stock levels restored from the reserved items if they are found (system crash).
            ResetNoItemChoiceStock(); // resets the not item choice levels so they don't ever run out. 
        }

        private void ResetNoItemChoiceStock()
        { //check to see if the no stock items exist, replaces them if they do not then sets the quanitity to 1000000
            string[] searchCriteria = new string[] { "**No Spread**", "**No Sauce**", "**No Filling**", "**No Salad**" };
            foreach (string nameCat1 in searchCriteria)
            {
                bool itemExists = false;
                for (int x = 0; x < ListStock.Count; x++)
                {
                    if (nameCat1 == ListStock[x].Catagory1)
                    {
                        itemExists = true;
                        ListStock[x].Quantity = 1000000;
                        break;
                    }
                }
                if (!itemExists)
                {
                    string cat0 = "";
                    if (nameCat1 == "**No Bread**") cat0 = "Bread";
                    else if (nameCat1 == "**No Spread**") cat0 = "Spread";
                    else if (nameCat1 == "**No Sauce**") cat0 = "Sauce";
                    else if (nameCat1 == "**No Filling**") cat0 = "Filling";
                    else if (nameCat1 == "**No Salad**") cat0 = "Salad";
                    CreateNoItemStock(cat0, nameCat1);
                }
                //MessageBox.Show("No Items Values Reset or created if they don't exist already"); //removed as it was just annoying to the user.
            }
        }

        private void CreateNoItemStock(string cat0Name, string cat1Name)
        { //checks to see if the catagory for the no item stock search exists, if it does it makes the stock, if not it makes the category then the stock via a loop of methods. 
            bool categoryExists = ChkCategoryExists(cat0Name, cat1Name);
            if (categoryExists)
            {
                Stock newStock = new Stock();
                newStock.Catagory0 = cat0Name;
                newStock.Catagory1 = cat1Name;
                newStock.Catagory2 = "Unused";
                newStock.Catagory3 = "Unused";
                string newName = cat0Name + " - " + cat1Name + " - " + "Unused" + " - " + "Unused";
                newStock.Name = newName;
                newStock.Price = 0;
                newStock.Quantity = 1000000;
                ListStock.Add(newStock);
                SaveStockDataFile();
                ResetNoItemChoiceStock();
            }
            else
            {
                StockCategory newStockCategory = new StockCategory();
                newStockCategory.Catagory0 = cat0Name;
                newStockCategory.Catagory1 = cat1Name;
                newStockCategory.Catagory2 = "Unused";
                newStockCategory.Catagory3 = "Unused";
                string newName = cat0Name + " - " + cat1Name + " - " + "Unused" + " - " + "Unused";
                newStockCategory.Name = newName;
                ListStockCatagories.Add(newStockCategory);
                SaveStockCatagoriesDataFile();
                ResetNoItemChoiceStock();
            }
        }

        private bool ChkCategoryExists (string cat0, string cat1)
        { //returns a bool based on finding or not finding a specific stock category, called from no items methods
            bool found = false;
            foreach (StockCategory stockCategory in ListStockCatagories)
            {
                if (stockCategory.Catagory0 == cat0 && stockCategory.Catagory1 == cat1)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public void ClearReservedStock()
        {   //clears the reserved items stock list and sets the default again. 
            ListReservedStock.Clear();
            ReservedStock reservedPlaceHold = new ReservedStock();
            reservedPlaceHold.Name = "reserved";
            reservedPlaceHold.Quantity = 1;
            ListReservedStock.Add(reservedPlaceHold);
            SaveReservedStock();
        }

        public void RestoreReservedItems()
        {   //looops through the reserved items list, finds the appropriate stock item and restored the stock value.
            if (ListReservedStock.Count == 0) MessageBox.Show("Reserved Item list empty. Unless you have no completed orders contact surrport.", "reserved stock Warning");
            else if (ListReservedStock.Count == 1 && ListReservedStock[0].Name != "reserved") MessageBox.Show("Place hold reserved item is not called reserved. This should not happen, contact support.", "reserved item error.");
            else
            {
                for (int i = 1; i < ListReservedStock.Count; i++) //we start at 1 rather than 0 to avoid the reserved stock item.
                {
                    string nameToCheck = ListReservedStock[i].Name;
                    for (int j = 0; j < ListStock.Count; j++)
                    {
                        if (ListStock[j].Name == nameToCheck)
                        {
                            int CurrentStockQuantity = ListStock[j].Quantity;
                            int newStockQuantity = CurrentStockQuantity + 1;
                            ListStock[j].Quantity = newStockQuantity;
                        }
                    }
                }
                SaveStockDataFile();
                ClearReservedStock();
            }
        }

        public void LoadStockDataFile()
        {//loads the stock data file to the stock list
            try
            {
                using (Stream stream = File.Open(dataFileNameStock, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    ListStock = (List<Stock>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error loading the stock data. If you previously saved stock data contact support.", "Load Data Error");
            }
        }

        public void LoadOrderDataFile()
        { //loads the order data file to the orders list
            try
            {
                using (Stream stream = File.Open(dataFileNameOrders, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    ListOrders = (List<Order>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error loading the orders data. If you previously saved orders contact support.", "Load Data Error");
            }
        }

        public void LoadStockCatagoriesDataFile()
        {//loads the catagories data file to the categories list
            try
            {
                using (Stream stream = File.Open(dataFileNameStockCatagories, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    ListStockCatagories = (List<StockCategory>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error loading the stock catagories data.", "Load Data Error");
            }
        }

        public void LoadReservedStockDataFile()
        {//loads the reserved stock data file to the reserved stock list
            try
            {
                using (Stream stream = File.Open(dataFileNameReservedStock, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    ListReservedStock = (List<ReservedStock>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error loading the reserved stock data. If this is not  fresh installation contact support.", "Load Data Error");
            }
        }

        public void SaveOrderDataFile()
        {
            if (ListOrders.Count != 0)
            {//saves the orders list to the hdd
                try
                {
                    using (System.IO.Stream stream = File.Open(dataFileNameOrders, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, ListOrders);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an error saving the orders data file.", "Save Orders Error");
                }
            }
            else MessageBox.Show("You tried to save and empty orders file, save aborted", "nothing to save");
        }

        public void SaveStockDataFile()
        {//saves the stock list to the hdd
            if (ListStock.Count != 0)
            {
                try
                {
                    using (System.IO.Stream stream = File.Open(dataFileNameStock, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, ListStock);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an error saving the stock data file.", "Save Orders Error");
                }
            }
            else MessageBox.Show("You tried to save and empty stock file, save aborted", "nothing to save");
        }

        private List<string> SortListOfStrings(List<string> listToSort)
        { //converts a list to an array. passes sort then converts it back. Saves a bubble sort. 
            string[] arrayToSort = listToSort.ToArray();
            Array.Sort(arrayToSort);
            List<string> sortedList = new List<string>();
            sortedList = arrayToSort.ToList();
            return sortedList;
        }

        public void SortStockFile()
        { //sorts the stock file based on the .Name attribute of each stock item
            Stock temp;
            for (int j = 0; j < ListStock.Count - 1; j++)
            {
                for (int i = 0; i < ListStock.Count - 1; i++)
                {
                    if (String.CompareOrdinal(ListStock[i].Name, ListStock[i + 1].Name) >= 0)
                    {
                        temp = ListStock[i];
                        ListStock[i] = ListStock[i + 1];
                        ListStock[i + 1] = temp;
                    }
                }
            }
            SaveStockDataFile();
        }

        public void SortStockCatagoriesFile()
        { ////sorts the stockcategories file based on the .Name attribute of each stock item
            StockCategory tempCatagory;
            for (int j = 0; j < ListStockCatagories.Count - 1; j++)
            {
                for (int i = 0; i < ListStockCatagories.Count - 1; i++)
                {
                    if (String.CompareOrdinal(ListStockCatagories[i].Name, ListStockCatagories[i + 1].Name) >= 0)
                    {
                        tempCatagory = ListStockCatagories[i];
                        ListStockCatagories[i] = ListStockCatagories[i + 1];
                        ListStockCatagories[i + 1] = tempCatagory;
                    }
                }
            }
            SaveStockCatagoriesDataFile();
        }

        public void SaveStockCatagoriesDataFile()
        {
            if (ListStockCatagories.Count != 0)
            {//saves the stock catagories list to the hdd
                try
                {
                    using (System.IO.Stream stream = File.Open(dataFileNameStockCatagories, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, ListStockCatagories);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an error saving the stock catagory data file.", "Save Orders Error");
                }
            }
            else MessageBox.Show("You tried to save and empty stock catagory file, save aborted", "nothing to save");
        }

        private void SaveReservedStock()
        {// saves the reserved stock list to the hdd
            if (ListReservedStock.Count != 0)
            {
                try
                {
                    using (System.IO.Stream stream = File.Open(dataFileNameReservedStock, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, ListReservedStock);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an error saving the reserved stock data file.", "Save Orders Error");
                }
            }
            else MessageBox.Show("You tried to save and empty reserved stock file, save aborted", "nothing to save");
        }

    }
}
