using System;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class BackOfficeAdManager : UserControl
    {
        private static BackOfficeAdManager _instance;

        public static BackOfficeAdManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeAdManager();
                return _instance;
            }
        }

        public BackOfficeAdManager()
        {
            InitializeComponent();
        }

        private void BtnAddAd_Click(object sender, EventArgs e)
        {

        }

       
    }
}
