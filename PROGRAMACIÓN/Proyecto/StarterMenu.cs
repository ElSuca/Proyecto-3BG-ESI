using System;
using System.Windows.Forms;
using CapaLoogica;
using Proyecto.IniciosSeccion;

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
        public StarterMenu()
        {
            InitializeComponent();
            
        }

        private void btnLoggin_Click(object sender, EventArgs e) => new FormLogging().Show();

        private void btnRegister_Click(object sender, EventArgs e) => new FormRegistro().Show();

        private void Lblanguaje_Click(object sender, EventArgs e) => new FormPincipal().setSelection(4);

       
    }
}
