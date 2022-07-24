using CapaLogica;
using System;
using System.Collections.Generic;
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
            DangerWords.Add("CHAR");
            DangerWords.Add("SET");

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
                MD5Hash.Hash.Content(txtPassword.Text)
            );
            MessageBox.Show("Usuario cargado");
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
