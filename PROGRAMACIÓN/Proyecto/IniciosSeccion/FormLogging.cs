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
            UserControler uc = new UserControler();
            if (UserControler.Autenticar(txtUserName.Text, txtPassword.Text))
            {
                uc.SetStaticUsername(txtUserName.Text);
                uc.SetStaticPassword(txtPassword.Text);
                new MenuPrincipal().Show();
            }
            else MessageBox.Show("Hubo un problema, intente nuevamente");
        }

        private void FormLogging_Load(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e) => new MenuPrincipal().Show();
    }
}
