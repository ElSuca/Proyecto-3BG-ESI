using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using CapaLoogica;

namespace ApiPublica
{
    public partial class UserDataMenu : UserControl
    {
        private static UserDataMenu _instance;

        public static UserDataMenu Instance
        {
            get
            {
                if (_instance == null) _instance = new UserDataMenu();
                return _instance;
            }
        }

        string UserName;
        public UserDataMenu()
        {
            InitializeComponent();
            SetUserData();
            translation(new AplicationControler().Language);
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
            txtCity.Text = uc.GetStaticCity;
            txtStreet.Text = uc.GetStaticStreet;
            txtStreetNumber.Text = uc.GetStaticNum.ToString();
            txtState.Text = uc.GetStaticState;
            txtCountry.Text = uc.GetStaticCountry;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                UserControler.Modify(
                    new UserControler().GetId(txtUsername.Text),
                    txtName.Text,
                    txtLastname1.Text,
                    txtLastname2.Text,
                    txtMail.Text,
                    txtUsername.Text,
                    txtRole.Text,
                    MD5Hash.Hash.Content(txtPassword.Text),
                    Int32.Parse(txtPhone.Text),
                    txtCity.Text,
                    txtStreet.Text,
                    Int32.Parse(txtStreetNumber.Text),
                    txtState.Text,
                    txtCountry.Text
                    );

                errorTranslation(new AplicationControler().Language, "DataUpdate", Color.FromArgb(0, 204, 0));
            }
            catch (Exception)
            {
                errorTranslation(new AplicationControler().Language, "Error", Color.FromArgb(255, 0, 0));
            }
        }

        private void errorTranslation(int language, string message, Color color)
        {
            lbMessage.ForeColor = color;
            if (message == "Error") lbMessage.Text = language == 0 ? "There was a problem, please try again" : "Hubo un error, intentelo mas tarde";
            else if (message == "DataUpdate") lbMessage.Text = language == 0 ? "Changes saved" : "Cambios guardados";
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


        private void btnUpgradeAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRole.Text == "User")
                {

                    UserControler.Modify(
                        new UserControler().GetId(txtUsername.Text),
                        txtName.Text,
                        txtLastname1.Text,
                        txtLastname2.Text,
                        txtMail.Text,
                        txtUsername.Text,
                        "Premiun",
                        MD5Hash.Hash.Content(txtPassword.Text),
                        Int32.Parse(txtPhone.Text),
                        txtCity.Text,
                        txtStreet.Text,
                        Int32.Parse(txtStreetNumber.Text),
                        txtState.Text,
                        txtCountry.Text
                        );
                    txtRole.Text = new UserControler().GetStaticRole;
                    errorTranslation(new AplicationControler().Language, "DataUpdate", Color.FromArgb(0, 204, 0));
                }
            }
            catch (Exception ex)
            {
                errorTranslation(new AplicationControler().Language, "Error", Color.FromArgb(255, 0, 0));
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

        private void btnShowPassword_Click_1(object sender, EventArgs e) => txtPassword.PasswordChar = txtPassword.PasswordChar == '*' ? txtPassword.PasswordChar = (char)0 : txtPassword.PasswordChar = '*';
    }
}

