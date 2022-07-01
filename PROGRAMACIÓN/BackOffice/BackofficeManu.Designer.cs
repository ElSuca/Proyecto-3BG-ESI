namespace Proyecto
{
    partial class BackofficeMenu
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnPublishManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddUser.Location = new System.Drawing.Point(79, 119);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(147, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "AdministrarUsuario";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnPublishManager
            // 
            this.btnPublishManager.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPublishManager.Location = new System.Drawing.Point(79, 90);
            this.btnPublishManager.Name = "btnPublishManager";
            this.btnPublishManager.Size = new System.Drawing.Size(147, 23);
            this.btnPublishManager.TabIndex = 1;
            this.btnPublishManager.Text = "Administrat Publicidad";
            this.btnPublishManager.UseVisualStyleBackColor = false;
            this.btnPublishManager.Click += new System.EventHandler(this.btnPublishManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 44);
            this.label1.TabIndex = 36;
            this.label1.Text = "Back Office";
            // 
            // BackofficeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(315, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPublishManager);
            this.Controls.Add(this.btnAddUser);
            this.Name = "BackofficeMenu";
            this.Text = "Backoffice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnPublishManager;
        private System.Windows.Forms.Label label1;
    }
}