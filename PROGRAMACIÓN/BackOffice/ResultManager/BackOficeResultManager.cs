using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapaLoogica;

namespace BackOffice.ResultManager
{
    public partial class BackOficeResultManager : UserControl
    {
      
        private static BackOficeResultManager _instance;

        public static BackOficeResultManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOficeResultManager();
                return _instance;
            }
        }

        public BackOficeResultManager()
        {
            InitializeComponent();
            setInitial();
        }
        private void btnList_Click(object sender, EventArgs e) => reloadList();
        private void reloadList()
        {
            if(panelEventMenu.Visible) dataGrid1.DataSource = new EventControler().GetEventDataTable();
              else dataGrid1.DataSource = new TeamControler().GetTeamDataTable();
        }

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            if (panelEventMenu.Visible)
            {
                EventControler.Alta(txtEventName.Text, txtEventDate.Text, txtEventState.Text, txtStageCity.Text, txtStageCountry.Text, txtStageStreet.Text, Int32.Parse(txtStageNum.Text));
                MessageBox.Show("Evento cargado");
            }
            else if (panelTeamsMenu.Visible)
            {
                TeamControler.Alta(txtTeamsName.Text, txtTeamCity.Text, txtTeamState.Text, txtTeamCountry.Text);
                MessageBox.Show("Equipo cargado");
            }
            else MessageBox.Show("Por favor, seleccione un menu");
            reloadList();
        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            toggleMenus(1);
        }
        private void toggleMenus(int menu)
        {

            
            panelEventMenu.Visible = false;
            ToggleTeamsMenu(false);

            if (menu == 1) panelEventMenu.Visible = true;
            if (menu == 2) ToggleTeamsMenu(true);





        }
        private void ToggleTeamsMenu(bool n)
        {

            panelTeamsMenu.Visible = n;
            txtIDTeam.Visible = n;
            txtTeamCity.Visible = n;
            txtTeamsName.Visible = n;
            txtTeamState.Visible = n;
            txtTeamCountry.Visible = n;
        }
        private void setInitial()
        {
            panelEventMenu.Visible = false;
            panelTeamsMenu.Visible = false;
        }
       
        private void btnTeamsMenu_Click(object sender, EventArgs e)
        {
            toggleMenus(2);
        }

        private void panelTeamsMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelEventMenu_Paint(object sender, PaintEventArgs e)
        {  
        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {
            if (panelEventMenu.Visible)
            {
                EventControler.Modificar(Int32.Parse(txtEventID.Text),txtEventName.Text, txtEventDate.Text, txtEventState.Text, txtStageCity.Text, txtStageCountry.Text, txtStageStreet.Text, Int32.Parse(txtStageNum.Text));
                MessageBox.Show("Evento cargado");
            }
            else if (panelTeamsMenu.Visible)
            {
                TeamControler.Modificar(Int32.Parse(txtIDTeam.Text),txtTeamsName.Text, txtTeamCity.Text, txtTeamState.Text, txtTeamCountry.Text);
                MessageBox.Show("Equipo cargado");
            }
            else MessageBox.Show("Por favor, seleccione un menu");
            reloadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (panelEventMenu.Visible)
            {
                EventControler.Eliminar(Int32.Parse(txtEventID.Text));
                MessageBox.Show($"Evento {txtEventID.Text} Eliminado");
            }
            else if (panelTeamsMenu.Visible)
            {
                TeamControler.Eliminar(Int32.Parse(txtIDTeam.Text));
                MessageBox.Show($"Equipo {txtIDTeam.Text} Eliminado");
            }
            else MessageBox.Show("Por favor, seleccione un menu");
            reloadList();
        }
    }
}
