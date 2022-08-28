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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddAd
            // 
            this.BtnAddAd.Location = new System.Drawing.Point(115, 167);
            this.BtnAddAd.Name = "BtnAddAd";
            this.BtnAddAd.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAd.TabIndex = 0;
            this.BtnAddAd.Text = "Add Ad";
            this.BtnAddAd.UseVisualStyleBackColor = true;
            this.BtnAddAd.Click += new System.EventHandler(this.BtnAddAd_Click);
            // 
            // txtAdPath
            // 
            this.txtAdPath.Location = new System.Drawing.Point(104, 141);
            this.txtAdPath.Name = "txtAdPath";
            this.txtAdPath.Size = new System.Drawing.Size(100, 20);
            this.txtAdPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AdId";
            // 
            // txtAdId
            // 
            this.txtAdId.Location = new System.Drawing.Point(104, 114);
            this.txtAdId.Name = "txtAdId";
            this.txtAdId.Size = new System.Drawing.Size(100, 20);
            this.txtAdId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad Category";
            // 
            // txtAdCategory
            // 
            this.txtAdCategory.Location = new System.Drawing.Point(104, 88);
            this.txtAdCategory.Name = "txtAdCategory";
            this.txtAdCategory.Size = new System.Drawing.Size(100, 20);
            this.txtAdCategory.TabIndex = 6;
            // 
            // BackOfficeAdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAdCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdPath);
            this.Controls.Add(this.BtnAddAd);
            this.Name = "BackOfficeAdManager";
            this.Size = new System.Drawing.Size(318, 241);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAd;
        private System.Windows.Forms.TextBox txtAdPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdCategory;
    }
}
