using System;
using System.Windows.Forms;
using CapaLogica;

namespace BackOffice
{
    public partial class BackOfficeUserManager : UserControl
    {
        private static BackOfficeUserManager _instance;

        public static BackOfficeUserManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeUserManager();
                return _instance;
            }
        }

        public BackOfficeUserManager()
        {
            InitializeComponent();
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            UserControler.Alta(
                txtNameRegister.Text,
                txtLastName1Register.Text,
                txtLastName2Register.Text,
                txtEmailRegister.Text,
                txtUserNameRegister.Text,
                ComboBoxRole.Items[ComboBoxRole.SelectedIndex].ToString(),
                 MD5Hash.Hash.Content(txtPassword.Text),
                txtTelefonoRegister.Text
            );
            MessageBox.Show("Usuario cargado");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserControler.Eliminar(int.Parse(txtID.Text));
            MessageBox.Show("Usuario " + txtID.Text + " eliminado");
        }

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            UserControler.Modificar(
                Int32.Parse(txtID.Text),
                txtNameRegister.Text,
                txtLastName1Register.Text,
                txtLastName2Register.Text,
                txtEmailRegister.Text,
                txtUserNameRegister.Text,
                ComboBoxRole.Items[ComboBoxRole.SelectedIndex].ToString(),
                MD5Hash.Hash.Content(txtPassword.Text),
                txtTelefonoRegister.Text
                );
            MessageBox.Show("Usuario " + txtID.Text + " modificado");
            reloadList();
        }

        private void btnList_Click_1(object sender, EventArgs e) => reloadList();
        private void reloadList() => dgrid1.DataSource = new UserControler().GetUserDataTable();

        private void lbNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbRole_Click(object sender, EventArgs e)
        {

        }
    }
}
