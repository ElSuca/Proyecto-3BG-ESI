using CapaLogica;
using System;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormLogging : Form
    {

        public FormLogging()
        {
            InitializeComponent();  
        }
        private void btnLoggin_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            UserControler uc = new UserControler();
            ApiPublica.UserData u = new ApiPublica.UserData();
            bool Coincide;
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
          
            Coincide = UserControler.Autenticar(Username, Password);
            if (Coincide)
            {
                uc.SetStaticUsername(Username);
                uc.SetStaticPassword(Password);
                m.Show();
            }
            else MessageBox.Show("Hubo un problema, intente nuevamente");
        }

        private void FormLogging_Load(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
        }
    }
}
