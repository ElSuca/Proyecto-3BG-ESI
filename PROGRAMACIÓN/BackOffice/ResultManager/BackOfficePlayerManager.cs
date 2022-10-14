using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.ResultManager
{
    public partial class BackOfficePlayerManager : UserControl
    {
        private static BackOfficePlayerManager _instance;

        public static BackOfficePlayerManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOficeResultManager();
                return _instance;
            }
        }

        public BackOfficePlayerManager()
        {
            InitializeComponent();
            setInitial();
        }

        private void btnTeamsMenu_Click(object sender, EventArgs e)
        {
            toggleMenus(1);
        }
        private void btnPlayer_Click(object sender, EventArgs e)
        {
            toggleMenus(2);
        }
        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
    }
}
