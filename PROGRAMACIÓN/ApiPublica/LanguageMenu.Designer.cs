namespace Proyecto
{
    partial class LanguageMenu
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
            this.checkBoxSpanish = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglish = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxSpanish
            // 
            this.checkBoxSpanish.AutoSize = true;
            this.checkBoxSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpanish.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxSpanish.Location = new System.Drawing.Point(182, 140);
            this.checkBoxSpanish.Name = "checkBoxSpanish";
            this.checkBoxSpanish.Size = new System.Drawing.Size(138, 35);
            this.checkBoxSpanish.TabIndex = 8;
            this.checkBoxSpanish.Text = "Español";
            this.checkBoxSpanish.UseVisualStyleBackColor = true;
            this.checkBoxSpanish.CheckedChanged += new System.EventHandler(this.checkBoxSpanish_CheckedChanged);
            this.checkBoxSpanish.CheckStateChanged += new System.EventHandler(this.checkBoxSpanish_CheckStateChanged);
            // 
            // checkBoxEnglish
            // 
            this.checkBoxEnglish.AutoSize = true;
            this.checkBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnglish.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxEnglish.Location = new System.Drawing.Point(411, 140);
            this.checkBoxEnglish.Name = "checkBoxEnglish";
            this.checkBoxEnglish.Size = new System.Drawing.Size(129, 35);
            this.checkBoxEnglish.TabIndex = 9;
            this.checkBoxEnglish.Text = "English";
            this.checkBoxEnglish.UseVisualStyleBackColor = true;
            this.checkBoxEnglish.CheckedChanged += new System.EventHandler(this.checkBoxEnglish_CheckedChanged);
            // 
            // LanguageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.checkBoxEnglish);
            this.Controls.Add(this.checkBoxSpanish);
            this.Name = "LanguageMenu";
            this.Size = new System.Drawing.Size(826, 328);
            this.Load += new System.EventHandler(this.LanguageMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxSpanish;
        private System.Windows.Forms.CheckBox checkBoxEnglish;
    }
}
