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
    public partial class FrmBase : Form
    {
        /*
         *Base level Form. This sets up the GUI resize and a few other methods inherited by every other form in the system. 
        */

        //variables used for GUI resize
        static Size sizeFormOriginal;
        static List<Rectangle> listOriginalRects = new List<Rectangle>();
        static List<Font> listOriginalFonts = new List<Font>();
        static float scaleRatioX;
        static float scaleRatioY;
        static float scaleRatioFont;

        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            sizeFormOriginal = this.Size; //gets the original size of the form
            storeRectsAndFonts(); //calls method to store rects and fonts from all form controls
        }

        private void storeRectsAndFonts()
        {//loops through all the controls on the form and stores a rect and font for each
            foreach (Control control in this.Controls)
            {
                Rectangle rectToAdd = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
                Font fontToAdd = control.Font;
                listOriginalFonts.Add(fontToAdd);
                listOriginalRects.Add(rectToAdd);
            }
        }

        private void CalcResizeRatios()
        {//uses the resized form to calculate a ratio in x and y for scaling the controls. Then applies the biggest out of the two to font
            Size sizeFormCurrent = this.Size;
            scaleRatioX = (float)sizeFormCurrent.Width / (float)sizeFormOriginal.Width;
            scaleRatioY = (float)sizeFormCurrent.Height / (float)sizeFormOriginal.Height;
            if (scaleRatioX > scaleRatioY) scaleRatioFont = scaleRatioX;
            else scaleRatioFont = scaleRatioY;
        }

        private void ResizeControls()
        {//loops through all the controls setting the new size, position and font size for each control on the form
            //int ListFontsLength = listOriginalFonts.Count;
            int i = 0;
            foreach (Control ctrl in this.Controls)
            {
                ResizeControl(listOriginalRects[i], listOriginalFonts[i], ctrl);
                i++;
            }
        }

        private void ResizeControl(Rectangle origRect, Font origFont, Control control)
        {//does a resize operation for each control passed into the method
            int newXpos = (int)(origRect.X * scaleRatioX);
            int newYpos = (int)(origRect.Y * scaleRatioY);
            int newWidth = (int)(origRect.Width * scaleRatioX);
            int newHeight = (int)(origRect.Height * scaleRatioY);
            float newFontSize = origFont.Size * scaleRatioFont;
            control.Location = new Point(newXpos, newYpos);
            control.Size = new Size(newWidth, newHeight);
            control.Font = new Font(origFont.Name, newFontSize);
        }

        public void ReturnToMainMenu()
        { //set so this method is availiible to all form
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void FrmBase_Resize(object sender, EventArgs e)
        {
            CalcResizeRatios();
            ResizeControls();
        }

        public void ReturnToStaffMenu()
        {//set so this method is availiible to all form
            FrmStaffMenu frmStaffMenu = new FrmStaffMenu();
            this.Hide();
            frmStaffMenu.ShowDialog();
            this.Close();
        }

        public void CancelOrder()
        {//set so this method is availiible to all form
            if (MessageBox.Show("Are you sure you wish to cancel the order?", "cancel order confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.ProcessStorage.RestoreReservedItems();
                Program.ProcessOrder.ClearTempSandwhichVars();
                Program.ProcessOrder.ChosenSandwhiches.Clear();
                ReturnToMainMenu();
            }
                
        }

        
    }
}
