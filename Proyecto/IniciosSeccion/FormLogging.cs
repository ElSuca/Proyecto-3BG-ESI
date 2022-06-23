using CapaDeDatos;
using CapaLogica;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.IO;
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
            UserControler.Confirmation(Username,Password);
            Coincide = UserControler.getConfirmation();
            if (Coincide) MessageBox.Show("Inicio De secion correcto");
            else MessageBox.Show("Hubo un problema, intente nuevamente");
        }
    }
}
