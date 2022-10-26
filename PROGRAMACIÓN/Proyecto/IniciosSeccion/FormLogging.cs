using ApiPublica;
using Apis;
using CapaLogica;
using CapaLoogica;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormLogging : Form
    {
        public FormLogging()
        {
            InitializeComponent();
            traduction(new AplicationControler().getLanguage());
        }
        private void btnLoggin_Click(object sender, EventArgs e) 
        {
            UserControler uc = new UserControler();
            controlApi();
            SendRequest.GetPost("http://127.0.0.1:8888//autenticar", txtUserName.Text, txtPassword.Text);
            if (Int32.Parse(new AplicationControler().getResponse()) == 1)
            {
                FormPincipalMenu mp = new FormPincipalMenu();
                new UserControler().SetStaticUserData(txtUserName.Text);
                uc.SetStaticUsername(txtUserName.Text);
                uc.SetStaticPassword(txtPassword.Text);              
                mp.Show();

                this.Close();
                new FormPincipal().GetAppVisivility(false);
            }
            else
            {
                lbMessage.ForeColor = Color.FromArgb(255, 0, 0);
                lbMessage.Text = errorMesageTranslation(new AplicationControler().getLanguage());
            }
            controlApi();

        }
        private void controlApi() 
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = @"..\..\..\..\PROGRAMACIÓN\ApiAutentificacion\bin\Debug\ApiAutentificacion.exe";
            startinfo.CreateNoWindow = true;
            startinfo.UseShellExecute = true;
            if (!isRunning("ApiAutentificacion")) Process.Start(startinfo).Start();
            else Process.Start(startinfo).Kill();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new FormPincipalMenu().Show();
            this.Close();
            new FormPincipal().GetAppVisivility(false);
        }

        private void traduction(int l)
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
        private string errorMesageTranslation(int l)
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

        public static bool isRunning(string ProcessName)
        {
            Process[] processes = Process.GetProcessesByName(ProcessName);
            if (processes.Length == 0) return false;
            else return true;
        }
    }
}
