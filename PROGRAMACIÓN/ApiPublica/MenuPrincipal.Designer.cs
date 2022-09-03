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
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBusquedaJugador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaEvento = new System.Windows.Forms.TextBox();
            this.btnBusquedaJugador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BannerPic
            // 
            this.BannerPic.Location = new System.Drawing.Point(123, 27);
            this.BannerPic.Name = "BannerPic";
            this.BannerPic.Size = new System.Drawing.Size(717, 90);
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(909, 152);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(24, 23);
            this.btnBusqueda.TabIndex = 5;
            this.btnBusqueda.Text = "🔎";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Eventos...";
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
            this.txtBusquedaJugador.Location = new System.Drawing.Point(402, 154);
            this.txtBusquedaJugador.Name = "txtBusquedaJugador";
            this.txtBusquedaJugador.Size = new System.Drawing.Size(184, 20);
            this.txtBusquedaJugador.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar Jugadores...";
            // 
            // txtBusquedaEvento
            // 
            this.txtBusquedaEvento.Location = new System.Drawing.Point(719, 154);
            this.txtBusquedaEvento.Name = "txtBusquedaEvento";
            this.txtBusquedaEvento.Size = new System.Drawing.Size(184, 20);
            this.txtBusquedaEvento.TabIndex = 10;
            // 
            // btnBusquedaJugador
            // 
            this.btnBusquedaJugador.Location = new System.Drawing.Point(592, 152);
            this.btnBusquedaJugador.Name = "btnBusquedaJugador";
            this.btnBusquedaJugador.Size = new System.Drawing.Size(24, 23);
            this.btnBusquedaJugador.TabIndex = 11;
            this.btnBusquedaJugador.Text = "🔎";
            this.btnBusquedaJugador.UseVisualStyleBackColor = true;
            this.btnBusquedaJugador.Click += new System.EventHandler(this.btnBusquedaJugador_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 638);
            this.Controls.Add(this.btnBusquedaJugador);
            this.Controls.Add(this.txtBusquedaEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusquedaJugador);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BannerPic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BannerPic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserInformationMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBusquedaJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusquedaEvento;
        private System.Windows.Forms.Button btnBusquedaJugador;
    }
}