namespace MiasSandwhiches
{
    partial class FrmBase
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
            this.LableTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LableTitle
            // 
            this.LableTitle.AutoSize = true;
            this.LableTitle.BackColor = System.Drawing.Color.OliveDrab;
            this.LableTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LableTitle.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold);
            this.LableTitle.Location = new System.Drawing.Point(210, 26);
            this.LableTitle.Name = "LableTitle";
            this.LableTitle.Size = new System.Drawing.Size(844, 88);
            this.LableTitle.TabIndex = 2;
            this.LableTitle.Text = "Mias Sandwhiches";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiasSandwhiches.Properties.Resources.FrmBackgrounMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.LableTitle);
            this.DoubleBuffered = true;
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.Resize += new System.EventHandler(this.FrmBase_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LableTitle;
    }
}