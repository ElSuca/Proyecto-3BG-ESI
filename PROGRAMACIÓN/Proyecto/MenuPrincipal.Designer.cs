namespace Proyecto
{
    partial class MenuPrincipal
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
            this.BannerPic = new System.Windows.Forms.PictureBox();
            this.txtdebugg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BannerPic
            // 
            this.BannerPic.Location = new System.Drawing.Point(263, 12);
            this.BannerPic.Name = "BannerPic";
            this.BannerPic.Size = new System.Drawing.Size(516, 90);
            this.BannerPic.TabIndex = 0;
            this.BannerPic.TabStop = false;
            this.BannerPic.Click += new System.EventHandler(this.BannerPic_Click);
            // 
            // txtdebugg
            // 
            this.txtdebugg.AutoSize = true;
            this.txtdebugg.Location = new System.Drawing.Point(362, 153);
            this.txtdebugg.Name = "txtdebugg";
            this.txtdebugg.Size = new System.Drawing.Size(35, 13);
            this.txtdebugg.TabIndex = 1;
            this.txtdebugg.Text = "label1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 638);
            this.Controls.Add(this.txtdebugg);
            this.Controls.Add(this.BannerPic);
            this.Name = "MenuPrincipal";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BannerPic;
        private System.Windows.Forms.Label txtdebugg;
    }
}