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
    public partial class FrmStoreLogin : FrmBase
    {
        private string strPassword = "Password"; //this should be on a encrytped file in a full system
        private string strUserName = "UserName"; //this should be on an encrypted file in a full system.

        public FrmStoreLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*'; //replaces normal characters with * so paswords are more secure
        }

        private void FrmStoreLogin_Load(object sender, EventArgs e)
        {

        }

        private void GoToStaffMenu()
        { //opens the staff menu form closing this one. 
            FrmStaffMenu frmStaffMenu = new FrmStaffMenu();
            this.Hide();
            frmStaffMenu.ShowDialog();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" && textBoxPassword.Text != "")
            { //ensures we have user entry into both box's
                if (textBoxUserName.Text == strUserName && textBoxPassword.Text == strPassword)
                {//checks both user name and password match
                    GoToStaffMenu();
                }
                else MessageBox.Show("You have entered an incorrect user name or password", "Login Credentials Invalid"); // tells the user they nmade a mistake
            }
            else
            { //advises user whats missing
                if (textBoxUserName.Text == "") MessageBox.Show("You must enter a user name to continue", "Missing User Name");
                if (textBoxPassword.Text == "") MessageBox.Show("You must enter your password to continue", "Missing Password");
            }
        }
    }
}
