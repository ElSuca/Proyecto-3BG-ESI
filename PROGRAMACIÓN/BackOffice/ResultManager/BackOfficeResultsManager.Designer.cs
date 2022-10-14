namespace BackOffice
{
    partial class BackOfficeResultsManager
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
            this.Panel = new System.Windows.Forms.Panel();
            this.btnEventManager = new System.Windows.Forms.Button();
            this.btnAsociation = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(205, 8);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1490, 785);
            this.Panel.TabIndex = 46;
            // 
            // btnEventManager
            // 
            this.btnEventManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnEventManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventManager.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEventManager.Location = new System.Drawing.Point(3, 25);
            this.btnEventManager.Name = "btnEventManager";
            this.btnEventManager.Size = new System.Drawing.Size(196, 29);
            this.btnEventManager.TabIndex = 47;
            this.btnEventManager.Text = "Event Manager";
            this.btnEventManager.UseVisualStyleBackColor = false;
            this.btnEventManager.Click += new System.EventHandler(this.btnEventManager_Click);
            // 
            // btnAsociation
            // 
            this.btnAsociation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnAsociation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAsociation.Location = new System.Drawing.Point(3, 60);
            this.btnAsociation.Name = "btnAsociation";
            this.btnAsociation.Size = new System.Drawing.Size(196, 28);
            this.btnAsociation.TabIndex = 48;
            this.btnAsociation.Text = "Asociation Manager";
            this.btnAsociation.UseVisualStyleBackColor = false;
            this.btnAsociation.Click += new System.EventHandler(this.btnAsociation_Click);
            // 
            // btnTeam
            // 
            this.btnTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeam.Location = new System.Drawing.Point(3, 94);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(196, 28);
            this.btnTeam.TabIndex = 49;
            this.btnTeam.Text = "Team Manager";
            this.btnTeam.UseVisualStyleBackColor = false;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // BackOfficeResultsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.btnTeam);
            this.Controls.Add(this.btnAsociation);
            this.Controls.Add(this.btnEventManager);
            this.Controls.Add(this.Panel);
            this.Name = "BackOfficeResultsManager";
            this.Size = new System.Drawing.Size(1744, 810);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnEventManager;
        private System.Windows.Forms.Button btnAsociation;
        private System.Windows.Forms.Button btnTeam;
    }
}
