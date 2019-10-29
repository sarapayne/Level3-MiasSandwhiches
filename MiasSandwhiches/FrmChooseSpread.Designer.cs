namespace MiasSandwhiches
{
    partial class FrmChooseSpread
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
            this.LblChooseSpread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblChooseSpread
            // 
            this.LblChooseSpread.AutoSize = true;
            this.LblChooseSpread.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LblChooseSpread.Location = new System.Drawing.Point(452, 140);
            this.LblChooseSpread.Name = "LblChooseSpread";
            this.LblChooseSpread.Size = new System.Drawing.Size(361, 41);
            this.LblChooseSpread.TabIndex = 38;
            this.LblChooseSpread.Text = "Choose Your Spread";
            // 
            // FrmChooseSpread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LblChooseSpread);
            this.Name = "FrmChooseSpread";
            this.Text = "FrmChooseSpread";
            this.Load += new System.EventHandler(this.FrmChooseSpread_Load);
            this.Controls.SetChildIndex(this.LblChooseSpread, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseSpread;
    }
}