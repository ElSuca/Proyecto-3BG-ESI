namespace ApiPublica
{
    partial class UserData
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNameDisplay = new System.Windows.Forms.Label();
            this.lbEmailDisplay = new System.Windows.Forms.Label();
            this.lbLastnameDisplay = new System.Windows.Forms.Label();
            this.lbPhonenumberDisplay = new System.Windows.Forms.Label();
            this.lbPasswordDisplay = new System.Windows.Forms.Label();
            this.lbRoleDisplay = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbUsernameDisplay = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastname1 = new System.Windows.Forms.TextBox();
            this.txtLastname2 = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnUpgradeAccount = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNameDisplay
            // 
            this.lbNameDisplay.AutoSize = true;
            this.lbNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNameDisplay.Location = new System.Drawing.Point(12, 78);
            this.lbNameDisplay.Name = "lbNameDisplay";
            this.lbNameDisplay.Size = new System.Drawing.Size(93, 25);
            this.lbNameDisplay.TabIndex = 0;
            this.lbNameDisplay.Text = "Nombre";
            this.lbNameDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEmailDisplay
            // 
            this.lbEmailDisplay.AutoSize = true;
            this.lbEmailDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEmailDisplay.Location = new System.Drawing.Point(12, 200);
            this.lbEmailDisplay.Name = "lbEmailDisplay";
            this.lbEmailDisplay.Size = new System.Drawing.Size(70, 25);
            this.lbEmailDisplay.TabIndex = 2;
            this.lbEmailDisplay.Text = "Email";
            // 
            // lbLastnameDisplay
            // 
            this.lbLastnameDisplay.AutoSize = true;
            this.lbLastnameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastnameDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLastnameDisplay.Location = new System.Drawing.Point(12, 138);
            this.lbLastnameDisplay.Name = "lbLastnameDisplay";
            this.lbLastnameDisplay.Size = new System.Drawing.Size(124, 25);
            this.lbLastnameDisplay.TabIndex = 5;
            this.lbLastnameDisplay.Text = "Last Name";
            // 
            // lbPhonenumberDisplay
            // 
            this.lbPhonenumberDisplay.AutoSize = true;
            this.lbPhonenumberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonenumberDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPhonenumberDisplay.Location = new System.Drawing.Point(12, 263);
            this.lbPhonenumberDisplay.Name = "lbPhonenumberDisplay";
            this.lbPhonenumberDisplay.Size = new System.Drawing.Size(167, 25);
            this.lbPhonenumberDisplay.TabIndex = 7;
            this.lbPhonenumberDisplay.Text = "Phone Number";
            // 
            // lbPasswordDisplay
            // 
            this.lbPasswordDisplay.AutoSize = true;
            this.lbPasswordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPasswordDisplay.Location = new System.Drawing.Point(12, 327);
            this.lbPasswordDisplay.Name = "lbPasswordDisplay";
            this.lbPasswordDisplay.Size = new System.Drawing.Size(114, 25);
            this.lbPasswordDisplay.TabIndex = 9;
            this.lbPasswordDisplay.Text = "Password";
            // 
            // lbRoleDisplay
            // 
            this.lbRoleDisplay.AutoSize = true;
            this.lbRoleDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoleDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRoleDisplay.Location = new System.Drawing.Point(12, 387);
            this.lbRoleDisplay.Name = "lbRoleDisplay";
            this.lbRoleDisplay.Size = new System.Drawing.Size(79, 25);
            this.lbRoleDisplay.TabIndex = 11;
            this.lbRoleDisplay.Text = "Status";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(17, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(382, 26);
            this.txtName.TabIndex = 12;
            // 
            // lbUsernameDisplay
            // 
            this.lbUsernameDisplay.AutoSize = true;
            this.lbUsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUsernameDisplay.Location = new System.Drawing.Point(12, 18);
            this.lbUsernameDisplay.Name = "lbUsernameDisplay";
            this.lbUsernameDisplay.Size = new System.Drawing.Size(118, 25);
            this.lbUsernameDisplay.TabIndex = 13;
            this.lbUsernameDisplay.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtUsername.Location = new System.Drawing.Point(17, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(382, 26);
            this.txtUsername.TabIndex = 14;
            // 
            // txtLastname1
            // 
            this.txtLastname1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtLastname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLastname1.Location = new System.Drawing.Point(17, 166);
            this.txtLastname1.Name = "txtLastname1";
            this.txtLastname1.Size = new System.Drawing.Size(181, 26);
            this.txtLastname1.TabIndex = 15;
            // 
            // txtLastname2
            // 
            this.txtLastname2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtLastname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLastname2.Location = new System.Drawing.Point(204, 166);
            this.txtLastname2.Name = "txtLastname2";
            this.txtLastname2.Size = new System.Drawing.Size(195, 26);
            this.txtLastname2.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMail.Location = new System.Drawing.Point(17, 228);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(382, 26);
            this.txtMail.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(17, 291);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(382, 26);
            this.txtPhone.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(17, 355);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(333, 26);
            this.txtPassword.TabIndex = 19;
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(17, 415);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(218, 26);
            this.txtRole.TabIndex = 20;
            this.txtRole.TextChanged += new System.EventHandler(this.textRole_TextChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveChanges.Location = new System.Drawing.Point(17, 467);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(218, 31);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(14, 446);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 18);
            this.lbMessage.TabIndex = 22;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(22)))));
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowPassword.Location = new System.Drawing.Point(356, 355);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(43, 26);
            this.btnShowPassword.TabIndex = 23;
            this.btnShowPassword.Text = " 👁";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnUpgradeAccount
            // 
            this.btnUpgradeAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnUpgradeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpgradeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgradeAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpgradeAccount.Location = new System.Drawing.Point(241, 413);
            this.btnUpgradeAccount.Name = "btnUpgradeAccount";
            this.btnUpgradeAccount.Size = new System.Drawing.Size(158, 28);
            this.btnUpgradeAccount.TabIndex = 24;
            this.btnUpgradeAccount.Text = "Upgrade Account";
            this.btnUpgradeAccount.UseVisualStyleBackColor = false;
            this.btnUpgradeAccount.Click += new System.EventHandler(this.btnUpgradeAccount_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(303, 467);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 25;
            this.btnSendMail.Text = "button1";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(448, 510);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnUpgradeAccount);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtLastname2);
            this.Controls.Add(this.txtLastname1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUsernameDisplay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbRoleDisplay);
            this.Controls.Add(this.lbPasswordDisplay);
            this.Controls.Add(this.lbPhonenumberDisplay);
            this.Controls.Add(this.lbLastnameDisplay);
            this.Controls.Add(this.lbEmailDisplay);
            this.Controls.Add(this.lbNameDisplay);
            this.Name = "UserData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameDisplay;
        private System.Windows.Forms.Label lbEmailDisplay;
        private System.Windows.Forms.Label lbLastnameDisplay;
        private System.Windows.Forms.Label lbPhonenumberDisplay;
        private System.Windows.Forms.Label lbPasswordDisplay;
        private System.Windows.Forms.Label lbRoleDisplay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbUsernameDisplay;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastname1;
        private System.Windows.Forms.TextBox txtLastname2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnUpgradeAccount;
        private System.Windows.Forms.Button btnSendMail;
    }
}

