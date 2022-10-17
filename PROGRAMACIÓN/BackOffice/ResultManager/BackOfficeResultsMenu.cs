using BackOffice.ResultManager;
using System;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class BackOfficeResultsManager : UserControl
    {
        private static BackOfficeResultsManager _instance;

        public static BackOfficeResultsManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeResultsManager();
                return _instance;
            }
        }

        public BackOfficeResultsManager()
        {
            InitializeComponent();
            selectMenu(0);
        }

        public void selectMenu(int selection)
        {
            if (selection == 1)
            {
                if (!Panel.Contains(BackOfficeAsociationManager.Instance))
                {
                    Panel.Controls.Add(BackOfficeAsociationManager.Instance);
                    BackOfficeAsociationManager.Instance.Dock = DockStyle.Fill;
                    BackOfficeAsociationManager.Instance.BringToFront();
                }
                else BackOfficeAsociationManager.Instance.BringToFront();
            }
            if (selection == 2)
            {
                if (!Panel.Contains(BackOficeResultManager.Instance))
                {
                    Panel.Controls.Add(BackOficeResultManager.Instance);
                    BackOficeResultManager.Instance.Dock = DockStyle.Fill;
                    BackOficeResultManager.Instance.BringToFront();
                }
                else BackOficeResultManager.Instance.BringToFront();
            }
            if (selection == 3)
            {
                if (!Panel.Contains(BackOfficePlayerManager.Instance))
                {
                    Panel.Controls.Add(BackOfficePlayerManager.Instance);
                    BackOfficePlayerManager.Instance.Dock = DockStyle.Fill;
                    BackOfficePlayerManager.Instance.BringToFront();
                }
                else BackOfficePlayerManager.Instance.BringToFront();
            }
        }

        private void btnEventManager_Click(object sender, EventArgs e)
        {
            selectMenu(2);
        }

        private void btnAsociation_Click(object sender, EventArgs e)
        {
            selectMenu(1);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            selectMenu(3);
        }
    }
}
