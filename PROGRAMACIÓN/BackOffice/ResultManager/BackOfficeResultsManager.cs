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
