using CapaLogica;
using CapaLoogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApiPublica
{
    public partial class UserData : Form
    {
        string UserName;
        public UserData()
        {
            InitializeComponent();
            SetUserData();
            translation(new AplicationControler().getLanguage());
            ajustSize();
        }
        public void SetUserName(string n) => UserName = n;
        public void SetUserData()
        {
            UserControler uc = new UserControler();
            txtUsername.Text = uc.GetStaticUsername;
            txtName.Text = uc.GetStaticName;
            txtLastname1.Text = uc.GetStaticLastName;
            txtLastname2.Text = uc.GetStaticLastName2;
            txtMail.Text = uc.GetStaticEmail;
            txtPhone.Text = uc.GetStaticPhoneNumber.ToString();
            txtPassword.Text = uc.GetStaticPassword;
            txtRole.Text = uc.GetStaticRole;
        }

        private void UserData_Load(object sender, EventArgs e) { }
        private void dgridUserData_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lbUserName_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lbPhoneNumber_Click(object sender, EventArgs e) { }
        private void lbPassword_Click(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void label_Click(object sender, EventArgs e) { }

        private void textRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                UserControler.Modificar(
                    new UserControler().GetId(txtUsername.Text),
                    txtName.Text,
                    txtLastname1.Text,
                    txtLastname2.Text,
                    txtMail.Text,
                    txtUsername.Text,
                    txtRole.Text,
                    MD5Hash.Hash.Content(txtPassword.Text),
                    txtPhone.Text
                    );
                errorTranslation(new AplicationControler().getLanguage(), "DataUpdate", Color.FromArgb(0, 204, 0));
            }
            catch (Exception ex)
            {
                errorTranslation(new AplicationControler().getLanguage(),"Error", Color.FromArgb(255,0,0));
            }
        }
        private void errorTranslation(int language,string message, Color color)
        {
            lbMessage.ForeColor = color;
            if(message == "Error") lbMessage.Text = language == 0 ? "There was a problem, please try again" : "Hubo un error, intentelo mas tarde";
            else if(message == "DataUpdate") lbMessage.Text = language == 0 ? "Changes saved" : "Cambios guardados";
        }
        private void translation(int l)
        {
            if (l == 0)
            {
                lbUsernameDisplay.Text = "Username";
                lbNameDisplay.Text = "Name";
                lbLastnameDisplay.Text = "Last Name";
                lbEmailDisplay.Text = "Email";
                lbPhonenumberDisplay.Text = "Phone Number";
                lbPasswordDisplay.Text = "Password";
                lbRoleDisplay.Text = "Status";
                btnSaveChanges.Text = "Save Changes";
                btnUpgradeAccount.Text = "Upgrade Account";
            }
            else
            {
                lbUsernameDisplay.Text = "Nombre de usuario";
                lbNameDisplay.Text = "Nombre real";
                lbLastnameDisplay.Text = "Appellido";
                lbEmailDisplay.Text = "Email";
                lbPhonenumberDisplay.Text = "Numedro de telefono";
                lbPasswordDisplay.Text = "Contraseña";
                lbRoleDisplay.Text = "Estatus";
                btnSaveChanges.Text = "Guardar cambios";
                btnUpgradeAccount.Text = "Mejorar plan";
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e) => txtPassword.PasswordChar = txtPassword.PasswordChar == '*' ? txtPassword.PasswordChar = (char)0 : txtPassword.PasswordChar = '*';

        private void btnUpgradeAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRole.Text == "User")
                {

                    UserControler.Modificar(
                        new UserControler().GetId(txtUsername.Text),
                        txtName.Text,
                        txtLastname1.Text,
                        txtLastname2.Text,
                        txtMail.Text,
                        txtUsername.Text,
                        "Premiun",
                        MD5Hash.Hash.Content(txtPassword.Text),
                        txtPhone.Text
                        );
                    txtRole.Text = new UserControler().GetStaticRole;
                    errorTranslation(new AplicationControler().getLanguage(), "DataUpdate", Color.FromArgb(0, 204, 0));
                }
            }
            catch (Exception ex)
            {
                errorTranslation(new AplicationControler().getLanguage(), "Error", Color.FromArgb(255, 0, 0));
            }
        }
        private void ajustSize()
        {
            if (txtRole.Text == "User")
            {
                txtRole.Size = new Size(218, 26);
                btnUpgradeAccount.Visible = true;
            }
            else
            {
                txtRole.Size = new Size(381, 26);
                btnUpgradeAccount.Visible = false;
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string Correo = "ptahtechnologiesolympus@gmail.com";
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(txtMail.Text);
            mmsg.Subject = "Olympus";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = "Hola, este es un mensaje enviado desde el proyecto Olympus";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress(Correo);

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(Correo, "xjypkpamhrfypghr");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Correo enviado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
