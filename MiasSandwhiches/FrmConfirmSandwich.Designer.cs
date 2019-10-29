namespace MiasSandwhiches
{
    partial class FrmConfirmSandwich
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
            this.BtnNewSandwhich = new MiasSandwhiches.ButtonEllipse();
            this.BtnClearSandwhich = new MiasSandwhiches.ButtonEllipse();
            this.BtnAddCart = new MiasSandwhiches.ButtonEllipse();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.BtnContinue = new MiasSandwhiches.ButtonEllipse();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBreadSauceSpread = new System.Windows.Forms.Label();
            this.labelSalad = new System.Windows.Forms.Label();
            this.Fillings = new System.Windows.Forms.Label();
            this.listBoxSalad = new System.Windows.Forms.ListBox();
            this.listBoxFillings = new System.Windows.Forms.ListBox();
            this.listBoxBreadSpreadSauce = new System.Windows.Forms.ListBox();
            this.LblPictureWarning = new System.Windows.Forms.Label();
            this.LblSandwichConfirmation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNewSandwhich
            // 
            this.BtnNewSandwhich.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnNewSandwhich.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnOk;
            this.BtnNewSandwhich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNewSandwhich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewSandwhich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNewSandwhich.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.BtnNewSandwhich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNewSandwhich.Location = new System.Drawing.Point(795, 388);
            this.BtnNewSandwhich.Name = "BtnNewSandwhich";
            this.BtnNewSandwhich.Size = new System.Drawing.Size(125, 125);
            this.BtnNewSandwhich.TabIndex = 40;
            this.BtnNewSandwhich.Text = "Add Another";
            this.BtnNewSandwhich.UseVisualStyleBackColor = false;
            this.BtnNewSandwhich.Click += new System.EventHandler(this.BtnNewSandwhich_Click);
            // 
            // BtnClearSandwhich
            // 
            this.BtnClearSandwhich.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnClearSandwhich.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnCancel;
            this.BtnClearSandwhich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClearSandwhich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearSandwhich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClearSandwhich.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.BtnClearSandwhich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClearSandwhich.Location = new System.Drawing.Point(795, 549);
            this.BtnClearSandwhich.Name = "BtnClearSandwhich";
            this.BtnClearSandwhich.Size = new System.Drawing.Size(125, 125);
            this.BtnClearSandwhich.TabIndex = 39;
            this.BtnClearSandwhich.Text = "Del This Item";
            this.BtnClearSandwhich.UseVisualStyleBackColor = false;
            this.BtnClearSandwhich.Click += new System.EventHandler(this.BtnClearSandwhich_Click);
            // 
            // BtnAddCart
            // 
            this.BtnAddCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAddCart.BackgroundImage = global::MiasSandwhiches.Properties.Resources.add_to_cart;
            this.BtnAddCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddCart.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.BtnAddCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAddCart.Location = new System.Drawing.Point(795, 227);
            this.BtnAddCart.Name = "BtnAddCart";
            this.BtnAddCart.Size = new System.Drawing.Size(125, 125);
            this.BtnAddCart.TabIndex = 38;
            this.BtnAddCart.Text = "Add To Cart";
            this.BtnAddCart.UseVisualStyleBackColor = false;
            this.BtnAddCart.Click += new System.EventHandler(this.BtnAddCart_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Location = new System.Drawing.Point(1007, 472);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(208, 202);
            this.pictureBoxImage.TabIndex = 37;
            this.pictureBoxImage.TabStop = false;
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnContinue.BackgroundImage = global::MiasSandwhiches.Properties.Resources.ShoppingCart;
            this.BtnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnContinue.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.BtnContinue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnContinue.Location = new System.Drawing.Point(1001, 225);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(200, 200);
            this.BtnContinue.TabIndex = 36;
            this.BtnContinue.Text = "Checkout";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(86, 590);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(158, 55);
            this.labelPrice.TabIndex = 35;
            this.labelPrice.Text = "Price:";
            // 
            // labelBreadSauceSpread
            // 
            this.labelBreadSauceSpread.AutoSize = true;
            this.labelBreadSauceSpread.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.labelBreadSauceSpread.Location = new System.Drawing.Point(63, 237);
            this.labelBreadSauceSpread.Name = "labelBreadSauceSpread";
            this.labelBreadSauceSpread.Size = new System.Drawing.Size(223, 25);
            this.labelBreadSauceSpread.TabIndex = 34;
            this.labelBreadSauceSpread.Text = "Bread/Sauce/Spread";
            // 
            // labelSalad
            // 
            this.labelSalad.AutoSize = true;
            this.labelSalad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.labelSalad.Location = new System.Drawing.Point(605, 237);
            this.labelSalad.Name = "labelSalad";
            this.labelSalad.Size = new System.Drawing.Size(72, 25);
            this.labelSalad.TabIndex = 33;
            this.labelSalad.Text = "Salad";
            // 
            // Fillings
            // 
            this.Fillings.AutoSize = true;
            this.Fillings.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.Fillings.Location = new System.Drawing.Point(364, 237);
            this.Fillings.Name = "Fillings";
            this.Fillings.Size = new System.Drawing.Size(98, 25);
            this.Fillings.TabIndex = 32;
            this.Fillings.Text = "Fillings";
            // 
            // listBoxSalad
            // 
            this.listBoxSalad.FormattingEnabled = true;
            this.listBoxSalad.Location = new System.Drawing.Point(552, 265);
            this.listBoxSalad.Name = "listBoxSalad";
            this.listBoxSalad.Size = new System.Drawing.Size(194, 277);
            this.listBoxSalad.TabIndex = 31;
            // 
            // listBoxFillings
            // 
            this.listBoxFillings.FormattingEnabled = true;
            this.listBoxFillings.Location = new System.Drawing.Point(315, 265);
            this.listBoxFillings.Name = "listBoxFillings";
            this.listBoxFillings.Size = new System.Drawing.Size(194, 277);
            this.listBoxFillings.TabIndex = 30;
            // 
            // listBoxBreadSpreadSauce
            // 
            this.listBoxBreadSpreadSauce.FormattingEnabled = true;
            this.listBoxBreadSpreadSauce.Location = new System.Drawing.Point(78, 265);
            this.listBoxBreadSpreadSauce.Name = "listBoxBreadSpreadSauce";
            this.listBoxBreadSpreadSauce.Size = new System.Drawing.Size(194, 277);
            this.listBoxBreadSpreadSauce.TabIndex = 29;
            // 
            // LblPictureWarning
            // 
            this.LblPictureWarning.AutoSize = true;
            this.LblPictureWarning.Location = new System.Drawing.Point(1010, 677);
            this.LblPictureWarning.Name = "LblPictureWarning";
            this.LblPictureWarning.Size = new System.Drawing.Size(203, 13);
            this.LblPictureWarning.TabIndex = 41;
            this.LblPictureWarning.Text = "Sample picture. Actual Sandwich will vary";
            // 
            // LblSandwichConfirmation
            // 
            this.LblSandwichConfirmation.AutoSize = true;
            this.LblSandwichConfirmation.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LblSandwichConfirmation.Location = new System.Drawing.Point(385, 126);
            this.LblSandwichConfirmation.Name = "LblSandwichConfirmation";
            this.LblSandwichConfirmation.Size = new System.Drawing.Size(495, 41);
            this.LblSandwichConfirmation.TabIndex = 42;
            this.LblSandwichConfirmation.Text = "Please confirm your choices";
            // 
            // FrmConfirmSandwich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LblSandwichConfirmation);
            this.Controls.Add(this.LblPictureWarning);
            this.Controls.Add(this.BtnNewSandwhich);
            this.Controls.Add(this.BtnClearSandwhich);
            this.Controls.Add(this.BtnAddCart);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBreadSauceSpread);
            this.Controls.Add(this.labelSalad);
            this.Controls.Add(this.Fillings);
            this.Controls.Add(this.listBoxSalad);
            this.Controls.Add(this.listBoxFillings);
            this.Controls.Add(this.listBoxBreadSpreadSauce);
            this.Name = "FrmConfirmSandwich";
            this.Text = "FrmConfirmSandwich";
            this.Load += new System.EventHandler(this.FrmConfirmSandwich_Load);
            this.Controls.SetChildIndex(this.listBoxBreadSpreadSauce, 0);
            this.Controls.SetChildIndex(this.listBoxFillings, 0);
            this.Controls.SetChildIndex(this.listBoxSalad, 0);
            this.Controls.SetChildIndex(this.Fillings, 0);
            this.Controls.SetChildIndex(this.labelSalad, 0);
            this.Controls.SetChildIndex(this.labelBreadSauceSpread, 0);
            this.Controls.SetChildIndex(this.labelPrice, 0);
            this.Controls.SetChildIndex(this.BtnContinue, 0);
            this.Controls.SetChildIndex(this.pictureBoxImage, 0);
            this.Controls.SetChildIndex(this.BtnAddCart, 0);
            this.Controls.SetChildIndex(this.BtnClearSandwhich, 0);
            this.Controls.SetChildIndex(this.BtnNewSandwhich, 0);
            this.Controls.SetChildIndex(this.LblPictureWarning, 0);
            this.Controls.SetChildIndex(this.LblSandwichConfirmation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse BtnNewSandwhich;
        private ButtonEllipse BtnClearSandwhich;
        private ButtonEllipse BtnAddCart;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private ButtonEllipse BtnContinue;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBreadSauceSpread;
        private System.Windows.Forms.Label labelSalad;
        private System.Windows.Forms.Label Fillings;
        private System.Windows.Forms.ListBox listBoxSalad;
        private System.Windows.Forms.ListBox listBoxFillings;
        private System.Windows.Forms.ListBox listBoxBreadSpreadSauce;
        private System.Windows.Forms.Label LblPictureWarning;
        private System.Windows.Forms.Label LblSandwichConfirmation;
    }
}