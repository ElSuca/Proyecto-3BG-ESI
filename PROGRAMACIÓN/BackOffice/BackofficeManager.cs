using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaLogica;
using CapaLoogica;
using BackOffice;

namespace Proyecto.Backoffice
{
    public partial class BackofficeManager : Form
    {
        public MySqlCommand command;
        public MySqlDataReader dataReader;
        public BackofficeManager()
        {
            InitializeComponent();
            selectMenu(0);
        }
        private void BackofficeUserManager_Load(object sender, EventArgs e)
        {
        }

        public void selectMenu(int selection)
        {
            BackOfficeUserManager um = new BackOfficeUserManager();
            if (selection == 1) MainPanel.Controls.Add(um);
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxBackofficeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUserManagerToggle_Click(object sender, EventArgs e)
        {
            selectMenu(1);
        }
       
        private void btnAdManager_Click(object sender, EventArgs e)
        {
            selectMenu(2);
        }
    }
}
