using System;
using System.Windows.Forms;
using Proyecto.Backoffice;
using Proyecto.IniciosSeccion;
namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnRegister_Click(object sender, EventArgs e) => new FormRegistro().Show();

        private void btnLoggin_Click(object sender, EventArgs e) => new FormLogging().Show();

        private void BtnBackOffice_Click(object sender, EventArgs e) => new BackofficeManager().Show();


    }
}
