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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Lblanguaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 46);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(289, 39);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Project Olympus";
            // 
            // btnLoggin
            // 
            this.btnLoggin.Location = new System.Drawing.Point(32, 173);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(274, 23);
            this.btnLoggin.TabIndex = 5;
            this.btnLoggin.Text = "Log in";
            this.btnLoggin.UseVisualStyleBackColor = true;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(32, 144);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(274, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Lblanguaje
            // 
            this.Lblanguaje.AutoSize = true;
            this.Lblanguaje.Location = new System.Drawing.Point(15, 11);
            this.Lblanguaje.Name = "Lblanguaje";
            this.Lblanguaje.Size = new System.Drawing.Size(51, 13);
            this.Lblanguaje.TabIndex = 8;
            this.Lblanguaje.Text = "Languaje";
            this.Lblanguaje.Click += new System.EventHandler(this.Lblanguaje_Click);
            // 
            // StarterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lblanguaje);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.btnRegister);
            this.Name = "StarterMenu";
            this.Size = new System.Drawing.Size(335, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnLoggin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label Lblanguaje;
    }
}
