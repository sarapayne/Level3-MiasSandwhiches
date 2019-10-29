namespace MiasSandwhiches
{
    partial class FrmChooseSauce
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
            this.LblChooseSauce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblChooseSauce
            // 
            this.LblChooseSauce.AutoSize = true;
            this.LblChooseSauce.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.LblChooseSauce.Location = new System.Drawing.Point(461, 140);
            this.LblChooseSauce.Name = "LblChooseSauce";
            this.LblChooseSauce.Size = new System.Drawing.Size(342, 41);
            this.LblChooseSauce.TabIndex = 38;
            this.LblChooseSauce.Text = "Choose Your Sauce";
            // 
            // FrmChooseSauce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LblChooseSauce);
            this.Name = "FrmChooseSauce";
            this.Text = "FrmChooseSauce";
            this.Load += new System.EventHandler(this.FrmChooseSauce_Load);
            this.Controls.SetChildIndex(this.LblChooseSauce, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseSauce;
    }
}