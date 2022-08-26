using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaLogica;
using CapaLoogica;

namespace Proyecto.Backoffice
{
    public partial class BackofficeManager : Form
    {
        public MySqlCommand command;
        public MySqlDataReader dataReader;
        public BackofficeManager()
        {
            InitializeComponent();
            selectMenu(0);
        }
        private void BackofficeUserManager_Load(object sender, EventArgs e)
        {
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

        private void BtnList_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            MySqlCommand command = new MySqlCommand();
            command.Connection = new AplicationControler().ConectDatabase();
            command.CommandText = "SELECT * FROM User";
            tabla.Load(command.ExecuteReader());
            new AplicationControler().ConectDatabase().Close();
            dgrid1.DataSource = tabla;
        }

        private void dgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Delete_Click(object sender, EventArgs e)
        { 
            UserControler.Eliminar(int.Parse(txtID.Text));
            MessageBox.Show("Usuario "+ txtID.Text + " eliminado");
        }

        private void btnModify_Click(object sender, EventArgs e)
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
            MySqlConnection conexion = new AplicationControler().ConectDatabase();
            MySqlCommand comando = new MySqlCommand();
            int id = int.Parse(txtID.Text);
            DataTable table = new DataTable();
            comando.Connection = conexion;
            new UserControler().GetId(id);
            comando.CommandText = "SELECT * FROM User WHERE id = @Id";
            table.Load(comando.ExecuteReader());
            conexion.Close();
            dgrid1.DataSource = table;
        }

        public void selectMenu(int selection)
        {
            if (selection == 1) UserManagerVisibility(true);
            else UserManagerVisibility(false);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxBackofficeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUserManagerToggle_Click(object sender, EventArgs e)
        {
            selectMenu(1);
        }
        public void UserManagerVisibility(bool v)
        {
           
                dgrid1.Visible = v;
                btnList.Visible = v;
            btnRegister.Visible = v;
            btnModify.Visible = v;
            btnDelete.Visible = v;
            txtEmailRegister.Visible = v;
            txtID.Visible = v;
            txtLastName1Register.Visible = v;
            txtLastName2Register.Visible = v;
            txtNameRegister.Visible = v;
            txtUserNameRegister.Visible = v;
            txtTelefonoRegister.Visible = v;
            txtPassword.Visible = v;
            ComboBoxRole.Visible = v;
            lbID.Visible = v;
            lbLastname.Visible = v;
            lbMail.Visible = v;
            lbUsername.Visible = v;
            lbLastName2.Visible = v;
            lbNumber.Visible = v;
            lbRole.Visible = v;
            lbName.Visible = v;
            lbPassword.Visible = v;
        }

        private void btnAdManager_Click(object sender, EventArgs e)
        {
            selectMenu(2);
        }
    }
}
