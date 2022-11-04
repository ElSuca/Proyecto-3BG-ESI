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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackOfficeAdManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAddAd = new System.Windows.Forms.Button();
            this.txtAdId = new System.Windows.Forms.TextBox();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdModify = new System.Windows.Forms.Button();
            this.txtAdPath = new System.Windows.Forms.TextBox();
            this.txtAdName = new System.Windows.Forms.TextBox();
            this.btnMoveBanner = new System.Windows.Forms.Button();
            this.pictureBoxPreVisualization = new System.Windows.Forms.PictureBox();
            this.lbAdId = new System.Windows.Forms.Label();
            this.lbAdName = new System.Windows.Forms.Label();
            this.lbAdCategory = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pictureBoxBtnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreVisualization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddAd
            // 
            this.BtnAddAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.BtnAddAd, "BtnAddAd");
            this.BtnAddAd.Name = "BtnAddAd";
            this.BtnAddAd.UseVisualStyleBackColor = false;
            this.BtnAddAd.Click += new System.EventHandler(this.BtnAddAd_Click);
            // 
            // txtAdId
            // 
            this.txtAdId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtAdId.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtAdId, "txtAdId");
            this.txtAdId.Name = "txtAdId";
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtAddCategory.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtAddCategory, "txtAddCategory");
            this.txtAddCategory.Name = "txtAddCategory";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid1.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.dataGrid1, "dataGrid1");
            this.dataGrid1.Name = "dataGrid1";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdModify
            // 
            this.btnAdModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnAdModify.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.btnAdModify, "btnAdModify");
            this.btnAdModify.Name = "btnAdModify";
            this.btnAdModify.UseVisualStyleBackColor = false;
            this.btnAdModify.Click += new System.EventHandler(this.btnAdModify_Click);
            // 
            // txtAdPath
            // 
            this.txtAdPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtAdPath.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtAdPath, "txtAdPath");
            this.txtAdPath.Name = "txtAdPath";
            // 
            // txtAdName
            // 
            this.txtAdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtAdName.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtAdName, "txtAdName");
            this.txtAdName.Name = "txtAdName";
            // 
            // btnMoveBanner
            // 
            this.btnMoveBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.btnMoveBanner, "btnMoveBanner");
            this.btnMoveBanner.Name = "btnMoveBanner";
            this.btnMoveBanner.UseVisualStyleBackColor = false;
            this.btnMoveBanner.Click += new System.EventHandler(this.btnMoveBanner_Click);
            // 
            // pictureBoxPreVisualization
            // 
            resources.ApplyResources(this.pictureBoxPreVisualization, "pictureBoxPreVisualization");
            this.pictureBoxPreVisualization.Name = "pictureBoxPreVisualization";
            this.pictureBoxPreVisualization.TabStop = false;
            // 
            // lbAdId
            // 
            resources.ApplyResources(this.lbAdId, "lbAdId");
            this.lbAdId.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAdId.Name = "lbAdId";
            // 
            // lbAdName
            // 
            resources.ApplyResources(this.lbAdName, "lbAdName");
            this.lbAdName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAdName.Name = "lbAdName";
            // 
            // lbAdCategory
            // 
            resources.ApplyResources(this.lbAdCategory, "lbAdCategory");
            this.lbAdCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAdCategory.Name = "lbAdCategory";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnAddCategory, "btnAddCategory");
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.comboBoxCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            resources.GetString("comboBoxCategory.Items"),
            resources.GetString("comboBoxCategory.Items1"),
            resources.GetString("comboBoxCategory.Items2")});
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // pictureBoxBtnRefresh
            // 
            resources.ApplyResources(this.pictureBoxBtnRefresh, "pictureBoxBtnRefresh");
            this.pictureBoxBtnRefresh.Name = "pictureBoxBtnRefresh";
            this.pictureBoxBtnRefresh.TabStop = false;
            this.pictureBoxBtnRefresh.Click += new System.EventHandler(this.pictureBoxBtnRefresh_Click);
            // 
            // BackOfficeAdManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.pictureBoxBtnRefresh);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lbAdCategory);
            this.Controls.Add(this.lbAdName);
            this.Controls.Add(this.lbAdId);
            this.Controls.Add(this.pictureBoxPreVisualization);
            this.Controls.Add(this.btnMoveBanner);
            this.Controls.Add(this.txtAdName);
            this.Controls.Add(this.txtAdPath);
            this.Controls.Add(this.btnAdModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAddCategory);
            this.Controls.Add(this.txtAdId);
            this.Controls.Add(this.BtnAddAd);
            this.Controls.Add(this.dataGrid1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "BackOfficeAdManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreVisualization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAd;
        private System.Windows.Forms.TextBox txtAdId;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdModify;
        private System.Windows.Forms.TextBox txtAdPath;
        private System.Windows.Forms.TextBox txtAdName;
        private System.Windows.Forms.Button btnMoveBanner;
        private System.Windows.Forms.PictureBox pictureBoxPreVisualization;
        private System.Windows.Forms.Label lbAdId;
        private System.Windows.Forms.Label lbAdName;
        private System.Windows.Forms.Label lbAdCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox pictureBoxBtnRefresh;
    }
}
