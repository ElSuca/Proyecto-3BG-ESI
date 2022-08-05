using System;
using System.Windows.Forms;
using Proyecto.Backoffice;
using Proyecto.IniciosSeccion;
namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            FormLogging fl = new FormLogging();
            fl.Show();
        }

        private void BtnBackOffice_Click(object sender, EventArgs e)
        {
            BackofficeManager backoffice = new BackofficeManager();
            backoffice.Show();
        }

        
    }
}
