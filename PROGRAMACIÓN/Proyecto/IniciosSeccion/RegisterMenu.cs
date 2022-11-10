using System;
using System.Windows.Forms;
using CapaLogica;

namespace Proyecto.IniciosSeccion
{
    public partial class RegisterMenu : UserControl
    {
        public RegisterMenu()
        {
            InitializeComponent();
        }
        private static RegisterMenu _instance;

        public static RegisterMenu Instance
        {
            get
            {
                if (_instance == null) _instance = new RegisterMenu();
                return _instance;
            }
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
    }
}
