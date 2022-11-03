using System;
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
                TeamControler.Alta(txtTeamsName.Text, txtTeamCity.Text, txtTeamState.Text, txtTeamCountry.Text);
                MessageBox.Show("Equipo cargado");
            }
            reloadList();
        }

        private void btnList_Click(object sender, EventArgs e) => reloadList();

        private void reloadList()
        {
            if (panelPlayerMenu.Visible) dataGrid1.DataSource = new PlayerControler().GetPlayerDataTable();
            else if (panelTeamsMenu.Visible) dataGrid1.DataSource = new TeamControler().GetTeamDataTable();
        }

        private void btnModifiy_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (panelPlayerMenu.Visible)
            {
                PlayerControler.Eliminar(Int32.Parse(txtPlayerID.Text));
                MessageBox.Show($"Jugador {txtPlayerID.Text} eliminado");
            }
            else if (panelTeamsMenu.Visible)
            {
                TeamControler.Eliminar(Int32.Parse(txtIDTeam.Text));
                MessageBox.Show($"Equipo {txtIDTeam.Text} eliminado");
            }
            reloadList();
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
            MessageBox.Show($"Asociacion cargada");
            reloadList();
        } 

        private void lbPlayerAsociationPreviousFamily_Click(object sender, EventArgs e) => panelParentAsociationFamilyMenu.Visible = panelParentAsociationFamilyMenu.Visible ? false : true;

        private void lbPlayerAsociationPreviousFamily_MouseHover(object sender, EventArgs e) => lbPlayerAsociationPreviousFamily.ForeColor = Color.Blue;

        private void lbPlayerAsociationPreviousFamily_MouseLeave(object sender, EventArgs e) => lbPlayerAsociationPreviousFamily.ForeColor = Color.White;
    }
}
