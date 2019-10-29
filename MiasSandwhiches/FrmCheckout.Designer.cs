namespace MiasSandwhiches
{
    partial class FrmCheckout
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
            this.LblOrderTotal = new System.Windows.Forms.Label();
            this.LabelOrderItems = new System.Windows.Forms.Label();
            this.listBoxRecipt = new System.Windows.Forms.ListBox();
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
            this.BtnCancelOrder.Location = new System.Drawing.Point(993, 548);
            this.BtnCancelOrder.Name = "BtnCancelOrder";
            this.BtnCancelOrder.Size = new System.Drawing.Size(120, 120);
            this.BtnCancelOrder.TabIndex = 28;
            this.BtnCancelOrder.Text = "Cancel Order";
            this.BtnCancelOrder.UseVisualStyleBackColor = false;
            this.BtnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // LblOrderTotal
            // 
            this.LblOrderTotal.AutoSize = true;
            this.LblOrderTotal.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.LblOrderTotal.Location = new System.Drawing.Point(100, 625);
            this.LblOrderTotal.Name = "LblOrderTotal";
            this.LblOrderTotal.Size = new System.Drawing.Size(171, 25);
            this.LblOrderTotal.TabIndex = 27;
            this.LblOrderTotal.Text = "Amount Due £";
            // 
            // LabelOrderItems
            // 
            this.LabelOrderItems.AutoSize = true;
            this.LabelOrderItems.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.LabelOrderItems.Location = new System.Drawing.Point(100, 171);
            this.LabelOrderItems.Name = "LabelOrderItems";
            this.LabelOrderItems.Size = new System.Drawing.Size(125, 25);
            this.LabelOrderItems.TabIndex = 26;
            this.LabelOrderItems.Text = "OrderItens";
            // 
            // listBoxRecipt
            // 
            this.listBoxRecipt.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.listBoxRecipt.FormattingEnabled = true;
            this.listBoxRecipt.ItemHeight = 25;
            this.listBoxRecipt.Location = new System.Drawing.Point(100, 199);
            this.listBoxRecipt.Name = "listBoxRecipt";
            this.listBoxRecipt.Size = new System.Drawing.Size(701, 379);
            this.listBoxRecipt.TabIndex = 25;
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
            this.BtnContinue.Location = new System.Drawing.Point(956, 255);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(200, 200);
            this.BtnContinue.TabIndex = 24;
            this.BtnContinue.Text = "Pay";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnCancelOrder);
            this.Controls.Add(this.LblOrderTotal);
            this.Controls.Add(this.LabelOrderItems);
            this.Controls.Add(this.listBoxRecipt);
            this.Controls.Add(this.BtnContinue);
            this.Name = "FrmCheckout";
            this.Text = "FrmCheckout";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.Controls.SetChildIndex(this.BtnContinue, 0);
            this.Controls.SetChildIndex(this.listBoxRecipt, 0);
            this.Controls.SetChildIndex(this.LabelOrderItems, 0);
            this.Controls.SetChildIndex(this.LblOrderTotal, 0);
            this.Controls.SetChildIndex(this.BtnCancelOrder, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse BtnCancelOrder;
        private System.Windows.Forms.Label LblOrderTotal;
        private System.Windows.Forms.Label LabelOrderItems;
        private System.Windows.Forms.ListBox listBoxRecipt;
        private ButtonEllipse BtnContinue;
    }
}