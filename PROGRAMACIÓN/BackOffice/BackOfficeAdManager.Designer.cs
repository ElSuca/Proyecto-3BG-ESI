namespace BackOffice
{
    partial class BackOfficeAdManager
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
            this.BtnAddAd = new System.Windows.Forms.Button();
            this.txtAdPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddAd
            // 
            this.BtnAddAd.Location = new System.Drawing.Point(449, 273);
            this.BtnAddAd.Name = "BtnAddAd";
            this.BtnAddAd.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAd.TabIndex = 0;
            this.BtnAddAd.Text = "Add Ad";
            this.BtnAddAd.UseVisualStyleBackColor = true;
            this.BtnAddAd.Click += new System.EventHandler(this.BtnAddAd_Click);
            // 
            // txtAdPath
            // 
            this.txtAdPath.Location = new System.Drawing.Point(436, 247);
            this.txtAdPath.Name = "txtAdPath";
            this.txtAdPath.Size = new System.Drawing.Size(100, 20);
            this.txtAdPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AdId";
            // 
            // txtAdId
            // 
            this.txtAdId.Location = new System.Drawing.Point(436, 224);
            this.txtAdId.Name = "txtAdId";
            this.txtAdId.Size = new System.Drawing.Size(100, 20);
            this.txtAdId.TabIndex = 4;
            // 
            // BackOfficeAdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAdId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdPath);
            this.Controls.Add(this.BtnAddAd);
            this.Name = "BackOfficeAdManager";
            this.Size = new System.Drawing.Size(1458, 667);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAd;
        private System.Windows.Forms.TextBox txtAdPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdId;
    }
}
