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
    public partial class FrmChooseSauce : FrmBaseSandwichChoices
    {
        /*
     * Almost everything here is inherited from FrmBaseSandwhichChoices
     * This script just passes the active main category to the FrmBaseSandwichChoices and calls Init on the same Form.
     * Finally if its allowed the continue button closes this form and opens Choose Filling.
    */

        public FrmChooseSauce()
        {
            InitializeComponent();
        }

        private void FrmChooseSauce_Load(object sender, EventArgs e)
        {
            base.ActiveMainCatagory = "Sauce";//sets this on the inherited value
            base.Init();//calls inti on inherited method
        }

        public override void BtnContinue_Click(object sender, EventArgs e)
        {
            if (!allowContinue) MessageBox.Show("Please finish selecting your bread before coninuing.", "unfinished busisness");
            else
            {//if continue is allowed close this form and open choose filling
                FrmChooseFilling frmChooseFilling = new FrmChooseFilling();
                this.Hide();
                frmChooseFilling.ShowDialog();
                this.Close();
            }
        }

        public override void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            base.BtnCancelOrder_Click(sender, e);
        }
    }
}
