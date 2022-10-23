using System;
using System.Data.SqlClient;
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
            try
            {
                UserControler.Alta(
                    txtNameRegister.Text,
                    txtLastName1Register.Text,
                    txtLastName2Register.Text,
                    txtEmailRegister.Text,
                    txtUserNameRegister.Text,
                    ComboBoxRole.Items[ComboBoxRole.SelectedIndex].ToString(),
                    MD5Hash.Hash.Content(txtPassword.Text),
                    Int32.Parse(txtTelefonoRegister.Text),
                    txtCity.Text,
                    txtStreet.Text,
                    Int32.Parse(txtNum.Text),
                    txtState.Text,
                    txtCountry.Text
                );
                reloadList();
                MessageBox.Show("Usuario cargado");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un problema c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema inesperado");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UserControler.Eliminar(int.Parse(txtID.Text));
                reloadList();
                MessageBox.Show("Usuario " + txtID.Text + " eliminado");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Hubo un problema c");
            }
            catch(Exception ex)
            {
                MessageBox.Show("El usuario no existe");
            }
        }

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            try
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
                    Int32.Parse(txtTelefonoRegister.Text),
                    txtCity.Text,
                    txtStreet.Text,
                    Int32.Parse(txtNum.Text),
                    txtState.Text,
                    txtCountry.Text
                    );
                MessageBox.Show("Usuario " + txtID.Text + " modificado");
                reloadList();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un problema c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El usuario no existe");
            }
        }

        private void btnList_Click_1(object sender, EventArgs e) => reloadList();
        private void reloadList() => dgrid1.DataSource = new UserControler().GetUserDataTable();

        private void lbNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbRole_Click(object sender, EventArgs e)
        {

        }

        private void dgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
