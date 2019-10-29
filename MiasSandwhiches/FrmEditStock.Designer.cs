namespace MiasSandwhiches
{
    partial class FrmEditStock
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
            this.listBoxStockNames = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxStockNames
            // 
            this.listBoxStockNames.FormattingEnabled = true;
            this.listBoxStockNames.Location = new System.Drawing.Point(85, 168);
            this.listBoxStockNames.Name = "listBoxStockNames";
            this.listBoxStockNames.Size = new System.Drawing.Size(548, 394);
            this.listBoxStockNames.TabIndex = 33;
            this.listBoxStockNames.Click += new System.EventHandler(this.listBoxStockNames_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 22.7F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(773, 162);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(99, 32);
            this.labelName.TabIndex = 44;
            this.labelName.Text = "Name:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxQuantity.Location = new System.Drawing.Point(938, 537);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(128, 33);
            this.textBoxQuantity.TabIndex = 43;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Modern No. 20", 22.7F, System.Drawing.FontStyle.Bold);
            this.labelQuantity.Location = new System.Drawing.Point(773, 535);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(134, 32);
            this.labelQuantity.TabIndex = 42;
            this.labelQuantity.Text = "Quantity";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Location = new System.Drawing.Point(773, 206);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(293, 266);
            this.pictureBoxImage.TabIndex = 41;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click_1);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(938, 487);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(128, 33);
            this.textBoxPrice.TabIndex = 40;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 22.7F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(773, 485);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 32);
            this.labelPrice.TabIndex = 39;
            this.labelPrice.Text = "Price";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.listBoxStockNames);
            this.Name = "FrmEditStock";
            this.Text = "FrmEditStock";
            this.Load += new System.EventHandler(this.FrmEditStock_Load);
            this.Controls.SetChildIndex(this.listBoxStockNames, 0);
            this.Controls.SetChildIndex(this.labelPrice, 0);
            this.Controls.SetChildIndex(this.textBoxPrice, 0);
            this.Controls.SetChildIndex(this.pictureBoxImage, 0);
            this.Controls.SetChildIndex(this.labelQuantity, 0);
            this.Controls.SetChildIndex(this.textBoxQuantity, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStockNames;
        protected System.Windows.Forms.Label labelName;
        protected System.Windows.Forms.TextBox textBoxQuantity;
        protected System.Windows.Forms.Label labelQuantity;
        protected System.Windows.Forms.PictureBox pictureBoxImage;
        protected System.Windows.Forms.TextBox textBoxPrice;
        protected System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}