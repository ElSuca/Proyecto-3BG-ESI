namespace Proyecto.IniciosSeccion
{
    partial class RegisterMenu
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName2Register = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtPhoneRegister = new System.Windows.Forms.TextBox();
            this.txtApellidoRegister = new System.Windows.Forms.TextBox();
            this.txtUserNameRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Real Name";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNameRegister.Location = new System.Drawing.Point(109, 103);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtNameRegister.TabIndex = 36;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmailRegister.Location = new System.Drawing.Point(110, 179);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(100, 20);
            this.txtEmailRegister.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Second Lastname ";
            // 
            // txtLastName2Register
            // 
            this.txtLastName2Register.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastName2Register.Location = new System.Drawing.Point(110, 153);
            this.txtLastName2Register.Name = "txtLastName2Register";
            this.txtLastName2Register.Size = new System.Drawing.Size(100, 20);
            this.txtLastName2Register.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Register";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(110, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 31;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(53, 234);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 30;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegister.Location = new System.Drawing.Point(71, 257);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(28, 208);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(78, 13);
            this.lbNumber.TabIndex = 28;
            this.lbNumber.Text = "Phone Number";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(70, 182);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 13);
            this.lbMail.TabIndex = 27;
            this.lbMail.Text = "E-Mail";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(51, 130);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(53, 13);
            this.lbLastname.TabIndex = 26;
            this.lbLastname.Text = "Lastname";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(51, 80);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 25;
            this.lbUsername.Text = "Username";
            // 
            // txtPhoneRegister
            // 
            this.txtPhoneRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPhoneRegister.Location = new System.Drawing.Point(110, 205);
            this.txtPhoneRegister.Name = "txtPhoneRegister";
            this.txtPhoneRegister.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneRegister.TabIndex = 24;
            // 
            // txtApellidoRegister
            // 
            this.txtApellidoRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApellidoRegister.Location = new System.Drawing.Point(110, 127);
            this.txtApellidoRegister.Name = "txtApellidoRegister";
            this.txtApellidoRegister.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoRegister.TabIndex = 23;
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserNameRegister.Location = new System.Drawing.Point(110, 77);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameRegister.TabIndex = 22;
            // 
            // RegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName2Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtPhoneRegister);
            this.Controls.Add(this.txtApellidoRegister);
            this.Controls.Add(this.txtUserNameRegister);
            this.Name = "RegisterMenu";
            this.Size = new System.Drawing.Size(231, 310);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName2Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtPhoneRegister;
        private System.Windows.Forms.TextBox txtApellidoRegister;
        private System.Windows.Forms.TextBox txtUserNameRegister;
    }
}
