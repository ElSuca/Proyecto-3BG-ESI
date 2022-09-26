namespace Proyecto
{
    partial class FormLanguageMenu
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
            this.btnApply = new System.Windows.Forms.Button();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApply.Location = new System.Drawing.Point(21, 73);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(121, 26);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ComboBoxLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.ComboBoxLanguage.Location = new System.Drawing.Point(21, 27);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxLanguage.TabIndex = 4;
            // 
            // FormLanguageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(161, 129);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.ComboBoxLanguage);
            this.Name = "FormLanguageMenu";
            this.Text = "FormLanguageMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
    }
}