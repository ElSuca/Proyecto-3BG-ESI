using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        private bool checkInput(string input)
        {
            List<string> palabrasFeas = new List<string>();
            palabrasFeas.Add("WHERE");
            palabrasFeas.Add("DROP");
            palabrasFeas.Add(";");
            palabrasFeas.Add("FROM");


            foreach (string palabra in palabrasFeas)
            {
                if (input.Contains(palabra)) return false;

            }

            return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!checkInput(txtID.Text) || !checkInput(txtUserNameRegister.Text) || !checkInput(txtApellidoRegister.Text) 
               || !checkInput(txtTelefonoRegister.Text) || !checkInput(txtEmailRegister.Text))
            {
                MessageBox.Show("Hubo un problema, intente nuevamente");
                return;
            }

            MySqlConnection conexion = new MySqlConnection(
                "server = 127.0.0.1; " +
                "uid = root;" +
                "pwd=root;" +
                "database=proyecto"
               );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;

            if (txtID.Text == "")
            {
                comando.CommandText = "INSERT INTO " +
                "usuario (nombre, apellido, telefono, email, password) " +
                "VALUES (@nombre,@apellido,@telefono,@email, @password)";

                comando.Parameters.AddWithValue("@nombre", txtUserNameRegister.Text);
                comando.Parameters.AddWithValue("@apellido", txtApellidoRegister.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefonoRegister.Text);
                comando.Parameters.AddWithValue("@email", txtEmailRegister.Text);
                comando.Parameters.AddWithValue("@password", txtPassword.Text);
            }
            else
            {
                comando.CommandText = "INSERT INTO " +
                "usuario VALUES (@id, @nombre,@apellido,@email,@telefono)";

                comando.Parameters.AddWithValue("@id", txtID.Text);
                comando.Parameters.AddWithValue("@nombre", txtUserNameRegister.Text);
                comando.Parameters.AddWithValue("@apellido", txtApellidoRegister.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefonoRegister.Text);
                comando.Parameters.AddWithValue("@email", txtEmailRegister.Text);
                comando.Parameters.AddWithValue("@password", txtPassword.Text);
            }

            comando.Prepare();
            comando.ExecuteNonQuery();
            
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


            comando.CommandText = "SELECT * FROM usuario";

            // Guardo el resultado de la query en el DataReader
            reader = comando.ExecuteReader();
            // Cargo la informacion del DataReader en el DataTable
            table.Load(reader);
            // Uso el DataTable como origen de datos del DataGridView
            dgrid1.DataSource = table;
        }
    }
}
