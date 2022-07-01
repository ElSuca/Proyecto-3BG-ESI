using Proyecto.Backoffice;
using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class BackofficeMenu : Form
    {
        public BackofficeMenu()
        {
            InitializeComponent();
        }

        private void btnPublishManager_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
           BackofficeUserManager um = new BackofficeUserManager();
            um.Show();
        }
    }
}
