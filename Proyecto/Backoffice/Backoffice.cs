using Proyecto.Backoffice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Backoffice : Form
    {
        public Backoffice()
        {
            InitializeComponent();
        }

        private void btnPublishManager_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Proyecto.Backoffice.BackofficeUserManager um = new Proyecto.Backoffice.BackofficeUserManager();
            um.show();
        }
    }
}
