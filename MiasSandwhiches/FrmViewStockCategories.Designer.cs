namespace MiasSandwhiches
{
    partial class FrmViewStockCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCatagories = new System.Windows.Forms.ListBox();
            this.BtnStaffMenu = new MiasSandwhiches.ButtonEllipse();
            this.BtnCancel = new MiasSandwhiches.ButtonEllipse();
            this.SuspendLayout();
            // 
            // listBoxCatagories
            // 
            this.listBoxCatagories.FormattingEnabled = true;
            this.listBoxCatagories.Location = new System.Drawing.Point(291, 173);
            this.listBoxCatagories.Name = "listBoxCatagories";
            this.listBoxCatagories.Size = new System.Drawing.Size(682, 394);
            this.listBoxCatagories.TabIndex = 32;
            // 
            // BtnStaffMenu
            // 
            this.BtnStaffMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnStaffMenu.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnContinue;
            this.BtnStaffMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStaffMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStaffMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStaffMenu.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold);
            this.BtnStaffMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnStaffMenu.Location = new System.Drawing.Point(1074, 319);
            this.BtnStaffMenu.Name = "BtnStaffMenu";
            this.BtnStaffMenu.Size = new System.Drawing.Size(130, 130);
            this.BtnStaffMenu.TabIndex = 34;
            this.BtnStaffMenu.Text = "Staff Menu";
            this.BtnStaffMenu.UseVisualStyleBackColor = false;
            this.BtnStaffMenu.Click += new System.EventHandler(this.BtnStaffMenu_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCancel.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnCancel;
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(592, 618);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 80);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmViewStockCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnStaffMenu);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.listBoxCatagories);
            this.Name = "FrmViewStockCategories";
            this.Text = "FrmViewStockCategories";
            this.Load += new System.EventHandler(this.FrmViewStockCategories_Load);
            this.Controls.SetChildIndex(this.listBoxCatagories, 0);
            this.Controls.SetChildIndex(this.BtnCancel, 0);
            this.Controls.SetChildIndex(this.BtnStaffMenu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCatagories;
        private ButtonEllipse BtnStaffMenu;
        private ButtonEllipse BtnCancel;
    }
}