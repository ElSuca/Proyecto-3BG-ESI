using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaLoogica;

namespace BackOffice.ResultManager
{
    public partial class BackOfficePlayerManager : UserControl
    {
        private static BackOfficePlayerManager _instance;

        public static BackOfficePlayerManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficePlayerManager();
                return _instance;
            }
        }

        public BackOfficePlayerManager()
        {
            InitializeComponent();
            setInitial();
        }

        private void btnTeamsMenu_Click(object sender, EventArgs e) => toggleMenus(1);
        private void btnPlayer_Click(object sender, EventArgs e) => toggleMenus(2);
        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelPlayerMenu.Visible)
                {
                    if (!panelParentAsociationFamilyMenu.Visible)
                    {
                        string date = $"{txtBirthdateYear.Text}-" +
                        $"{comboBoxBirthdateMoth.Items[comboBoxBirthdateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxBirthdateDay.Items[comboBoxBirthdateDay.SelectedIndex].ToString()}";
                        PlayerControler.Alta(txtPlayerName.Text, txtPlayerLastName1.Text, txtPlayerLastName2.Text, txtPlayerStatus.Text, date, txtPlayerCity.Text, TxtPlayerState.Text, txtPlayerCountry.Text);
                        MessageBox.Show("Jugador cargado");
                    }
                    else
                    {
                        string StartDate = $"{txtStartEventPlayerAsociationDateYear.Text}-" +
                        $"{comboBoxPlayerAsociationStartDateMoth.Items[comboBoxPlayerAsociationStartDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxPlayerAsociationStartDateDay.Items[comboBoxPlayerAsociationStartDateDay.SelectedIndex].ToString()}";

                        string EndDate = $"{txtPlayerAsociationEndDateYear.Text}-" +
                        $"{comboBoxPlayerAsociationEndDateMoth.Items[comboBoxPlayerAsociationEndDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxPlayerAsociationEndDateDay.Items[comboBoxPlayerAsociationEndDateDay.SelectedIndex].ToString()}";

                        PlayerControler.AltaParents(Int32.Parse(txtPlayerID.Text), Int32.Parse(txtAsociationId.Text), StartDate, EndDate);
                        MessageBox.Show($"Familia cargada");
                        reloadList();
                    }
                }
                else if (panelTeamsMenu.Visible)
                {
                    if (txtTeamsName.Text == "" || txtTeamCity.Text == "" || txtTeamState.Text == "" || txtTeamCountry.Text == "") throw new MissingFieldException();
                    TeamControler.Alta(txtTeamsName.Text, txtTeamCity.Text, txtTeamState.Text, txtTeamCountry.Text);
                    MessageBox.Show("Equipo cargado");
                }
                reloadList();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (MissingFieldException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (SqlException)
            {
                MessageBox.Show("This result aldery exist");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void btnList_Click(object sender, EventArgs e) => reloadList();

        private void reloadList()
        {
            try
            {
                if (panelPlayerMenu.Visible) dataGrid1.DataSource = new PlayerControler().GetPlayerDataTable();
                else if (panelTeamsMenu.Visible) dataGrid1.DataSource = new TeamControler().GetTeamDataTable();
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelPlayerMenu.Visible)
                {
                    string date = $"{txtBirthdateYear.Text}-" +
                    $"{comboBoxBirthdateMoth.Items[comboBoxBirthdateMoth.SelectedIndex].ToString()}-" +
                    $"{comboBoxBirthdateDay.Items[comboBoxBirthdateDay.SelectedIndex].ToString()}";
                    PlayerControler.Modificar(Int32.Parse(txtPlayerID.Text), txtPlayerName.Text, txtPlayerLastName1.Text, txtPlayerLastName2.Text, txtPlayerStatus.Text, date, txtPlayerCity.Text, TxtPlayerState.Text, txtPlayerCountry.Text);
                    MessageBox.Show($"Jugador {txtPlayerID.Text} cargado");
                }
                else if (panelTeamsMenu.Visible)
                {
                    TeamControler.Modificar(Int32.Parse(txtIDTeam.Text), txtTeamsName.Text, txtTeamCity.Text, txtTeamState.Text, txtTeamCountry.Text);
                    MessageBox.Show($"Equipo {txtIDTeam.Text} cargado");
                }
                reloadList();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This data aldery exist");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelPlayerMenu.Visible)
                {
                    PlayerControler.Eliminar(Int32.Parse(txtPlayerID.Text));
                    MessageBox.Show($"Player {txtPlayerID.Text} deleted");
                }
                else if (panelTeamsMenu.Visible)
                {
                    TeamControler.Eliminar(Int32.Parse(txtIDTeam.Text));
                    MessageBox.Show($"Team {txtIDTeam.Text} deleted");
                }
                reloadList();
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This data no exist");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }
        private void toggleMenus(int menu)
        {
            panelPlayerMenu.Visible = false;
            panelTeamsMenu.Visible = false;

            if (menu == 1) panelTeamsMenu.Visible = true;
            if (menu == 2) panelPlayerMenu.Visible = true;
        }
        private void setInitial()
        {
            panelPlayerMenu.Visible = false;
            panelTeamsMenu.Visible = false;
        }

        private void btnRegisterPlayerAsociation_Click(object sender, EventArgs e)
        {
            string StartDate = $"{txtStartEventPlayerAsociationDateYear.Text}-" +
            $"{comboBoxPlayerAsociationStartDateMoth.Items[comboBoxPlayerAsociationStartDateMoth.SelectedIndex].ToString()}-" +
            $"{comboBoxPlayerAsociationStartDateDay.Items[comboBoxPlayerAsociationStartDateDay.SelectedIndex].ToString()}";

            string EndDate = $"{txtPlayerAsociationEndDateYear.Text}-" +
            $"{comboBoxPlayerAsociationEndDateMoth.Items[comboBoxPlayerAsociationEndDateMoth.SelectedIndex].ToString()}-" +
            $"{comboBoxPlayerAsociationEndDateDay.Items[comboBoxPlayerAsociationEndDateDay.SelectedIndex].ToString()}";

            PlayerControler.AltaParents(Int32.Parse(txtPlayerID.Text), Int32.Parse(txtAsociationId.Text), StartDate, EndDate);
            MessageBox.Show($"Asociation load");
            reloadList();
        } 

        private void lbPlayerAsociationPreviousFamily_Click(object sender, EventArgs e) => panelParentAsociationFamilyMenu.Visible = panelParentAsociationFamilyMenu.Visible ? false : true;

        private void lbPlayerAsociationPreviousFamily_MouseHover(object sender, EventArgs e) => lbPlayerAsociationPreviousFamily.ForeColor = Color.Blue;

        private void lbPlayerAsociationPreviousFamily_MouseLeave(object sender, EventArgs e) => lbPlayerAsociationPreviousFamily.ForeColor = Color.White;
    }
}
