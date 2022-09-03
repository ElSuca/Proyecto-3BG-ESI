using CapaLogica;
using System;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserControler.Alta(
                txtNameRegister.Text,
                txtApellidoRegister.Text,
                txtLastName2Register.Text,
                txtEmailRegister.Text,
                txtUserNameRegister.Text,
                "User",
                MD5Hash.Hash.Content(txtPassword.Text),
                txtPhoneRegister.Text
            );
            MessageBox.Show("Usuario cargado");
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void lbMail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailRegister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
