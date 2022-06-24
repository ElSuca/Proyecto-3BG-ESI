using CapaLogica;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        private bool checkInput(string input)
        {
            List<string> DangerWords = new List<string>();
            DangerWords.Add("WHERE");
            DangerWords.Add("DROP");
            DangerWords.Add(";");
            DangerWords.Add("FROM");


            foreach (string palabra in DangerWords)
            {
                if (input.Contains(palabra)) return false;

            }

            return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!checkInput(txtUserNameRegister.Text) || !checkInput(txtApellidoRegister.Text) 
               || !checkInput(txtTelefonoRegister.Text) || !checkInput(txtEmailRegister.Text))
            {
                MessageBox.Show("Hubo un problema, intente nuevamente");
                return;
            }
            UserControler.Alta(
                txtUserNameRegister.Text,
                txtApellidoRegister.Text,
                txtTelefonoRegister.Text,
                txtEmailRegister.Text,
                txtPassword.Text
            );
            MessageBox.Show("Usuario cargado");
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
