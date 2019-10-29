namespace MiasSandwhiches
{
    partial class FrmMain
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
            this.BtnStoreLogin = new System.Windows.Forms.Button();
            this.BtnContinue = new MiasSandwhiches.ButtonEllipse();
            this.SuspendLayout();
            // 
            // BtnStoreLogin
            // 
            this.BtnStoreLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnStoreLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStoreLogin.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.BtnStoreLogin.Location = new System.Drawing.Point(567, 607);
            this.BtnStoreLogin.Name = "BtnStoreLogin";
            this.BtnStoreLogin.Size = new System.Drawing.Size(131, 63);
            this.BtnStoreLogin.TabIndex = 4;
            this.BtnStoreLogin.Text = "Store Login";
            this.BtnStoreLogin.UseVisualStyleBackColor = false;
            this.BtnStoreLogin.Click += new System.EventHandler(this.BtnStoreLogin_Click);
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
            this.BtnContinue.Location = new System.Drawing.Point(532, 270);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(200, 200);
            this.BtnContinue.TabIndex = 5;
            this.BtnContinue.Text = "Start";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.BtnStoreLogin);
            this.Name = "FrmMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.BtnStoreLogin, 0);
            this.Controls.SetChildIndex(this.BtnContinue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStoreLogin;
        private ButtonEllipse BtnContinue;
    }
}

