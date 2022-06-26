using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaLogica;

namespace Proyecto.Backoffice
{
    public partial class BackofficeUserManager : Form
    {
        public MySqlCommand command;
        public MySqlDataReader dataReader;
        public BackofficeUserManager()
        {
            InitializeComponent();
        }
        private void BackofficeUserManager_Load(object sender, EventArgs e)
        {
        }
        private bool checkInput(string input)
        {
            List<string> dangerWords = new List<string>();
            dangerWords.Add("WHERE");
            dangerWords.Add("DROP");
            dangerWords.Add(";");
            dangerWords.Add("FROM");
            dangerWords.Add("INSERT");
            dangerWords.Add("CREATE");
            dangerWords.Add("UPDATE");
            dangerWords.Add("DELETE");
            dangerWords.Add("SELECT");

            foreach (string palabra in dangerWords)
            {
                if (input.Contains(palabra)) return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserControler.Alta(
                txtUserNameRegister.Text,
                txtApellidoRegister.Text, 
                txtTelefonoRegister.Text,
                txtEmailRegister.Text,
                txtPassword.Text
            );
            MessageBox.Show("Usuario cargado");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
                     "server = 127.0.0.1; " +
                     "uid = root;" +
                     "pwd=root;" +
                     "database=proyecto"
                    );

            conexion.Open();
            
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader reader;
            DataTable table = new DataTable();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM Usuario";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.Close();
            dgrid1.DataSource = table;
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
            UserControler.Modificar(Int32.Parse(txtID.Text),
                txtUserNameRegister.Text,
                txtApellidoRegister.Text,
                txtTelefonoRegister.Text,
                txtEmailRegister.Text,
                txtPassword.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)// no funca ayuda
        {
            UserControler u = new UserControler();
            MySqlConnection conexion = new MySqlConnection(
                     "server = 127.0.0.1; " +
                     "uid = root;" +
                     "pwd=root;" +
                     "database=proyecto"
                    );

            conexion.Open();
            MySqlCommand comando = new MySqlCommand();

            int id = Int32.Parse(txtID.Text);
            MySqlDataReader reader;
            DataTable table = new DataTable();
            comando.Connection = conexion;
            u.getId(id);
            comando.CommandText = "SELECT * FROM Usuario WHERE id = @Id";
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexion.Close();
            dgrid1.DataSource = table;
        }

        private void txtCargar_Click(object sender, EventArgs e)
        {
            txtID.Text = "5";
            txtUserNameRegister.Text = "test";
            txtApellidoRegister.Text = "a";
            txtTelefonoRegister.Text = "12345678";
            txtEmailRegister.Text = "a";
            txtPassword.Text = "test";
        }
    }
}
