using System;
using System.Windows.Forms;
using CapaLogica;

namespace Proyecto.IniciosSeccion
{
    public partial class LoggingMenu : UserControl
    {
        private static LoggingMenu _instance;

        public static LoggingMenu Instance
        {
            get
            {
                if (_instance == null) _instance = new LoggingMenu();
                return _instance;
            }
        }

        public LoggingMenu()
        {
            InitializeComponent();
        }
      

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            UserControler uc = new UserControler();
            if (UserControler.Autenticar(txtUserName.Text, txtPassword.Text))
            {
                uc.SetStaticUsername(txtUserName.Text);
                uc.SetStaticPassword(txtPassword.Text);
                new MenuPrincipal().Show();
            }
            else MessageBox.Show("Hubo un problema, intente nuevamente");
        }

        private void btnEntrar_Click(object sender, EventArgs e) => new MenuPrincipal().Show();
    }
}
