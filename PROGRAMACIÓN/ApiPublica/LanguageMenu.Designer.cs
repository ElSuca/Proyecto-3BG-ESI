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
            this.btnApply = new System.Windows.Forms.Button();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.checkBoxSpanish = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglish = new System.Windows.Forms.CheckBox();
            this.lbBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApply.Location = new System.Drawing.Point(10, 200);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(121, 26);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ComboBoxLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.ComboBoxLanguage.Location = new System.Drawing.Point(10, 154);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxLanguage.TabIndex = 6;
            // 
            // checkBoxSpanish
            // 
            this.checkBoxSpanish.AutoSize = true;
            this.checkBoxSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpanish.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxSpanish.Location = new System.Drawing.Point(224, 180);
            this.checkBoxSpanish.Name = "checkBoxSpanish";
            this.checkBoxSpanish.Size = new System.Drawing.Size(138, 35);
            this.checkBoxSpanish.TabIndex = 8;
            this.checkBoxSpanish.Text = "Español";
            this.checkBoxSpanish.UseVisualStyleBackColor = true;
            this.checkBoxSpanish.CheckedChanged += new System.EventHandler(this.checkBoxSpanish_CheckedChanged);
            // 
            // checkBoxEnglish
            // 
            this.checkBoxEnglish.AutoSize = true;
            this.checkBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnglish.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxEnglish.Location = new System.Drawing.Point(442, 180);
            this.checkBoxEnglish.Name = "checkBoxEnglish";
            this.checkBoxEnglish.Size = new System.Drawing.Size(129, 35);
            this.checkBoxEnglish.TabIndex = 9;
            this.checkBoxEnglish.Text = "English";
            this.checkBoxEnglish.UseVisualStyleBackColor = true;
            this.checkBoxEnglish.CheckedChanged += new System.EventHandler(this.checkBoxEnglish_CheckedChanged);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBack.Location = new System.Drawing.Point(5, 16);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(64, 20);
            this.lbBack.TabIndex = 10;
            this.lbBack.Text = "Return";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // LanguageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.checkBoxEnglish);
            this.Controls.Add(this.checkBoxSpanish);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.ComboBoxLanguage);
            this.Name = "LanguageMenu";
            this.Size = new System.Drawing.Size(826, 328);
            this.Load += new System.EventHandler(this.LanguageMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.CheckBox checkBoxSpanish;
        private System.Windows.Forms.CheckBox checkBoxEnglish;
        private System.Windows.Forms.Label lbBack;
    }
}
