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
            bool Coincide;
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
            Coincide = UserControler.Autenticar(Username, Password);
            if (Coincide) MessageBox.Show("Inicio De secion correcto");
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
