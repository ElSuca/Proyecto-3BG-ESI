namespace CapaGrafica.IniciosSeccion
{
    partial class FormLogginf
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
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(10, 43);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(69, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(10, 12);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 13);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(69, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // btnLoggin
            // 
            this.btnLoggin.Location = new System.Drawing.Point(80, 69);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(75, 23);
            this.btnLoggin.TabIndex = 5;
            this.btnLoggin.Text = "Accept";
            this.btnLoggin.UseVisualStyleBackColor = true;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // FormLogginf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 116);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLoggin);
            this.Name = "FormLogginf";
            this.Text = "FormLogginf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLoggin;
    }
}