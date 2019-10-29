namespace MiasSandwhiches
{
    partial class FrmStaffMenu
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
            this.BtnViewDelProductCatagories = new System.Windows.Forms.Button();
            this.BtnAddProductCatagories = new System.Windows.Forms.Button();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.BtnEditStock = new System.Windows.Forms.Button();
            this.BtnLogOut = new MiasSandwhiches.ButtonEllipse();
            this.SuspendLayout();
            // 
            // BtnViewDelProductCatagories
            // 
            this.BtnViewDelProductCatagories.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnViewDelProductCatagories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewDelProductCatagories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnViewDelProductCatagories.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnViewDelProductCatagories.Location = new System.Drawing.Point(279, 421);
            this.BtnViewDelProductCatagories.Name = "BtnViewDelProductCatagories";
            this.BtnViewDelProductCatagories.Size = new System.Drawing.Size(154, 86);
            this.BtnViewDelProductCatagories.TabIndex = 20;
            this.BtnViewDelProductCatagories.Text = "View / Del Product Catagories";
            this.BtnViewDelProductCatagories.UseVisualStyleBackColor = false;
            this.BtnViewDelProductCatagories.Click += new System.EventHandler(this.BtnViewDelProductCatagories_Click);
            // 
            // BtnAddProductCatagories
            // 
            this.BtnAddProductCatagories.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAddProductCatagories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProductCatagories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddProductCatagories.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnAddProductCatagories.Location = new System.Drawing.Point(279, 272);
            this.BtnAddProductCatagories.Name = "BtnAddProductCatagories";
            this.BtnAddProductCatagories.Size = new System.Drawing.Size(154, 86);
            this.BtnAddProductCatagories.TabIndex = 19;
            this.BtnAddProductCatagories.Text = "Add Product Catagories";
            this.BtnAddProductCatagories.UseVisualStyleBackColor = false;
            this.BtnAddProductCatagories.Click += new System.EventHandler(this.BtnAddProductCatagories_Click);
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddStock.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnAddStock.Location = new System.Drawing.Point(568, 272);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(154, 86);
            this.BtnAddStock.TabIndex = 18;
            this.BtnAddStock.Text = "AddStock";
            this.BtnAddStock.UseVisualStyleBackColor = false;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // BtnEditStock
            // 
            this.BtnEditStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEditStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditStock.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnEditStock.Location = new System.Drawing.Point(568, 421);
            this.BtnEditStock.Name = "BtnEditStock";
            this.BtnEditStock.Size = new System.Drawing.Size(154, 86);
            this.BtnEditStock.TabIndex = 17;
            this.BtnEditStock.Text = "EditStock";
            this.BtnEditStock.UseVisualStyleBackColor = false;
            this.BtnEditStock.Click += new System.EventHandler(this.BtnEditStock_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnLogOut.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnContinue;
            this.BtnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogOut.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLogOut.Location = new System.Drawing.Point(944, 285);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(200, 200);
            this.BtnLogOut.TabIndex = 16;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // FrmStaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnViewDelProductCatagories);
            this.Controls.Add(this.BtnAddProductCatagories);
            this.Controls.Add(this.BtnAddStock);
            this.Controls.Add(this.BtnEditStock);
            this.Controls.Add(this.BtnLogOut);
            this.Name = "FrmStaffMenu";
            this.Text = "FrmStaffMenu";
            this.Load += new System.EventHandler(this.FrmStaffMenu_Load);
            this.Controls.SetChildIndex(this.BtnLogOut, 0);
            this.Controls.SetChildIndex(this.BtnEditStock, 0);
            this.Controls.SetChildIndex(this.BtnAddStock, 0);
            this.Controls.SetChildIndex(this.BtnAddProductCatagories, 0);
            this.Controls.SetChildIndex(this.BtnViewDelProductCatagories, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnViewDelProductCatagories;
        private System.Windows.Forms.Button BtnAddProductCatagories;
        private System.Windows.Forms.Button BtnAddStock;
        private System.Windows.Forms.Button BtnEditStock;
        private ButtonEllipse BtnLogOut;
    }
}