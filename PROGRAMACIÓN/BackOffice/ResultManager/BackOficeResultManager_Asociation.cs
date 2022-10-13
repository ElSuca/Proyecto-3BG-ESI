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
    public partial class BackOficeResultManager_Asociation : UserControl
    {
      
        private static BackOficeResultManager_Asociation _instance;

        public static BackOficeResultManager_Asociation Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOficeResultManager_Asociation();
                return _instance;
            }
        }

        public BackOficeResultManager_Asociation()
        {
            InitializeComponent();
            setInitial();
        }
        private void btnList_Click(object sender, EventArgs e) => reloadList();
        private void reloadList()
        {
           /* if(panelEventMenu.Visible)*/ dataGrid1.DataSource = new EventControler().GetEventDataTable();
          //  else dataGrid1.DataSource = new AsociationControler().GetAsociationDataTable();
            
        }

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            if (panelEventMenu.Visible) EventControler.Alta(txtEventName.Text, 
                txtEventDate.Text,
                txtStageName.Text,
                txtStageCity.Text,
                txtStageCountry.Text,
                txtStageStreet.Text,
                Int32.Parse(txtStageNum.Text));
           // else if (panelTeamsMenu.Visible) TeamC
                else MessageBox.Show("Por favor, seleccione un menu");
        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            toggleMenus(1);
        }
        private void toggleMenus(int menu)
        {
 
            panelTeamsMenu.Visible = false;
            panelEventMenu.Visible = false;

            if (menu == 1) panelEventMenu.Visible = true; 
            if (menu == 2) panelTeamsMenu.Visible = true;
            



        }
        private void setInitial()
        {
            panelEventMenu.Visible = false;
            panelTeamsMenu.Visible = false;
        }
        private bool isActivePanel()
        {
            if(panelEventMenu.Visible || panelTeamsMenu.Visible) return true;
            else return false;
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
    }
}
