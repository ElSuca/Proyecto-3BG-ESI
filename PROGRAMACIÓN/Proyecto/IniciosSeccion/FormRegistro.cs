using CapaLogica;
using CapaLoogica;
using System;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            Traduction(new AplicationControler().getLanguage());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserControler.Alta(
                txtNameRegister.Text,
                txtApellidoRegister.Text,
                txtLastName2Register.Text,
                txtEmailRegister.Text,
                txtUserNameRegister.Text,
                "USER",
                MD5Hash.Hash.Content(txtPassword.Text),
                txtPhoneRegister.Text,
                txtCityRegister.Text,
                txtStreetRegister.Text,
                Int32.Parse(txtStreetNumberRegister.Text),
                txtStateRegister.Text,
                txtCountryRegister.Text
            );
            MessageBox.Show("Usuario cargado");
        }
        private void Traduction(int l)
        {
            if (l == 0)
            {
                btnRegister.Text = "Register";
                lbUsername.Text = "Username";
                lbRealName.Text = "Real Name";
                lbLastname.Text = "First Last Name";
                lbSecondLastName.Text = "Second Last Name";
                lbMail.Text = "Email";
                lbNumber.Text = "Phone Number";
                lbPassword.Text = "Password";
                lbTitle.Text = "Register";
            }
            else
            {
                btnRegister.Text = "Registrar";
                lbUsername.Text = "Nombre de Usuario";
                lbRealName.Text = "Nombre Real";
                lbLastname.Text = "Primer Apellido";
                lbSecondLastName.Text = "Segundo Apellido";
                lbMail.Text = "Correo Electrónico";
                lbNumber.Text = "Numero de Telefono";
                lbPassword.Text = "Contraseña";
                lbTitle.Text = "Registro";
            }
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

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
