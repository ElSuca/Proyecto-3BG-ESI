namespace BackOffice
{
    partial class BackOfficeUserManager
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRole = new System.Windows.Forms.Label();
            this.ComboBoxRole = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.lbLastName2 = new System.Windows.Forms.Label();
            this.txtLastName2Register = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.dgrid1 = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTelefonoRegister = new System.Windows.Forms.TextBox();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.txtLastName1Register = new System.Windows.Forms.TextBox();
            this.txtUserNameRegister = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(74, 223);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(29, 13);
            this.lbRole.TabIndex = 65;
            this.lbRole.Text = "Role";
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.Items.AddRange(new object[] {
            "User",
            "Premiun",
            "Admin"});
            this.ComboBoxRole.Location = new System.Drawing.Point(109, 223);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(176, 21);
            this.ComboBoxRole.TabIndex = 64;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(43, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 13);
            this.lbName.TabIndex = 63;
            this.lbName.Text = "Real Name";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNameRegister.Location = new System.Drawing.Point(109, 67);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(176, 20);
            this.txtNameRegister.TabIndex = 62;
            // 
            // lbLastName2
            // 
            this.lbLastName2.AutoSize = true;
            this.lbLastName2.Location = new System.Drawing.Point(10, 123);
            this.lbLastName2.Name = "lbLastName2";
            this.lbLastName2.Size = new System.Drawing.Size(93, 13);
            this.lbLastName2.TabIndex = 61;
            this.lbLastName2.Text = "Second Lastname";
            // 
            // txtLastName2Register
            // 
            this.txtLastName2Register.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastName2Register.Location = new System.Drawing.Point(109, 120);
            this.txtLastName2Register.Name = "txtLastName2Register";
            this.txtLastName2Register.Size = new System.Drawing.Size(176, 20);
            this.txtLastName2Register.TabIndex = 60;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(424, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(533, 250);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(102, 23);
            this.btnModify.TabIndex = 58;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(109, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 57;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(50, 172);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 56;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(641, 250);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(102, 23);
            this.btnList.TabIndex = 55;
            this.btnList.Text = "list";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click_1);
            // 
            // dgrid1
            // 
            this.dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid1.Location = new System.Drawing.Point(291, 15);
            this.dgrid1.Name = "dgrid1";
            this.dgrid1.Size = new System.Drawing.Size(670, 218);
            this.dgrid1.TabIndex = 54;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegister.Location = new System.Drawing.Point(315, 250);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 23);
            this.btnRegister.TabIndex = 53;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(27, 201);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(76, 13);
            this.lbNumber.TabIndex = 52;
            this.lbNumber.Text = "Phone number";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(67, 149);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 13);
            this.lbMail.TabIndex = 51;
            this.lbMail.Text = "E-Mail";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(48, 96);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(53, 13);
            this.lbLastname.TabIndex = 50;
            this.lbLastname.Text = "Lastname";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(48, 44);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 49;
            this.lbUsername.Text = "Username";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(85, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 48;
            this.lbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Location = new System.Drawing.Point(109, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 47;
            // 
            // txtTelefonoRegister
            // 
            this.txtTelefonoRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefonoRegister.Location = new System.Drawing.Point(109, 198);
            this.txtTelefonoRegister.Name = "txtTelefonoRegister";
            this.txtTelefonoRegister.Size = new System.Drawing.Size(176, 20);
            this.txtTelefonoRegister.TabIndex = 46;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmailRegister.Location = new System.Drawing.Point(109, 146);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(176, 20);
            this.txtEmailRegister.TabIndex = 45;
            // 
            // txtLastName1Register
            // 
            this.txtLastName1Register.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastName1Register.Location = new System.Drawing.Point(109, 93);
            this.txtLastName1Register.Name = "txtLastName1Register";
            this.txtLastName1Register.Size = new System.Drawing.Size(176, 20);
            this.txtLastName1Register.TabIndex = 44;
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserNameRegister.Location = new System.Drawing.Point(109, 41);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(176, 20);
            this.txtUserNameRegister.TabIndex = 43;
            // 
            // BackOfficeUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.lbLastName2);
            this.Controls.Add(this.txtLastName2Register);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dgrid1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTelefonoRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.txtLastName1Register);
            this.Controls.Add(this.txtUserNameRegister);
            this.Name = "BackOfficeUserManager";
            this.Size = new System.Drawing.Size(987, 288);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox ComboBoxRole;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.Label lbLastName2;
        private System.Windows.Forms.TextBox txtLastName2Register;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgrid1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTelefonoRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.TextBox txtLastName1Register;
        private System.Windows.Forms.TextBox txtUserNameRegister;
    }
}
