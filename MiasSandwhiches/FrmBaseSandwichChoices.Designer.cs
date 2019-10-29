namespace MiasSandwhiches
{
    partial class FrmBaseSandwichChoices
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
            this.BtnCancelOrder = new MiasSandwhiches.ButtonEllipse();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.LableFillings = new System.Windows.Forms.Label();
            this.listBoxChosenFillings = new System.Windows.Forms.ListBox();
            this.listBoxCat3 = new System.Windows.Forms.ListBox();
            this.listBoxCat2 = new System.Windows.Forms.ListBox();
            this.listBoxCat1 = new System.Windows.Forms.ListBox();
            this.BtnContinue = new MiasSandwhiches.ButtonEllipse();
            this.SuspendLayout();
            // 
            // BtnCancelOrder
            // 
            this.BtnCancelOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCancelOrder.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnCancel;
            this.BtnCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelOrder.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnCancelOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelOrder.Location = new System.Drawing.Point(1072, 576);
            this.BtnCancelOrder.Name = "BtnCancelOrder";
            this.BtnCancelOrder.Size = new System.Drawing.Size(120, 120);
            this.BtnCancelOrder.TabIndex = 35;
            this.BtnCancelOrder.Text = "Cancel Order";
            this.BtnCancelOrder.UseVisualStyleBackColor = false;
            this.BtnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.labelItemPrice.Location = new System.Drawing.Point(316, 624);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(150, 25);
            this.labelItemPrice.TabIndex = 34;
            this.labelItemPrice.Text = "Item Price £";
            this.labelItemPrice.Visible = false;
            // 
            // LableFillings
            // 
            this.LableFillings.AutoSize = true;
            this.LableFillings.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.LableFillings.Location = new System.Drawing.Point(806, 227);
            this.LableFillings.Name = "LableFillings";
            this.LableFillings.Size = new System.Drawing.Size(180, 25);
            this.LableFillings.TabIndex = 33;
            this.LableFillings.Text = "Chosen Fillings";
            this.LableFillings.Visible = false;
            // 
            // listBoxChosenFillings
            // 
            this.listBoxChosenFillings.FormattingEnabled = true;
            this.listBoxChosenFillings.Location = new System.Drawing.Point(802, 255);
            this.listBoxChosenFillings.Name = "listBoxChosenFillings";
            this.listBoxChosenFillings.Size = new System.Drawing.Size(194, 264);
            this.listBoxChosenFillings.TabIndex = 32;
            this.listBoxChosenFillings.Visible = false;
            // 
            // listBoxCat3
            // 
            this.listBoxCat3.Enabled = false;
            this.listBoxCat3.FormattingEnabled = true;
            this.listBoxCat3.Location = new System.Drawing.Point(549, 255);
            this.listBoxCat3.Name = "listBoxCat3";
            this.listBoxCat3.Size = new System.Drawing.Size(194, 264);
            this.listBoxCat3.TabIndex = 31;
            this.listBoxCat3.Visible = false;
            this.listBoxCat3.Click += new System.EventHandler(this.listBoxCat3_Click);
            // 
            // listBoxCat2
            // 
            this.listBoxCat2.Enabled = false;
            this.listBoxCat2.FormattingEnabled = true;
            this.listBoxCat2.Location = new System.Drawing.Point(296, 255);
            this.listBoxCat2.Name = "listBoxCat2";
            this.listBoxCat2.Size = new System.Drawing.Size(194, 264);
            this.listBoxCat2.TabIndex = 30;
            this.listBoxCat2.Visible = false;
            this.listBoxCat2.Click += new System.EventHandler(this.listBoxCat2_Click);
            // 
            // listBoxCat1
            // 
            this.listBoxCat1.FormattingEnabled = true;
            this.listBoxCat1.Location = new System.Drawing.Point(43, 255);
            this.listBoxCat1.Name = "listBoxCat1";
            this.listBoxCat1.Size = new System.Drawing.Size(194, 264);
            this.listBoxCat1.TabIndex = 29;
            this.listBoxCat1.Click += new System.EventHandler(this.listBoxCat1_Click);
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnContinue.BackgroundImage = global::MiasSandwhiches.Properties.Resources.btnContinue;
            this.BtnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnContinue.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnContinue.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnContinue.Location = new System.Drawing.Point(1032, 281);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(200, 200);
            this.BtnContinue.TabIndex = 36;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FrmBaseSandwichChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.BtnCancelOrder);
            this.Controls.Add(this.labelItemPrice);
            this.Controls.Add(this.LableFillings);
            this.Controls.Add(this.listBoxChosenFillings);
            this.Controls.Add(this.listBoxCat3);
            this.Controls.Add(this.listBoxCat2);
            this.Controls.Add(this.listBoxCat1);
            this.Name = "FrmBaseSandwichChoices";
            this.Text = "FrmBaseSandwichChoices";
            this.Load += new System.EventHandler(this.FrmBaseSandwichChoices_Load);
            this.Controls.SetChildIndex(this.listBoxCat1, 0);
            this.Controls.SetChildIndex(this.listBoxCat2, 0);
            this.Controls.SetChildIndex(this.listBoxCat3, 0);
            this.Controls.SetChildIndex(this.listBoxChosenFillings, 0);
            this.Controls.SetChildIndex(this.LableFillings, 0);
            this.Controls.SetChildIndex(this.labelItemPrice, 0);
            this.Controls.SetChildIndex(this.BtnCancelOrder, 0);
            this.Controls.SetChildIndex(this.BtnContinue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse BtnCancelOrder;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.Label LableFillings;
        private System.Windows.Forms.ListBox listBoxChosenFillings;
        private System.Windows.Forms.ListBox listBoxCat3;
        private System.Windows.Forms.ListBox listBoxCat2;
        private System.Windows.Forms.ListBox listBoxCat1;
        private ButtonEllipse BtnContinue;
    }
}