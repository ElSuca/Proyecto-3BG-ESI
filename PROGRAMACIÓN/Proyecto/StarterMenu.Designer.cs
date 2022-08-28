namespace Proyecto
{
    partial class StarterMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBackOffice = new System.Windows.Forms.Button();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "App test";
            // 
            // BtnBackOffice
            // 
            this.BtnBackOffice.Location = new System.Drawing.Point(32, 185);
            this.BtnBackOffice.Name = "BtnBackOffice";
            this.BtnBackOffice.Size = new System.Drawing.Size(274, 23);
            this.BtnBackOffice.TabIndex = 6;
            this.BtnBackOffice.Text = "Back Office";
            this.BtnBackOffice.UseVisualStyleBackColor = true;
            this.BtnBackOffice.Click += new System.EventHandler(this.BtnBackOffice_Click);
            // 
            // btnLoggin
            // 
            this.btnLoggin.Location = new System.Drawing.Point(32, 156);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(274, 23);
            this.btnLoggin.TabIndex = 5;
            this.btnLoggin.Text = "Log in";
            this.btnLoggin.UseVisualStyleBackColor = true;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(32, 127);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(274, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // StarterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBackOffice);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.btnRegister);
            this.Name = "StarterMenu";
            this.Size = new System.Drawing.Size(335, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBackOffice;
        private System.Windows.Forms.Button btnLoggin;
        private System.Windows.Forms.Button btnRegister;
    }
}
