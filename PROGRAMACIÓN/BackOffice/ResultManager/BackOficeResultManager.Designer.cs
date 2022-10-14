namespace BackOffice.ResultManager
{
    partial class BackOficeResultManager
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
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.btnEventMenu = new System.Windows.Forms.Button();
            this.panelEventMenu = new System.Windows.Forms.Panel();
            this.lbEventState = new System.Windows.Forms.Label();
            this.txtEventState = new System.Windows.Forms.MaskedTextBox();
            this.txtStageCity = new System.Windows.Forms.MaskedTextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtStageNum = new System.Windows.Forms.MaskedTextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.txtStageStreet = new System.Windows.Forms.MaskedTextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.txtStageCountry = new System.Windows.Forms.MaskedTextBox();
            this.lbStageCountry = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.MaskedTextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.panelTeamsMenu = new System.Windows.Forms.Panel();
            this.txtTeamCountry = new System.Windows.Forms.MaskedTextBox();
            this.lbTeamCountry = new System.Windows.Forms.Label();
            this.txtTeamState = new System.Windows.Forms.MaskedTextBox();
            this.lbTeamState = new System.Windows.Forms.Label();
            this.txtTeamCity = new System.Windows.Forms.MaskedTextBox();
            this.lbTeamCity = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.Label();
            this.txtIDTeam = new System.Windows.Forms.TextBox();
            this.lbTeamsName = new System.Windows.Forms.Label();
            this.txtTeamsName = new System.Windows.Forms.TextBox();
            this.btnTeamsMenu = new System.Windows.Forms.Button();
            this.btnModifiy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panelEventMenu.SuspendLayout();
            this.panelTeamsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterAcc
            // 
            this.btnRegisterAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnRegisterAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegisterAcc.Location = new System.Drawing.Point(36, 516);
            this.btnRegisterAcc.Name = "btnRegisterAcc";
            this.btnRegisterAcc.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterAcc.TabIndex = 0;
            this.btnRegisterAcc.Text = "Register";
            this.btnRegisterAcc.UseVisualStyleBackColor = false;
            this.btnRegisterAcc.Click += new System.EventHandler(this.btnRegisterAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtEventID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEventID.Location = new System.Drawing.Point(19, 33);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(253, 20);
            this.txtEventID.TabIndex = 2;
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtEventName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEventName.Location = new System.Drawing.Point(19, 79);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(253, 20);
            this.txtEventName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(345, 111);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(929, 284);
            this.dataGrid1.TabIndex = 9;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnList.Location = new System.Drawing.Point(117, 516);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnEventMenu
            // 
            this.btnEventMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnEventMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEventMenu.Location = new System.Drawing.Point(36, 85);
            this.btnEventMenu.Name = "btnEventMenu";
            this.btnEventMenu.Size = new System.Drawing.Size(75, 23);
            this.btnEventMenu.TabIndex = 12;
            this.btnEventMenu.Text = "Event";
            this.btnEventMenu.UseVisualStyleBackColor = false;
            this.btnEventMenu.Click += new System.EventHandler(this.btnEventMenu_Click);
            // 
            // panelEventMenu
            // 
            this.panelEventMenu.Controls.Add(this.lbEventState);
            this.panelEventMenu.Controls.Add(this.txtEventState);
            this.panelEventMenu.Controls.Add(this.txtStageCity);
            this.panelEventMenu.Controls.Add(this.lbCity);
            this.panelEventMenu.Controls.Add(this.txtStageNum);
            this.panelEventMenu.Controls.Add(this.lbNum);
            this.panelEventMenu.Controls.Add(this.txtStageStreet);
            this.panelEventMenu.Controls.Add(this.lbStreet);
            this.panelEventMenu.Controls.Add(this.txtStageCountry);
            this.panelEventMenu.Controls.Add(this.lbStageCountry);
            this.panelEventMenu.Controls.Add(this.txtEventDate);
            this.panelEventMenu.Controls.Add(this.lbDate);
            this.panelEventMenu.Controls.Add(this.label1);
            this.panelEventMenu.Controls.Add(this.txtEventID);
            this.panelEventMenu.Controls.Add(this.label2);
            this.panelEventMenu.Controls.Add(this.txtEventName);
            this.panelEventMenu.Location = new System.Drawing.Point(36, 111);
            this.panelEventMenu.Name = "panelEventMenu";
            this.panelEventMenu.Size = new System.Drawing.Size(293, 399);
            this.panelEventMenu.TabIndex = 13;
            this.panelEventMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEventMenu_Paint);
            // 
            // lbEventState
            // 
            this.lbEventState.AutoSize = true;
            this.lbEventState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventState.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEventState.Location = new System.Drawing.Point(16, 148);
            this.lbEventState.Name = "lbEventState";
            this.lbEventState.Size = new System.Drawing.Size(53, 20);
            this.lbEventState.TabIndex = 19;
            this.lbEventState.Text = "State";
            // 
            // txtEventState
            // 
            this.txtEventState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtEventState.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEventState.Location = new System.Drawing.Point(19, 171);
            this.txtEventState.Name = "txtEventState";
            this.txtEventState.Size = new System.Drawing.Size(253, 20);
            this.txtEventState.TabIndex = 18;
            // 
            // txtStageCity
            // 
            this.txtStageCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStageCity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStageCity.Location = new System.Drawing.Point(19, 216);
            this.txtStageCity.Name = "txtStageCity";
            this.txtStageCity.Size = new System.Drawing.Size(253, 20);
            this.txtStageCity.TabIndex = 14;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCity.Location = new System.Drawing.Point(16, 194);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(39, 20);
            this.lbCity.TabIndex = 14;
            this.lbCity.Text = "City";
            // 
            // txtStageNum
            // 
            this.txtStageNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStageNum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStageNum.Location = new System.Drawing.Point(19, 354);
            this.txtStageNum.Name = "txtStageNum";
            this.txtStageNum.Size = new System.Drawing.Size(253, 20);
            this.txtStageNum.TabIndex = 14;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNum.Location = new System.Drawing.Point(15, 331);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(45, 20);
            this.lbNum.TabIndex = 14;
            this.lbNum.Text = "Num";
            // 
            // txtStageStreet
            // 
            this.txtStageStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStageStreet.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStageStreet.Location = new System.Drawing.Point(19, 308);
            this.txtStageStreet.Name = "txtStageStreet";
            this.txtStageStreet.Size = new System.Drawing.Size(253, 20);
            this.txtStageStreet.TabIndex = 14;
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreet.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStreet.Location = new System.Drawing.Point(16, 285);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(59, 20);
            this.lbStreet.TabIndex = 17;
            this.lbStreet.Text = "Street";
            // 
            // txtStageCountry
            // 
            this.txtStageCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStageCountry.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStageCountry.Location = new System.Drawing.Point(19, 262);
            this.txtStageCountry.Name = "txtStageCountry";
            this.txtStageCountry.Size = new System.Drawing.Size(253, 20);
            this.txtStageCountry.TabIndex = 16;
            // 
            // lbStageCountry
            // 
            this.lbStageCountry.AutoSize = true;
            this.lbStageCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStageCountry.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStageCountry.Location = new System.Drawing.Point(16, 239);
            this.lbStageCountry.Name = "lbStageCountry";
            this.lbStageCountry.Size = new System.Drawing.Size(71, 20);
            this.lbStageCountry.TabIndex = 15;
            this.lbStageCountry.Text = "Country";
            // 
            // txtEventDate
            // 
            this.txtEventDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtEventDate.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEventDate.Location = new System.Drawing.Point(19, 125);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(253, 20);
            this.txtEventDate.TabIndex = 14;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDate.Location = new System.Drawing.Point(15, 102);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(48, 20);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Date";
            // 
            // panelTeamsMenu
            // 
            this.panelTeamsMenu.Controls.Add(this.txtTeamCountry);
            this.panelTeamsMenu.Controls.Add(this.lbTeamCountry);
            this.panelTeamsMenu.Controls.Add(this.txtTeamState);
            this.panelTeamsMenu.Controls.Add(this.lbTeamState);
            this.panelTeamsMenu.Controls.Add(this.txtTeamCity);
            this.panelTeamsMenu.Controls.Add(this.lbTeamCity);
            this.panelTeamsMenu.Controls.Add(this.lbTeams);
            this.panelTeamsMenu.Controls.Add(this.txtIDTeam);
            this.panelTeamsMenu.Controls.Add(this.lbTeamsName);
            this.panelTeamsMenu.Controls.Add(this.txtTeamsName);
            this.panelTeamsMenu.Location = new System.Drawing.Point(36, 111);
            this.panelTeamsMenu.Name = "panelTeamsMenu";
            this.panelTeamsMenu.Size = new System.Drawing.Size(293, 256);
            this.panelTeamsMenu.TabIndex = 18;
            this.panelTeamsMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeamsMenu_Paint);
            // 
            // txtTeamCountry
            // 
            this.txtTeamCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTeamCountry.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTeamCountry.Location = new System.Drawing.Point(19, 217);
            this.txtTeamCountry.Name = "txtTeamCountry";
            this.txtTeamCountry.Size = new System.Drawing.Size(253, 20);
            this.txtTeamCountry.TabIndex = 14;
            // 
            // lbTeamCountry
            // 
            this.lbTeamCountry.AutoSize = true;
            this.lbTeamCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamCountry.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeamCountry.Location = new System.Drawing.Point(15, 194);
            this.lbTeamCountry.Name = "lbTeamCountry";
            this.lbTeamCountry.Size = new System.Drawing.Size(71, 20);
            this.lbTeamCountry.TabIndex = 17;
            this.lbTeamCountry.Text = "Country";
            // 
            // txtTeamState
            // 
            this.txtTeamState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTeamState.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTeamState.Location = new System.Drawing.Point(19, 171);
            this.txtTeamState.Name = "txtTeamState";
            this.txtTeamState.Size = new System.Drawing.Size(253, 20);
            this.txtTeamState.TabIndex = 16;
            // 
            // lbTeamState
            // 
            this.lbTeamState.AutoSize = true;
            this.lbTeamState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamState.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeamState.Location = new System.Drawing.Point(15, 148);
            this.lbTeamState.Name = "lbTeamState";
            this.lbTeamState.Size = new System.Drawing.Size(53, 20);
            this.lbTeamState.TabIndex = 15;
            this.lbTeamState.Text = "State";
            // 
            // txtTeamCity
            // 
            this.txtTeamCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTeamCity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTeamCity.Location = new System.Drawing.Point(19, 125);
            this.txtTeamCity.Name = "txtTeamCity";
            this.txtTeamCity.Size = new System.Drawing.Size(253, 20);
            this.txtTeamCity.TabIndex = 14;
            // 
            // lbTeamCity
            // 
            this.lbTeamCity.AutoSize = true;
            this.lbTeamCity.CausesValidation = false;
            this.lbTeamCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamCity.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeamCity.Location = new System.Drawing.Point(15, 102);
            this.lbTeamCity.Name = "lbTeamCity";
            this.lbTeamCity.Size = new System.Drawing.Size(39, 20);
            this.lbTeamCity.TabIndex = 14;
            this.lbTeamCity.Text = "City";
            // 
            // lbTeams
            // 
            this.lbTeams.AutoSize = true;
            this.lbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeams.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeams.Location = new System.Drawing.Point(15, 10);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(28, 20);
            this.lbTeams.TabIndex = 1;
            this.lbTeams.Text = "ID";
            // 
            // txtIDTeam
            // 
            this.txtIDTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtIDTeam.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIDTeam.Location = new System.Drawing.Point(19, 33);
            this.txtIDTeam.Name = "txtIDTeam";
            this.txtIDTeam.Size = new System.Drawing.Size(253, 20);
            this.txtIDTeam.TabIndex = 2;
            // 
            // lbTeamsName
            // 
            this.lbTeamsName.AutoSize = true;
            this.lbTeamsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamsName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeamsName.Location = new System.Drawing.Point(15, 56);
            this.lbTeamsName.Name = "lbTeamsName";
            this.lbTeamsName.Size = new System.Drawing.Size(55, 20);
            this.lbTeamsName.TabIndex = 4;
            this.lbTeamsName.Text = "Name";
            // 
            // txtTeamsName
            // 
            this.txtTeamsName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTeamsName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTeamsName.Location = new System.Drawing.Point(19, 79);
            this.txtTeamsName.Name = "txtTeamsName";
            this.txtTeamsName.Size = new System.Drawing.Size(253, 20);
            this.txtTeamsName.TabIndex = 3;
            // 
            // btnTeamsMenu
            // 
            this.btnTeamsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnTeamsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeamsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamsMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeamsMenu.Location = new System.Drawing.Point(132, 85);
            this.btnTeamsMenu.Name = "btnTeamsMenu";
            this.btnTeamsMenu.Size = new System.Drawing.Size(75, 23);
            this.btnTeamsMenu.TabIndex = 14;
            this.btnTeamsMenu.Text = "Teams";
            this.btnTeamsMenu.UseVisualStyleBackColor = false;
            this.btnTeamsMenu.Click += new System.EventHandler(this.btnTeamsMenu_Click);
            // 
            // btnModifiy
            // 
            this.btnModifiy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnModifiy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifiy.Location = new System.Drawing.Point(198, 516);
            this.btnModifiy.Name = "btnModifiy";
            this.btnModifiy.Size = new System.Drawing.Size(75, 23);
            this.btnModifiy.TabIndex = 19;
            this.btnModifiy.Text = "Modify";
            this.btnModifiy.UseVisualStyleBackColor = false;
            this.btnModifiy.Click += new System.EventHandler(this.btnModifiy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(279, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BackOficeResultManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModifiy);
            this.Controls.Add(this.panelTeamsMenu);
            this.Controls.Add(this.btnTeamsMenu);
            this.Controls.Add(this.panelEventMenu);
            this.Controls.Add(this.btnEventMenu);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnRegisterAcc);
            this.Name = "BackOficeResultManager";
            this.Size = new System.Drawing.Size(1301, 685);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panelEventMenu.ResumeLayout(false);
            this.panelEventMenu.PerformLayout();
            this.panelTeamsMenu.ResumeLayout(false);
            this.panelTeamsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnEventMenu;
        private System.Windows.Forms.Panel panelEventMenu;
        private System.Windows.Forms.MaskedTextBox txtStageCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.MaskedTextBox txtStageNum;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.MaskedTextBox txtStageStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.MaskedTextBox txtStageCountry;
        private System.Windows.Forms.Label lbStageCountry;
        private System.Windows.Forms.MaskedTextBox txtEventDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnTeamsMenu;
        private System.Windows.Forms.Panel panelTeamsMenu;
        private System.Windows.Forms.MaskedTextBox txtTeamCountry;
        private System.Windows.Forms.Label lbTeamCountry;
        private System.Windows.Forms.MaskedTextBox txtTeamState;
        private System.Windows.Forms.Label lbTeamState;
        private System.Windows.Forms.MaskedTextBox txtTeamCity;
        private System.Windows.Forms.Label lbTeamCity;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.TextBox txtIDTeam;
        private System.Windows.Forms.Label lbTeamsName;
        private System.Windows.Forms.TextBox txtTeamsName;
        private System.Windows.Forms.Label lbEventState;
        private System.Windows.Forms.MaskedTextBox txtEventState;
        private System.Windows.Forms.Button btnModifiy;
        private System.Windows.Forms.Button btnDelete;
    }
}
