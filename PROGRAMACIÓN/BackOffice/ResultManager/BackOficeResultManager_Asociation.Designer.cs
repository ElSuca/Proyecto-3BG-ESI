namespace BackOffice.ResultManager
{
    partial class BackOficeResultManager_Asociation
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
            this.btnRegisterAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsocID = new System.Windows.Forms.TextBox();
            this.txtAsocName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAsociationStatus = new System.Windows.Forms.MaskedTextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterAcc
            // 
            this.btnRegisterAcc.Location = new System.Drawing.Point(57, 262);
            this.btnRegisterAcc.Name = "btnRegisterAcc";
            this.btnRegisterAcc.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterAcc.TabIndex = 0;
            this.btnRegisterAcc.Text = "Register";
            this.btnRegisterAcc.UseVisualStyleBackColor = true;
            this.btnRegisterAcc.Click += new System.EventHandler(this.btnRegisterAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtAsocID
            // 
            this.txtAsocID.Location = new System.Drawing.Point(57, 56);
            this.txtAsocID.Name = "txtAsocID";
            this.txtAsocID.Size = new System.Drawing.Size(100, 20);
            this.txtAsocID.TabIndex = 2;
            // 
            // txtAsocName
            // 
            this.txtAsocName.Location = new System.Drawing.Point(57, 82);
            this.txtAsocName.Name = "txtAsocName";
            this.txtAsocName.Size = new System.Drawing.Size(100, 20);
            this.txtAsocName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // TxtAsociationStatus
            // 
            this.TxtAsociationStatus.Location = new System.Drawing.Point(57, 108);
            this.TxtAsociationStatus.Name = "TxtAsociationStatus";
            this.TxtAsociationStatus.Size = new System.Drawing.Size(100, 20);
            this.TxtAsociationStatus.TabIndex = 7;
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(202, 56);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(399, 139);
            this.dataGrid1.TabIndex = 9;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(138, 262);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // BackOficeResultManager_Asociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.TxtAsociationStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAsocName);
            this.Controls.Add(this.txtAsocID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterAcc);
            this.Name = "BackOficeResultManager_Asociation";
            this.Size = new System.Drawing.Size(858, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsocID;
        private System.Windows.Forms.TextBox txtAsocName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtAsociationStatus;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnList;
    }
}
