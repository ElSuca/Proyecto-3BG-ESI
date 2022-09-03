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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdCategory = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdModify = new System.Windows.Forms.Button();
            this.txtAdPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoveBanner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddAd
            // 
            this.BtnAddAd.Location = new System.Drawing.Point(21, 211);
            this.BtnAddAd.Name = "BtnAddAd";
            this.BtnAddAd.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAd.TabIndex = 0;
            this.BtnAddAd.Text = "Add Ad";
            this.BtnAddAd.UseVisualStyleBackColor = true;
            this.BtnAddAd.Click += new System.EventHandler(this.BtnAddAd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AdId";
            // 
            // txtAdId
            // 
            this.txtAdId.Location = new System.Drawing.Point(72, 61);
            this.txtAdId.Name = "txtAdId";
            this.txtAdId.Size = new System.Drawing.Size(174, 20);
            this.txtAdId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad Category";
            // 
            // txtAdCategory
            // 
            this.txtAdCategory.Location = new System.Drawing.Point(72, 113);
            this.txtAdCategory.Name = "txtAdCategory";
            this.txtAdCategory.Size = new System.Drawing.Size(174, 20);
            this.txtAdCategory.TabIndex = 6;
            this.txtAdCategory.TextChanged += new System.EventHandler(this.txtAdCategory_TextChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(183, 211);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(292, 41);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(399, 139);
            this.dataGrid1.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdModify
            // 
            this.btnAdModify.Location = new System.Drawing.Point(102, 212);
            this.btnAdModify.Name = "btnAdModify";
            this.btnAdModify.Size = new System.Drawing.Size(75, 23);
            this.btnAdModify.TabIndex = 10;
            this.btnAdModify.Text = "Modify";
            this.btnAdModify.UseVisualStyleBackColor = true;
            this.btnAdModify.Click += new System.EventHandler(this.btnAdModify_Click);
            // 
            // txtAdPath
            // 
            this.txtAdPath.Location = new System.Drawing.Point(72, 171);
            this.txtAdPath.Name = "txtAdPath";
            this.txtAdPath.Size = new System.Drawing.Size(174, 20);
            this.txtAdPath.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad Path";
            // 
            // txtAdName
            // 
            this.txtAdName.Location = new System.Drawing.Point(72, 87);
            this.txtAdName.Name = "txtAdName";
            this.txtAdName.Size = new System.Drawing.Size(174, 20);
            this.txtAdName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "AdName";
            // 
            // btnMoveBanner
            // 
            this.btnMoveBanner.Location = new System.Drawing.Point(72, 137);
            this.btnMoveBanner.Name = "btnMoveBanner";
            this.btnMoveBanner.Size = new System.Drawing.Size(75, 23);
            this.btnMoveBanner.TabIndex = 18;
            this.btnMoveBanner.Text = "SetBanner";
            this.btnMoveBanner.UseVisualStyleBackColor = true;
            this.btnMoveBanner.Click += new System.EventHandler(this.btnMoveBanner_Click);
            // 
            // BackOfficeAdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMoveBanner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdPath);
            this.Controls.Add(this.btnAdModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtAdCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddAd);
            this.Name = "BackOfficeAdManager";
            this.Size = new System.Drawing.Size(760, 375);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdCategory;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdModify;
        private System.Windows.Forms.TextBox txtAdPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoveBanner;
    }
}
