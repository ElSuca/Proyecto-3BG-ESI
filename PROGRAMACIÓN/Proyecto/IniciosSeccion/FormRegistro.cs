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
            traduction(new AplicationControler().Language);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                UserControler.Alta(
                    txtNameRegister.Text,
                    txtApellidoRegister.Text,
                    txtLastName2Register.Text,
                    txtEmailRegister.Text,
                    txtUserNameRegister.Text,
                    "USER",
                    MD5Hash.Hash.Content(txtPassword.Text),
                    Int32.Parse(txtPhoneRegister.Text),
                    txtCityRegister.Text,
                    txtStreetRegister.Text,
                    Int32.Parse(txtStreetNumberRegister.Text),
                    txtStateRegister.Text,
                    txtCountryRegister.Text
                );
                MessageBox.Show("Usuario cargado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void traduction(int l)
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
    }
}
