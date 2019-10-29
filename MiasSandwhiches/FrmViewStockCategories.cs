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
    public partial class FrmViewStockCategories : FrmBase
    {
        BindingList<string> displayList = new BindingList<string>();

        public FrmViewStockCategories()
        {
            InitializeComponent();
        }

        private void FrmViewStockCategories_Load(object sender, EventArgs e)
        {
            GenDisplayList();//generate list of names
            Program.ProcessStorage.SortStockCatagoriesFile(); //dispay generatd list in liist box
        }

        private void GenDisplayList()
        {
            displayList.Clear();
            foreach (StockCategory stockCategory in Program.ProcessStorage.ListStockCatagories)
            {//loops through the stock categories list and adds the names to a new list
                displayList.Add(stockCategory.Name);
            }
            listBoxCatagories.DataSource = displayList;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {// deletes the selected item if the user confirms yes
            if (MessageBox.Show("Are you sure you wish to delte the selected item?", "confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.ProcessStorage.ListStockCatagories.RemoveAt(listBoxCatagories.SelectedIndex);
                Program.ProcessStorage.SaveStockCatagoriesDataFile();
                displayList.RemoveAt(listBoxCatagories.SelectedIndex);
                GenDisplayList();
            }
        }

        private void BtnStaffMenu_Click(object sender, EventArgs e)
        {
            ReturnToStaffMenu();
        }
    }
}

