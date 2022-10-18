using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaLogica;
using CapaLoogica;
using BackOffice;
using System.Drawing;
using BackOffice.SportManager;

namespace Proyecto.Backoffice
{
    public partial class BackofficeManager : Form
    {
        public MySqlCommand command;
        public MySqlDataReader dataReader;
        public BackofficeManager()
        {
            InitializeComponent();
            loadResources();
            selectMenu(0);
        }
        private void BackofficeUserManager_Load(object sender, EventArgs e)
        {
        }

        public void selectMenu(int selection)
        {
            if (selection == 1)
            {

                if (!MainPanel.Contains(BackOfficeUserManager.Instance))
                {
                    MainPanel.Controls.Add(BackOfficeUserManager.Instance);
                    BackOfficeUserManager.Instance.Dock = DockStyle.Fill;
                    BackOfficeUserManager.Instance.BringToFront();
                }
                else BackOfficeUserManager.Instance.BringToFront();
            }

            if (selection == 2)
            {
                if (!MainPanel.Contains(BackOfficeAdManager.Instance))
                {
                    MainPanel.Controls.Add(BackOfficeAdManager.Instance);
                    BackOfficeAdManager.Instance.Dock = DockStyle.Fill;
                    BackOfficeAdManager.Instance.BringToFront();
                }
                else BackOfficeAdManager.Instance.BringToFront();
            }
            if (selection == 3)
            {
                if (!MainPanel.Contains(BackOfficeResultsManager.Instance))
                {
                    MainPanel.Controls.Add(BackOfficeResultsManager.Instance);
                    BackOfficeResultsManager.Instance.Dock = DockStyle.Fill;
                    BackOfficeResultsManager.Instance.BringToFront();
                }
                else BackOfficeResultsManager.Instance.BringToFront();
            }
            if (selection == 4)
            {
                if (!MainPanel.Contains(BackOfficeSportManager.Instance))
                {
                    MainPanel.Controls.Add(BackOfficeSportManager.Instance);
                    BackOfficeSportManager.Instance.Dock = DockStyle.Fill;
                    BackOfficeSportManager.Instance.BringToFront();
                }
                else BackOfficeSportManager.Instance.BringToFront();
            }
        }
 
        private void btnUserManagerToggle_Click(object sender, EventArgs e) => selectMenu(1);

        private void btnAdManager_Click(object sender, EventArgs e) => selectMenu(2);

        private void btnResultManager_Click(object sender, EventArgs e) => selectMenu(3);

        private void btnSportManager_Click(object sender, EventArgs e) => selectMenu(4);


        private void loadResources()
        {
        }

        public static Image ResizeImage(Image imgOriginal, Size size) => new Bitmap(imgOriginal, size);
        private void Lblanguaje_Click(object sender, EventArgs e)
        {

        }

       
    }
}
