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
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(26, 74);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(147, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "AdministrarUsuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnPublishManager
            // 
            this.btnPublishManager.Location = new System.Drawing.Point(26, 45);
            this.btnPublishManager.Name = "btnPublishManager";
            this.btnPublishManager.Size = new System.Drawing.Size(147, 23);
            this.btnPublishManager.TabIndex = 1;
            this.btnPublishManager.Text = "Administrat Publicidad";
            this.btnPublishManager.UseVisualStyleBackColor = true;
            this.btnPublishManager.Click += new System.EventHandler(this.btnPublishManager_Click);
            // 
            // Backoffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 142);
            this.Controls.Add(this.btnPublishManager);
            this.Controls.Add(this.btnAddUser);
            this.Name = "Backoffice";
            this.Text = "Backoffice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnPublishManager;
    }
}