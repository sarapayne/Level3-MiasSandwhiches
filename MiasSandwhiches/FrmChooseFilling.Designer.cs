namespace MiasSandwhiches
{
    partial class FrmChooseFilling
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
            this.LblChooseFillings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblChooseFillings
            // 
            this.LblChooseFillings.AutoSize = true;
            this.LblChooseFillings.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LblChooseFillings.Location = new System.Drawing.Point(442, 140);
            this.LblChooseFillings.Name = "LblChooseFillings";
            this.LblChooseFillings.Size = new System.Drawing.Size(381, 41);
            this.LblChooseFillings.TabIndex = 37;
            this.LblChooseFillings.Text = "Choose Your Fillings";
            // 
            // FrmChooseFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LblChooseFillings);
            this.Name = "FrmChooseFilling";
            this.Text = "FrmChooseFilling";
            this.Load += new System.EventHandler(this.FrmChooseFilling_Load);
            this.Controls.SetChildIndex(this.LblChooseFillings, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseFillings;
    }
}