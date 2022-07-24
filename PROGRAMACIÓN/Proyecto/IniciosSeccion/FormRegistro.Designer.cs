namespace Proyecto.IniciosSeccion
{
    partial class FormRegistro
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
            this.txtUserNameRegister = new System.Windows.Forms.TextBox();
            this.txtApellidoRegister = new System.Windows.Forms.TextBox();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.txtTelefonoRegister = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserNameRegister.Location = new System.Drawing.Point(78, 74);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameRegister.TabIndex = 1;
            // 
            // txtApellidoRegister
            // 
            this.txtApellidoRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApellidoRegister.Location = new System.Drawing.Point(78, 100);
            this.txtApellidoRegister.Name = "txtApellidoRegister";
            this.txtApellidoRegister.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoRegister.TabIndex = 2;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmailRegister.Location = new System.Drawing.Point(78, 126);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(100, 20);
            this.txtEmailRegister.TabIndex = 3;
            // 
            // txtTelefonoRegister
            // 
            this.txtTelefonoRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefonoRegister.Location = new System.Drawing.Point(78, 152);
            this.txtTelefonoRegister.Name = "txtTelefonoRegister";
            this.txtTelefonoRegister.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoRegister.TabIndex = 4;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(19, 77);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(19, 103);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(53, 13);
            this.lbLastname.TabIndex = 8;
            this.lbLastname.Text = "Lastname";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(36, 129);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 13);
            this.lbMail.TabIndex = 9;
            this.lbMail.Text = "E-Mail";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(28, 155);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(44, 13);
            this.lbNumber.TabIndex = 10;
            this.lbNumber.Text = "Number";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegister.Location = new System.Drawing.Point(78, 209);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(19, 181);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(78, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Register";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(224, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtTelefonoRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.txtApellidoRegister);
            this.Controls.Add(this.txtUserNameRegister);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserNameRegister;
        private System.Windows.Forms.TextBox txtApellidoRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.TextBox txtTelefonoRegister;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
    }
}