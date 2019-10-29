namespace MiasSandwhiches
{
    partial class FrmChooseSalad
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
            this.LblChooseSalad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblChooseSalad
            // 
            this.LblChooseSalad.AutoSize = true;
            this.LblChooseSalad.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LblChooseSalad.Location = new System.Drawing.Point(409, 140);
            this.LblChooseSalad.Name = "LblChooseSalad";
            this.LblChooseSalad.Size = new System.Drawing.Size(446, 41);
            this.LblChooseSalad.TabIndex = 38;
            this.LblChooseSalad.Text = "Choose Your Salad Items";
            // 
            // FrmChooseSalad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LblChooseSalad);
            this.Name = "FrmChooseSalad";
            this.Text = "FrmChooseSalad";
            this.Load += new System.EventHandler(this.FrmChooseSalad_Load);
            this.Controls.SetChildIndex(this.LblChooseSalad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseSalad;
    }
}