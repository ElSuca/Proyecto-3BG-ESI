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
            reloadList();
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
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a role for user");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user aldery exist");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UserControler.Delete(int.Parse(txtID.Text));
                reloadList();
                MessageBox.Show("Usuario " + txtID.Text + " eliminado");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user no exist");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            try
            {
                UserControler.Modify(
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
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a role for user");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter a role for user");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user aldery exist");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }
        private void reloadList()
        {
            try
            {
                dgrid1.DataSource = new UserControler().GetUserDataTable();
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void pictureBoxBtnRefresh_Click(object sender, EventArgs e) => reloadList();
    }
}
