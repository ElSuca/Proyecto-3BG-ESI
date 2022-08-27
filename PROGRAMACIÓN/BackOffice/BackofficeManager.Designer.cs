namespace Proyecto.Backoffice
{
    partial class BackofficeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackofficeManager));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserManagerToggle = new System.Windows.Forms.Button();
            this.btnAdManager = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Back Office ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserManagerToggle
            // 
            this.btnUserManagerToggle.Location = new System.Drawing.Point(12, 94);
            this.btnUserManagerToggle.Name = "btnUserManagerToggle";
            this.btnUserManagerToggle.Size = new System.Drawing.Size(84, 23);
            this.btnUserManagerToggle.TabIndex = 43;
            this.btnUserManagerToggle.Text = "User Manager";
            this.btnUserManagerToggle.UseVisualStyleBackColor = true;
            this.btnUserManagerToggle.Click += new System.EventHandler(this.btnUserManagerToggle_Click);
            // 
            // btnAdManager
            // 
            this.btnAdManager.Location = new System.Drawing.Point(12, 123);
            this.btnAdManager.Name = "btnAdManager";
            this.btnAdManager.Size = new System.Drawing.Size(84, 23);
            this.btnAdManager.TabIndex = 44;
            this.btnAdManager.Text = "Ad Manager";
            this.btnAdManager.UseVisualStyleBackColor = true;
            this.btnAdManager.Click += new System.EventHandler(this.btnAdManager_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(138, 94);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1280, 502);
            this.MainPanel.TabIndex = 45;
            // 
            // BackofficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1445, 623);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btnAdManager);
            this.Controls.Add(this.btnUserManagerToggle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "BackofficeManager";
            this.Text = "BackofficeUserManager";
            this.Load += new System.EventHandler(this.BackofficeUserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUserManagerToggle;
        private System.Windows.Forms.Button btnAdManager;
        private System.Windows.Forms.Panel MainPanel;
    }
}