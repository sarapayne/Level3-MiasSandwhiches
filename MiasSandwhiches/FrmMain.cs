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
    public partial class FrmMain : FrmBase
    {
        //main menu with two simple buttons on.

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {  //starts an order
            FrmChooseBread frmChooseBread = new FrmChooseBread();
            this.Hide();
            frmChooseBread.ShowDialog();
            this.Close();
        }

        private void BtnStoreLogin_Click(object sender, EventArgs e)
        { //starts login form for staff
            FrmStoreLogin frmStoreLogin = new FrmStoreLogin();
            this.Hide();
            frmStoreLogin.ShowDialog();
            this.Close();
        }
    }
}
