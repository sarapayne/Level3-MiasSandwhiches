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
    /*
     * Almost everything here is inherited from FrmBaseSandwhichChoices
     * This script just passes the active main category to the FrmBaseSandwichChoices and calls Init on the same Form.
     * Finally if its allowed the continue button closes this form and opens Choose Spread.
    */

    public partial class FrmChooseBread : FrmBaseSandwichChoices
    {
        public FrmChooseBread()
        {
            InitializeComponent();
        }

        private void FrmChooseBread_Load(object sender, EventArgs e)
        {
            ActiveMainCatagory = "Bread"; //sets this on the inherited value
            Init(); //calls inti on inherited method
        }

        public override void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            base.BtnCancelOrder_Click(sender, e);
        }

        public override void BtnContinue_Click(object sender, EventArgs e)
        {
            if (!allowContinue) MessageBox.Show("Please finish selecting your bread before coninuing.", "unfinished busisness");
            else
            { //if continue is allowed close this form and open choose spread
                FrmChooseSpread frmChooseSpread = new FrmChooseSpread();
                this.Hide();
                frmChooseSpread.ShowDialog();
                this.Close();
            }
        }
    }
}
