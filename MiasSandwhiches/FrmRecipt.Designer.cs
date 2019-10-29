namespace MiasSandwhiches
{
    partial class FrmRecipt
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
            this.BtnPrintRecipt = new System.Windows.Forms.Button();
            this.LabelThankyou = new System.Windows.Forms.Label();
            this.listBoxRecipt = new System.Windows.Forms.ListBox();
            this.BtnContinue = new MiasSandwhiches.ButtonEllipse();
            this.SuspendLayout();
            // 
            // BtnPrintRecipt
            // 
            this.BtnPrintRecipt.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnPrintRecipt.Location = new System.Drawing.Point(975, 586);
            this.BtnPrintRecipt.Name = "BtnPrintRecipt";
            this.BtnPrintRecipt.Size = new System.Drawing.Size(153, 61);
            this.BtnPrintRecipt.TabIndex = 28;
            this.BtnPrintRecipt.Text = "Print Receipt";
            this.BtnPrintRecipt.UseVisualStyleBackColor = true;
            this.BtnPrintRecipt.Click += new System.EventHandler(this.BtnPrintRecipt_Click);
            // 
            // LabelThankyou
            // 
            this.LabelThankyou.AutoSize = true;
            this.LabelThankyou.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LabelThankyou.Location = new System.Drawing.Point(96, 181);
            this.LabelThankyou.Name = "LabelThankyou";
            this.LabelThankyou.Size = new System.Drawing.Size(493, 41);
            this.LabelThankyou.TabIndex = 27;
            this.LabelThankyou.Text = "Thankyou for your payment";
            // 
            // listBoxRecipt
            // 
            this.listBoxRecipt.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.listBoxRecipt.FormattingEnabled = true;
            this.listBoxRecipt.ItemHeight = 25;
            this.listBoxRecipt.Location = new System.Drawing.Point(101, 243);
            this.listBoxRecipt.Name = "listBoxRecipt";
            this.listBoxRecipt.Size = new System.Drawing.Size(701, 404);
            this.listBoxRecipt.TabIndex = 26;
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
            this.BtnContinue.Location = new System.Drawing.Point(949, 311);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(200, 200);
            this.BtnContinue.TabIndex = 25;
            this.BtnContinue.Text = "Finish";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FrmRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnPrintRecipt);
            this.Controls.Add(this.LabelThankyou);
            this.Controls.Add(this.listBoxRecipt);
            this.Controls.Add(this.BtnContinue);
            this.Name = "FrmRecipt";
            this.Text = "FrmRecipt";
            this.Load += new System.EventHandler(this.FrmRecipt_Load);
            this.Controls.SetChildIndex(this.BtnContinue, 0);
            this.Controls.SetChildIndex(this.listBoxRecipt, 0);
            this.Controls.SetChildIndex(this.LabelThankyou, 0);
            this.Controls.SetChildIndex(this.BtnPrintRecipt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrintRecipt;
        private System.Windows.Forms.Label LabelThankyou;
        private System.Windows.Forms.ListBox listBoxRecipt;
        private ButtonEllipse BtnContinue;
    }
}