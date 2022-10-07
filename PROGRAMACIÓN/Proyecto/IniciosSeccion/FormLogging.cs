using CapaLogica;
using CapaLoogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormLogging : Form
    {
        public FormLogging()
        {
            InitializeComponent();
            Traduction(new AplicationControler().getLanguage());
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
            else
            {
                lbMessage.ForeColor = Color.FromArgb(255, 0, 0);
                lbMessage.Text = ErrorMesageTranslation(new AplicationControler().getLanguage());
            }
        }

        private void FormLogging_Load(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e) => new MenuPrincipal().Show();

        private void Traduction(int l)
        {
            if (l == 0)
            {
                btnLoggin.Text = "Login";
                btnEntrar.Text = "Guest Login";
                lbUserName.Text = "Username";
                lbPassword.Text = "Password";
                lbTitle.Text = "Logging";
            }
            else
            {
                btnLoggin.Text = "Inicio de sesión";
                btnEntrar.Text = "Ingresar como invitado";
                lbPassword.Text = "Contraseña";
                lbUserName.Text = "Usuario";
                lbTitle.Text = "Inicio de sesión";
            }
            correctlabelposition(l);
        }
        private string ErrorMesageTranslation(int l)
        {
            string v = l == 0? "There was a problem, please try again":"Hubo un error, intentelo mas tarde";
            return v;
        }
        private void correctlabelposition(int l)
        {
            if(l == 0)
            {
                lbTitle.Location = new Point(47, 9);
                btnEntrar.Location = new Point(159, 200);
                btnEntrar.Size = new Size(144, 34);
                btnLoggin.Location = new Point(12, 200);
                lbMessage.Location = new Point(13, 165);
            }
            else
            {
                lbTitle.Location = new Point(-1, 9);
                btnEntrar.Location = new Point(12, 210);
                btnEntrar.Size = new Size(287, 34);
                btnLoggin.Location = new Point(12, 160);
                btnLoggin.Size = new Size(287, 34);
                lbMessage.Location = new Point(13, 146);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
