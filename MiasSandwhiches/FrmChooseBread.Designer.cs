namespace MiasSandwhiches
{
    partial class FrmChooseBread
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
            this.LblChooseBread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblChooseBread
            // 
            this.LblChooseBread.AutoSize = true;
            this.LblChooseBread.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LblChooseBread.Location = new System.Drawing.Point(458, 140);
            this.LblChooseBread.Name = "LblChooseBread";
            this.LblChooseBread.Size = new System.Drawing.Size(348, 41);
            this.LblChooseBread.TabIndex = 38;
            this.LblChooseBread.Text = "Choose Your Bread";
            // 
            // FrmChooseBread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LblChooseBread);
            this.Name = "FrmChooseBread";
            this.Text = "FrmChooseBread";
            this.Load += new System.EventHandler(this.FrmChooseBread_Load);
            this.Controls.SetChildIndex(this.LblChooseBread, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseBread;
    }
}