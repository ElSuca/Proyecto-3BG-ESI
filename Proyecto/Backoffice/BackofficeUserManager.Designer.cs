namespace Proyecto.Backoffice
{
    partial class BackofficeUserManager
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
            this.txtApellidoRegister = new System.Windows.Forms.TextBox();
            this.txtUserNameRegister = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 30;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(27, 136);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 29;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(117, 196);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 28;
            this.btnList.Text = "list";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgrid1
            // 
            this.dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid1.Location = new System.Drawing.Point(213, 30);
            this.dgrid1.Name = "dgrid1";
            this.dgrid1.Size = new System.Drawing.Size(240, 218);
            this.dgrid1.TabIndex = 27;
            this.dgrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid1_CellContentClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(30, 196);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(44, 160);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(44, 13);
            this.lbNumber.TabIndex = 25;
            this.lbNumber.Text = "Number";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(44, 113);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 13);
            this.lbMail.TabIndex = 24;
            this.lbMail.Text = "E-Mail";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(35, 86);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(53, 13);
            this.lbLastname.TabIndex = 23;
            this.lbLastname.Text = "Lastname";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(33, 59);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 22;
            this.lbUsername.Text = "Username";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(68, 33);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 21;
            this.lbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 20;
            // 
            // txtTelefonoRegister
            // 
            this.txtTelefonoRegister.Location = new System.Drawing.Point(92, 160);
            this.txtTelefonoRegister.Name = "txtTelefonoRegister";
            this.txtTelefonoRegister.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoRegister.TabIndex = 19;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.Location = new System.Drawing.Point(92, 110);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(100, 20);
            this.txtEmailRegister.TabIndex = 18;
            // 
            // txtApellidoRegister
            // 
            this.txtApellidoRegister.Location = new System.Drawing.Point(92, 85);
            this.txtApellidoRegister.Name = "txtApellidoRegister";
            this.txtApellidoRegister.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoRegister.TabIndex = 17;
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.Location = new System.Drawing.Point(92, 56);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameRegister.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(117, 225);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 32;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(71, 254);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 33;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BackofficeUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 291);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSearch);
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
            this.Controls.Add(this.txtApellidoRegister);
            this.Controls.Add(this.txtUserNameRegister);
            this.Name = "BackofficeUserManager";
            this.Text = "BackofficeUserManager";
            this.Load += new System.EventHandler(this.BackofficeUserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtApellidoRegister;
        private System.Windows.Forms.TextBox txtUserNameRegister;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button Delete;
    }
}