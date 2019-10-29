namespace MiasSandwhiches
{
    partial class FrmAddStock
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
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxLevel3 = new System.Windows.Forms.ListBox();
            this.listBoxLevel2 = new System.Windows.Forms.ListBox();
            this.listBoxLevel1 = new System.Windows.Forms.ListBox();
            this.listBoxLevel0 = new System.Windows.Forms.ListBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 22.7F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(85, 151);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(99, 32);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "Name:";
            // 
            // listBoxLevel3
            // 
            this.listBoxLevel3.Enabled = false;
            this.listBoxLevel3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLevel3.FormattingEnabled = true;
            this.listBoxLevel3.ItemHeight = 21;
            this.listBoxLevel3.Location = new System.Drawing.Point(435, 389);
            this.listBoxLevel3.Name = "listBoxLevel3";
            this.listBoxLevel3.Size = new System.Drawing.Size(213, 193);
            this.listBoxLevel3.TabIndex = 40;
            this.listBoxLevel3.Visible = false;
            this.listBoxLevel3.Click += new System.EventHandler(this.listBoxLevel3_Click);
            // 
            // listBoxLevel2
            // 
            this.listBoxLevel2.Enabled = false;
            this.listBoxLevel2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLevel2.FormattingEnabled = true;
            this.listBoxLevel2.ItemHeight = 21;
            this.listBoxLevel2.Location = new System.Drawing.Point(966, 200);
            this.listBoxLevel2.Name = "listBoxLevel2";
            this.listBoxLevel2.Size = new System.Drawing.Size(213, 382);
            this.listBoxLevel2.TabIndex = 39;
            this.listBoxLevel2.Visible = false;
            this.listBoxLevel2.Click += new System.EventHandler(this.listBoxLevel2_Click);
            // 
            // listBoxLevel1
            // 
            this.listBoxLevel1.Enabled = false;
            this.listBoxLevel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLevel1.FormattingEnabled = true;
            this.listBoxLevel1.ItemHeight = 21;
            this.listBoxLevel1.Location = new System.Drawing.Point(702, 200);
            this.listBoxLevel1.Name = "listBoxLevel1";
            this.listBoxLevel1.Size = new System.Drawing.Size(213, 382);
            this.listBoxLevel1.TabIndex = 38;
            this.listBoxLevel1.Visible = false;
            this.listBoxLevel1.Click += new System.EventHandler(this.listBoxLevel1_Click);
            // 
            // listBoxLevel0
            // 
            this.listBoxLevel0.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLevel0.FormattingEnabled = true;
            this.listBoxLevel0.ItemHeight = 21;
            this.listBoxLevel0.Location = new System.Drawing.Point(435, 200);
            this.listBoxLevel0.Name = "listBoxLevel0";
            this.listBoxLevel0.Size = new System.Drawing.Size(213, 172);
            this.listBoxLevel0.TabIndex = 37;
            this.listBoxLevel0.Click += new System.EventHandler(this.listBoxLevel0_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxQuantity.Location = new System.Drawing.Point(250, 552);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(128, 33);
            this.textBoxQuantity.TabIndex = 36;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Modern No. 20", 22.7F, System.Drawing.FontStyle.Bold);
            this.labelQuantity.Location = new System.Drawing.Point(89, 550);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(134, 32);
            this.labelQuantity.TabIndex = 35;
            this.labelQuantity.Text = "Quantity";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImage = global::MiasSandwhiches.Properties.Resources.Click_Here_To_Load_Image;
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Location = new System.Drawing.Point(85, 200);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(293, 266);
            this.pictureBoxImage.TabIndex = 34;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(250, 478);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(128, 33);
            this.textBoxPrice.TabIndex = 33;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 22.7F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(85, 479);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 32);
            this.labelPrice.TabIndex = 32;
            this.labelPrice.Text = "Price";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxLevel3);
            this.Controls.Add(this.listBoxLevel2);
            this.Controls.Add(this.listBoxLevel1);
            this.Controls.Add(this.listBoxLevel0);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Name = "FrmAddStock";
            this.Text = "FrmAddStock";
            this.Load += new System.EventHandler(this.FrmAddStock_Load);
            this.Controls.SetChildIndex(this.labelPrice, 0);
            this.Controls.SetChildIndex(this.textBoxPrice, 0);
            this.Controls.SetChildIndex(this.pictureBoxImage, 0);
            this.Controls.SetChildIndex(this.labelQuantity, 0);
            this.Controls.SetChildIndex(this.textBoxQuantity, 0);
            this.Controls.SetChildIndex(this.listBoxLevel0, 0);
            this.Controls.SetChildIndex(this.listBoxLevel1, 0);
            this.Controls.SetChildIndex(this.listBoxLevel2, 0);
            this.Controls.SetChildIndex(this.listBoxLevel3, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxLevel3;
        private System.Windows.Forms.ListBox listBoxLevel2;
        private System.Windows.Forms.ListBox listBoxLevel1;
        private System.Windows.Forms.ListBox listBoxLevel0;
        protected System.Windows.Forms.TextBox textBoxQuantity;
        protected System.Windows.Forms.Label labelQuantity;
        protected System.Windows.Forms.PictureBox pictureBoxImage;
        protected System.Windows.Forms.TextBox textBoxPrice;
        protected System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}