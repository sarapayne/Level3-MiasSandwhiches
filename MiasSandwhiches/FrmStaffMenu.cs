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
    public partial class FrmStaffMenu : FrmBase
    {
        //Simple 4 button navigation with a return to the main menu option (logout)
    
        public FrmStaffMenu()
        {
            InitializeComponent();
        }

        private void FrmStaffMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddProductCatagories_Click(object sender, EventArgs e)
        { //loads add product catagories and closes this
            FrmAddProductCategories frmAddProductCategories = new FrmAddProductCategories();
            this.Hide();
            frmAddProductCategories.ShowDialog();
            this.Close();
        }

        private void BtnViewDelProductCatagories_Click(object sender, EventArgs e)
        {//loads view/del product catagories and closes this
            FrmViewStockCategories frmViewStockCategories = new FrmViewStockCategories();
            this.Hide();
            frmViewStockCategories.ShowDialog();
            this.Close();
        }

        private void BtnEditStock_Click(object sender, EventArgs e)
        {//loads edit stock and closes this
            FrmEditStock frmEditStock = new FrmEditStock();
            this.Hide();
            frmEditStock.ShowDialog();
            this.Close();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {//loads add stock and closes this.
            FrmAddStock frmAddStock = new FrmAddStock();
            this.Hide();
            frmAddStock.ShowDialog();
            this.Close();

        }
    }
}
