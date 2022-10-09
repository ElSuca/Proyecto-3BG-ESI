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
        private void reloadList() => dataGrid1.DataSource = new AsociationControler().GetAsociationDataTable();

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            toggleMenus(1);
        }
        private void toggleMenus(int menu)
        {
            bool n;

            n = getVisibility() ? false : true;

            if(menu == 1) panelEventMenu.Visible = n;
            if(menu == 2) panelTeamsMenu.Visible = n;

         

        }
        private bool getVisibility()
        {
           return panelEventMenu.Visible;
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
    }
}
