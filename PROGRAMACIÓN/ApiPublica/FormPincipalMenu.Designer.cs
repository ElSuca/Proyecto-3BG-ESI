﻿namespace ApiPublica
{
    partial class FormPincipalMenu
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
            this.panelResult = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCompetition = new System.Windows.Forms.TextBox();
            this.txtTeam1id = new System.Windows.Forms.TextBox();
            this.txtTeam2id = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnsendinfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelDebugg = new System.Windows.Forms.Panel();
            this.txtStadium = new System.Windows.Forms.TextBox();
            this.lbStadium = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lbCompetition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDebuggButton = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.panelLowMark2 = new System.Windows.Forms.Panel();
            this.lbBtnPersonalInformation = new System.Windows.Forms.Label();
            this.panelLowMark = new System.Windows.Forms.Panel();
            this.panelMenus = new System.Windows.Forms.Panel();
            this.panelTopPage = new System.Windows.Forms.Panel();
            this.lbButtonTenis = new System.Windows.Forms.Label();
            this.lbButtonBasketball = new System.Windows.Forms.Label();
            this.lbButtonFootbal = new System.Windows.Forms.Label();
            this.lbSportListButtomMenu = new System.Windows.Forms.Label();
            this.pictureBoxBtnConfig = new System.Windows.Forms.PictureBox();
            this.panelBackgroun1 = new System.Windows.Forms.Panel();
            this.lbTeam = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.lbSport = new System.Windows.Forms.Label();
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.panelSportList = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BannerPic = new System.Windows.Forms.PictureBox();
            this.panelDebugg.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.panelTopPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnConfig)).BeginInit();
            this.panelBackgroun1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResult.Location = new System.Drawing.Point(218, 204);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(531, 495);
            this.panelResult.TabIndex = 0;
            // 
            // txtCompetition
            // 
            this.txtCompetition.Location = new System.Drawing.Point(75, 241);
            this.txtCompetition.Name = "txtCompetition";
            this.txtCompetition.Size = new System.Drawing.Size(100, 20);
            this.txtCompetition.TabIndex = 1;
            // 
            // txtTeam1id
            // 
            this.txtTeam1id.Location = new System.Drawing.Point(75, 59);
            this.txtTeam1id.Name = "txtTeam1id";
            this.txtTeam1id.Size = new System.Drawing.Size(100, 20);
            this.txtTeam1id.TabIndex = 2;
            // 
            // txtTeam2id
            // 
            this.txtTeam2id.Location = new System.Drawing.Point(75, 95);
            this.txtTeam2id.Name = "txtTeam2id";
            this.txtTeam2id.Size = new System.Drawing.Size(100, 20);
            this.txtTeam2id.TabIndex = 3;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(75, 132);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 4;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(75, 167);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(75, 204);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 6;
            // 
            // btnsendinfo
            // 
            this.btnsendinfo.Location = new System.Drawing.Point(16, 389);
            this.btnsendinfo.Name = "btnsendinfo";
            this.btnsendinfo.Size = new System.Drawing.Size(75, 23);
            this.btnsendinfo.TabIndex = 7;
            this.btnsendinfo.Text = "SendTest";
            this.btnsendinfo.UseVisualStyleBackColor = true;
            this.btnsendinfo.Click += new System.EventHandler(this.btnsendinfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(100, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelDebugg
            // 
            this.panelDebugg.Controls.Add(this.txtStadium);
            this.panelDebugg.Controls.Add(this.lbStadium);
            this.panelDebugg.Controls.Add(this.lbEndTime);
            this.panelDebugg.Controls.Add(this.txtEndTime);
            this.panelDebugg.Controls.Add(this.lbStartTime);
            this.panelDebugg.Controls.Add(this.txtStartTime);
            this.panelDebugg.Controls.Add(this.lbCompetition);
            this.panelDebugg.Controls.Add(this.label5);
            this.panelDebugg.Controls.Add(this.label4);
            this.panelDebugg.Controls.Add(this.label3);
            this.panelDebugg.Controls.Add(this.label2);
            this.panelDebugg.Controls.Add(this.label1);
            this.panelDebugg.Controls.Add(this.txtDate);
            this.panelDebugg.Controls.Add(this.btnClear);
            this.panelDebugg.Controls.Add(this.txtCompetition);
            this.panelDebugg.Controls.Add(this.btnsendinfo);
            this.panelDebugg.Controls.Add(this.txtTeam1id);
            this.panelDebugg.Controls.Add(this.txtTeam2id);
            this.panelDebugg.Controls.Add(this.txtScore2);
            this.panelDebugg.Controls.Add(this.txtScore1);
            this.panelDebugg.Location = new System.Drawing.Point(0, 334);
            this.panelDebugg.Name = "panelDebugg";
            this.panelDebugg.Size = new System.Drawing.Size(200, 429);
            this.panelDebugg.TabIndex = 9;
            this.panelDebugg.Visible = false;
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(75, 347);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(100, 20);
            this.txtStadium.TabIndex = 20;
            // 
            // lbStadium
            // 
            this.lbStadium.AutoSize = true;
            this.lbStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStadium.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStadium.Location = new System.Drawing.Point(6, 347);
            this.lbStadium.Name = "lbStadium";
            this.lbStadium.Size = new System.Drawing.Size(52, 13);
            this.lbStadium.TabIndex = 19;
            this.lbStadium.Text = "Stadium";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEndTime.Location = new System.Drawing.Point(8, 314);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(56, 13);
            this.lbEndTime.TabIndex = 18;
            this.lbEndTime.Text = "End time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(75, 311);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 17;
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStartTime.Location = new System.Drawing.Point(8, 283);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(61, 13);
            this.lbStartTime.TabIndex = 16;
            this.lbStartTime.Text = "Start time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(75, 276);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 15;
            // 
            // lbCompetition
            // 
            this.lbCompetition.AutoSize = true;
            this.lbCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompetition.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCompetition.Location = new System.Drawing.Point(-4, 248);
            this.lbCompetition.Name = "lbCompetition";
            this.lbCompetition.Size = new System.Drawing.Size(73, 13);
            this.lbCompetition.TabIndex = 14;
            this.lbCompetition.Text = "Competition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Score1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Team2 id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Team1 Id";
            // 
            // lbDebuggButton
            // 
            this.lbDebuggButton.AutoSize = true;
            this.lbDebuggButton.BackColor = System.Drawing.Color.Gray;
            this.lbDebuggButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lbDebuggButton.Location = new System.Drawing.Point(4, 766);
            this.lbDebuggButton.Name = "lbDebuggButton";
            this.lbDebuggButton.Size = new System.Drawing.Size(80, 13);
            this.lbDebuggButton.TabIndex = 10;
            this.lbDebuggButton.Text = "Debug test.......";
            this.lbDebuggButton.Click += new System.EventHandler(this.lbDebuggButton_Click);
            // 
            // panelConfig
            // 
            this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConfig.Controls.Add(this.panelLowMark2);
            this.panelConfig.Controls.Add(this.lbBtnPersonalInformation);
            this.panelConfig.Location = new System.Drawing.Point(15, 72);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(155, 161);
            this.panelConfig.TabIndex = 14;
            this.panelConfig.Visible = false;
            this.panelConfig.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConfig_Paint);
            // 
            // panelLowMark2
            // 
            this.panelLowMark2.BackColor = System.Drawing.SystemColors.Control;
            this.panelLowMark2.Location = new System.Drawing.Point(7, 41);
            this.panelLowMark2.Name = "panelLowMark2";
            this.panelLowMark2.Size = new System.Drawing.Size(55, 2);
            this.panelLowMark2.TabIndex = 2;
            this.panelLowMark2.Visible = false;
            // 
            // lbBtnPersonalInformation
            // 
            this.lbBtnPersonalInformation.AutoSize = true;
            this.lbBtnPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBtnPersonalInformation.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBtnPersonalInformation.Location = new System.Drawing.Point(4, 25);
            this.lbBtnPersonalInformation.Name = "lbBtnPersonalInformation";
            this.lbBtnPersonalInformation.Size = new System.Drawing.Size(143, 13);
            this.lbBtnPersonalInformation.TabIndex = 0;
            this.lbBtnPersonalInformation.Text = "My Personal Information";
            this.lbBtnPersonalInformation.Click += new System.EventHandler(this.lbBtnPersonalInformation_Click);
            this.lbBtnPersonalInformation.MouseLeave += new System.EventHandler(this.lbBtnPersonalInformation_MouseLeave);
            this.lbBtnPersonalInformation.MouseHover += new System.EventHandler(this.lbBtnPersonalInformation_MouseHover);
            // 
            // panelLowMark
            // 
            this.panelLowMark.BackColor = System.Drawing.SystemColors.Control;
            this.panelLowMark.Location = new System.Drawing.Point(17, 48);
            this.panelLowMark.Name = "panelLowMark";
            this.panelLowMark.Size = new System.Drawing.Size(55, 2);
            this.panelLowMark.TabIndex = 1;
            this.panelLowMark.Visible = false;
            // 
            // panelMenus
            // 
            this.panelMenus.Location = new System.Drawing.Point(842, 204);
            this.panelMenus.Name = "panelMenus";
            this.panelMenus.Size = new System.Drawing.Size(34, 31);
            this.panelMenus.TabIndex = 3;
            // 
            // panelTopPage
            // 
            this.panelTopPage.BackColor = System.Drawing.Color.DimGray;
            this.panelTopPage.Controls.Add(this.lbButtonTenis);
            this.panelTopPage.Controls.Add(this.lbButtonBasketball);
            this.panelTopPage.Controls.Add(this.lbButtonFootbal);
            this.panelTopPage.Controls.Add(this.lbSportListButtomMenu);
            this.panelTopPage.Controls.Add(this.pictureBoxBtnConfig);
            this.panelTopPage.Controls.Add(this.panelLowMark);
            this.panelTopPage.Location = new System.Drawing.Point(0, 13);
            this.panelTopPage.Name = "panelTopPage";
            this.panelTopPage.Size = new System.Drawing.Size(1801, 53);
            this.panelTopPage.TabIndex = 16;
            // 
            // lbButtonTenis
            // 
            this.lbButtonTenis.AutoSize = true;
            this.lbButtonTenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonTenis.ForeColor = System.Drawing.SystemColors.Control;
            this.lbButtonTenis.Location = new System.Drawing.Point(634, 17);
            this.lbButtonTenis.Name = "lbButtonTenis";
            this.lbButtonTenis.Size = new System.Drawing.Size(92, 33);
            this.lbButtonTenis.TabIndex = 16;
            this.lbButtonTenis.Text = "Tenis";
            this.lbButtonTenis.Click += new System.EventHandler(this.lbButtonTenis_Click);
            // 
            // lbButtonBasketball
            // 
            this.lbButtonBasketball.AutoSize = true;
            this.lbButtonBasketball.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonBasketball.ForeColor = System.Drawing.SystemColors.Control;
            this.lbButtonBasketball.Location = new System.Drawing.Point(423, 17);
            this.lbButtonBasketball.Name = "lbButtonBasketball";
            this.lbButtonBasketball.Size = new System.Drawing.Size(160, 33);
            this.lbButtonBasketball.TabIndex = 15;
            this.lbButtonBasketball.Text = "Basketball";
            this.lbButtonBasketball.Click += new System.EventHandler(this.lbButtonBasketball_Click);
            // 
            // lbButtonFootbal
            // 
            this.lbButtonFootbal.AutoSize = true;
            this.lbButtonFootbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonFootbal.ForeColor = System.Drawing.SystemColors.Control;
            this.lbButtonFootbal.Location = new System.Drawing.Point(236, 17);
            this.lbButtonFootbal.Name = "lbButtonFootbal";
            this.lbButtonFootbal.Size = new System.Drawing.Size(127, 33);
            this.lbButtonFootbal.TabIndex = 14;
            this.lbButtonFootbal.Text = "Football";
            this.lbButtonFootbal.Click += new System.EventHandler(this.lbButtonFootbal_Click);
            // 
            // lbSportListButtomMenu
            // 
            this.lbSportListButtomMenu.AutoSize = true;
            this.lbSportListButtomMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSportListButtomMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSportListButtomMenu.Location = new System.Drawing.Point(851, 17);
            this.lbSportListButtomMenu.Name = "lbSportListButtomMenu";
            this.lbSportListButtomMenu.Size = new System.Drawing.Size(105, 33);
            this.lbSportListButtomMenu.TabIndex = 4;
            this.lbSportListButtomMenu.Text = "Sports";
            this.lbSportListButtomMenu.MouseLeave += new System.EventHandler(this.lbSportListButtomMenu_MouseLeave);
            this.lbSportListButtomMenu.MouseHover += new System.EventHandler(this.lbSportListButtomMenu_MouseHover);
            // 
            // pictureBoxBtnConfig
            // 
            this.pictureBoxBtnConfig.Image = global::ApiPublica.Properties.Resources.UserMenuIcon;
            this.pictureBoxBtnConfig.Location = new System.Drawing.Point(18, -1);
            this.pictureBoxBtnConfig.Name = "pictureBoxBtnConfig";
            this.pictureBoxBtnConfig.Size = new System.Drawing.Size(54, 53);
            this.pictureBoxBtnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBtnConfig.TabIndex = 13;
            this.pictureBoxBtnConfig.TabStop = false;
            this.pictureBoxBtnConfig.Click += new System.EventHandler(this.pictureBoxBtnConfig_Click);
            this.pictureBoxBtnConfig.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBoxBtnConfig.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panelBackgroun1
            // 
            this.panelBackgroun1.BackColor = System.Drawing.Color.DimGray;
            this.panelBackgroun1.Controls.Add(this.lbTeam);
            this.panelBackgroun1.Controls.Add(this.txtTeam);
            this.panelBackgroun1.Controls.Add(this.lbSport);
            this.panelBackgroun1.Controls.Add(this.comboBoxSport);
            this.panelBackgroun1.Location = new System.Drawing.Point(882, 204);
            this.panelBackgroun1.Name = "panelBackgroun1";
            this.panelBackgroun1.Size = new System.Drawing.Size(207, 587);
            this.panelBackgroun1.TabIndex = 17;
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeam.Location = new System.Drawing.Point(37, 101);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(63, 24);
            this.lbTeam.TabIndex = 3;
            this.lbTeam.Text = "Team";
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(41, 128);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(121, 20);
            this.txtTeam.TabIndex = 2;
            // 
            // lbSport
            // 
            this.lbSport.AutoSize = true;
            this.lbSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSport.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSport.Location = new System.Drawing.Point(37, 22);
            this.lbSport.Name = "lbSport";
            this.lbSport.Size = new System.Drawing.Size(59, 24);
            this.lbSport.TabIndex = 1;
            this.lbSport.Text = "Sport";
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.FormattingEnabled = true;
            this.comboBoxSport.Location = new System.Drawing.Point(41, 49);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSport.TabIndex = 0;
            // 
            // panelSportList
            // 
            this.panelSportList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSportList.Location = new System.Drawing.Point(832, 72);
            this.panelSportList.Name = "panelSportList";
            this.panelSportList.Size = new System.Drawing.Size(155, 444);
            this.panelSportList.TabIndex = 16;
            this.panelSportList.Visible = false;
            this.panelSportList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panelSportList.MouseLeave += new System.EventHandler(this.panelSportList_MouseLeave);
            this.panelSportList.MouseHover += new System.EventHandler(this.panelSportList_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BannerPic
            // 
            this.BannerPic.Location = new System.Drawing.Point(176, 72);
            this.BannerPic.Name = "BannerPic";
            this.BannerPic.Size = new System.Drawing.Size(700, 90);
            this.BannerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerPic.TabIndex = 15;
            this.BannerPic.TabStop = false;
            this.BannerPic.Click += new System.EventHandler(this.BannerPic_Click);
            // 
            // FormPincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1264, 784);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelSportList);
            this.Controls.Add(this.panelBackgroun1);
            this.Controls.Add(this.panelTopPage);
            this.Controls.Add(this.BannerPic);
            this.Controls.Add(this.panelMenus);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.lbDebuggButton);
            this.Controls.Add(this.panelDebugg);
            this.Controls.Add(this.panelResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormPincipalMenu";
            this.Text = "FormPincipalMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelDebugg.ResumeLayout(false);
            this.panelDebugg.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.panelTopPage.ResumeLayout(false);
            this.panelTopPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnConfig)).EndInit();
            this.panelBackgroun1.ResumeLayout(false);
            this.panelBackgroun1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelResult;
        private System.Windows.Forms.TextBox txtCompetition;
        private System.Windows.Forms.TextBox txtTeam1id;
        private System.Windows.Forms.TextBox txtTeam2id;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnsendinfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelDebugg;
        private System.Windows.Forms.Label lbDebuggButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBtnConfig;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label lbBtnPersonalInformation;
        private System.Windows.Forms.Panel panelLowMark;
        private System.Windows.Forms.Panel panelLowMark2;
        private System.Windows.Forms.Panel panelMenus;
        private System.Windows.Forms.PictureBox BannerPic;
        private System.Windows.Forms.Panel panelTopPage;
        private System.Windows.Forms.Panel panelBackgroun1;
        private System.Windows.Forms.Label lbSport;
        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.Panel panelSportList;
        private System.Windows.Forms.Label lbSportListButtomMenu;
        private System.Windows.Forms.Label lbButtonFootbal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCompetition;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtStadium;
        private System.Windows.Forms.Label lbStadium;
        private System.Windows.Forms.Label lbButtonTenis;
        private System.Windows.Forms.Label lbButtonBasketball;
    }
}