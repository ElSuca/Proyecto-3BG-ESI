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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
