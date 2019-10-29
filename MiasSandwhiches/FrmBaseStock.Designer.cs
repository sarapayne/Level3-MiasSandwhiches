namespace MiasSandwhiches
{
    partial class FrmBaseStock
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
            this.BtnStaffMenu = new MiasSandwhiches.ButtonEllipse();
            this.BtnCancel = new MiasSandwhiches.ButtonEllipse();
            this.BtnOk = new MiasSandwhiches.ButtonEllipse();
            this.SuspendLayout();
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
            this.BtnStaffMenu.Location = new System.Drawing.Point(1105, 12);
            this.BtnStaffMenu.Name = "BtnStaffMenu";
            this.BtnStaffMenu.Size = new System.Drawing.Size(130, 130);
            this.BtnStaffMenu.TabIndex = 31;
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
            this.BtnCancel.Location = new System.Drawing.Point(478, 615);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 80);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnOk.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnOk;
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOk.Location = new System.Drawing.Point(706, 615);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(80, 80);
            this.BtnOk.TabIndex = 29;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmBaseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnStaffMenu);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "FrmBaseStock";
            this.Text = "FrmBaseStock";
            this.Load += new System.EventHandler(this.FrmBaseStock_Load);
            this.Controls.SetChildIndex(this.BtnOk, 0);
            this.Controls.SetChildIndex(this.BtnCancel, 0);
            this.Controls.SetChildIndex(this.BtnStaffMenu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse BtnStaffMenu;
        private ButtonEllipse BtnCancel;
        private ButtonEllipse BtnOk;
    }
}