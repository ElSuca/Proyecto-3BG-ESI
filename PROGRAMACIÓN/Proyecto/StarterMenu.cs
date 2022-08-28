using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.IniciosSeccion;
using Proyecto.Backoffice;
using CapDeDatos;

namespace Proyecto
{
    public partial class StarterMenu : UserControl
    {
        private static StarterMenu _instance;

        public static StarterMenu Instance
        {
            get
            {
                if (_instance == null) _instance = new StarterMenu();
                return _instance;
            }
        }

        public StarterMenu() => InitializeComponent();

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            /* new SafeSystemBuffer().SetMenu1Choice(1);
             new Form1().setSelection(1);*/

            new FormLogging().Show();
        }

        private void BtnBackOffice_Click(object sender, EventArgs e)
        {
            /*  new SafeSystemBuffer().SetMenu1Choice(2);
              new Form1().setSelection(2);*/

            new BackofficeManager().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*  new SafeSystemBuffer().SetMenu1Choice(3);
              new Form1().setSelection(3);*/

           new FormRegistro().Show();
        }

    }
}
