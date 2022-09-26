namespace Proyecto
{
    partial class MenuPrincipal
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
            this.BannerPic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBusquedaJugador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaEvento = new System.Windows.Forms.TextBox();
            this.btnBusquedaJugador = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelMenuSearch = new System.Windows.Forms.Panel();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenuSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // BannerPic
            // 
            this.BannerPic.Location = new System.Drawing.Point(54, 27);
            this.BannerPic.Name = "BannerPic";
            this.BannerPic.Size = new System.Drawing.Size(1017, 90);
            this.BannerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BannerPic.TabIndex = 0;
            this.BannerPic.TabStop = false;
            this.BannerPic.Click += new System.EventHandler(this.BannerPic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserInformationMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // UserInformationMenuItem
            // 
            this.UserInformationMenuItem.Name = "UserInformationMenuItem";
            this.UserInformationMenuItem.Size = new System.Drawing.Size(157, 22);
            this.UserInformationMenuItem.Text = "My information";
            this.UserInformationMenuItem.Click += new System.EventHandler(this.UserInformationMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 423);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(218, 11);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(24, 23);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "🔎";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(36, 151);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "< Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBusquedaJugador
            // 
            this.txtBusquedaJugador.Location = new System.Drawing.Point(719, 128);
            this.txtBusquedaJugador.Name = "txtBusquedaJugador";
            this.txtBusquedaJugador.Size = new System.Drawing.Size(184, 20);
            this.txtBusquedaJugador.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar Jugadores...";
            // 
            // txtBusquedaEvento
            // 
            this.txtBusquedaEvento.Location = new System.Drawing.Point(56, 13);
            this.txtBusquedaEvento.Name = "txtBusquedaEvento";
            this.txtBusquedaEvento.Size = new System.Drawing.Size(156, 20);
            this.txtBusquedaEvento.TabIndex = 10;
            // 
            // btnBusquedaJugador
            // 
            this.btnBusquedaJugador.Location = new System.Drawing.Point(909, 128);
            this.btnBusquedaJugador.Name = "btnBusquedaJugador";
            this.btnBusquedaJugador.Size = new System.Drawing.Size(24, 23);
            this.btnBusquedaJugador.TabIndex = 11;
            this.btnBusquedaJugador.Text = "🔎";
            this.btnBusquedaJugador.UseVisualStyleBackColor = true;
            this.btnBusquedaJugador.Click += new System.EventHandler(this.btnBusquedaJugador_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(151, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 24);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search Event";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelMenuSearch
            // 
            this.panelMenuSearch.Controls.Add(this.btnSearchCategory);
            this.panelMenuSearch.Controls.Add(this.txtCategory);
            this.panelMenuSearch.Controls.Add(this.lbCategory);
            this.panelMenuSearch.Controls.Add(this.txtBusquedaEvento);
            this.panelMenuSearch.Controls.Add(this.lbName);
            this.panelMenuSearch.Controls.Add(this.btnSearchName);
            this.panelMenuSearch.Location = new System.Drawing.Point(151, 174);
            this.panelMenuSearch.Name = "panelMenuSearch";
            this.panelMenuSearch.Size = new System.Drawing.Size(264, 85);
            this.panelMenuSearch.TabIndex = 13;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(218, 43);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(24, 23);
            this.btnSearchCategory.TabIndex = 13;
            this.btnSearchCategory.Text = "🔎";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(56, 45);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(156, 20);
            this.txtCategory.TabIndex = 12;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(1, 48);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(49, 13);
            this.lbCategory.TabIndex = 11;
            this.lbCategory.Text = "Category";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1104, 638);
            this.Controls.Add(this.panelMenuSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.BannerPic);
            this.Controls.Add(this.btnBusquedaJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusquedaJugador);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenuSearch.ResumeLayout(false);
            this.panelMenuSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BannerPic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserInformationMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBusquedaJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusquedaEvento;
        private System.Windows.Forms.Button btnBusquedaJugador;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelMenuSearch;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lbCategory;
    }
}