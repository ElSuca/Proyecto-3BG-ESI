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
                if (!Panel.Contains(BackOfficeResults_Events.Instance))
                {
                    Panel.Controls.Add(BackOfficeResults_Events.Instance);
                    BackOfficeResults_Events.Instance.Dock = DockStyle.Fill;
                    BackOfficeResults_Events.Instance.BringToFront();
                }
                else BackOfficeResults_Events.Instance.BringToFront();
            }

            if (selection == 2)
            {
                if (!Panel.Contains(BackOficeResultManager_Asociation.Instance))
                {
                    Panel.Controls.Add(BackOficeResultManager_Asociation.Instance);
                    BackOficeResultManager_Asociation.Instance.Dock = DockStyle.Fill;
                    BackOficeResultManager_Asociation.Instance.BringToFront();
                }
                else BackOficeResultManager_Asociation.Instance.BringToFront();
            }
            if (selection == 3)
            {
                if (!Panel.Contains(BackOfficeResultsManager.Instance))
                {
                    Panel.Controls.Add(BackOfficeResultsManager.Instance);
                    BackOfficeResultsManager.Instance.Dock = DockStyle.Fill;
                    BackOfficeResultsManager.Instance.BringToFront();
                }
                else BackOfficeResultsManager.Instance.BringToFront();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void txtEvenScore_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BackOfficeResultsManager_Load(object sender, EventArgs e)
        {

        }

        private void btnEventManager_Click(object sender, EventArgs e)
        {
            selectMenu(1);
        }

        private void btnAsociation_Click(object sender, EventArgs e)
        {
            selectMenu(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPreEvent_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
