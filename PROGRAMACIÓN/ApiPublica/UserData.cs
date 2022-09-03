using CapaDeDatos;
using CapaLogica;
using System;
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        public void SetUserName(string n)
        {
            UserName = n;
        }
        public void SetUserData()
        {
            ModelUser u = new ModelUser();
            UserControler uc = new UserControler();
            string nombre = uc.StaticUsername;
            lbUserName.Text = nombre;
            lbLastName.Text = uc.StaticLastName;
            lbEmail.Text = uc.StaticEmail;
            lbPhoneNumber.Text = uc.StaticPhoneNumber.ToString();
            lbPassword.Text = uc.StaticPassword;
        }

        private void UserData_Load(object sender, EventArgs e)
        {

        }

        private void dgridUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
