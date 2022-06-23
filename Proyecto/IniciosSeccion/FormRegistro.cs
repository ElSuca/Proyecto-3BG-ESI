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
            if (!checkInput(txtUserNameRegister.Text) || !checkInput(txtApellidoRegister.Text) 
               || !checkInput(txtTelefonoRegister.Text) || !checkInput(txtEmailRegister.Text))
            {
                MessageBox.Show("Hubo un problema, intente nuevamente");
                return;
            }

            MySqlConnection conexion = new MySqlConnection(
                "server = 127.0.0.1; " +
                "uid = root;" +
                "pwd=stEAEgBRH35jgtLN3ztIDmlOYP;" +
                "database=proyecto"
               );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;

                comando.CommandText = "INSERT INTO " +
                "usuario (nombre, apellido, telefono, email, password) " +
                "VALUES (@nombre,@apellido,@telefono,@email, @password)";

                comando.Parameters.AddWithValue("@nombre", txtUserNameRegister.Text);
                comando.Parameters.AddWithValue("@apellido", txtApellidoRegister.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefonoRegister.Text);
                comando.Parameters.AddWithValue("@email", txtEmailRegister.Text);
                comando.Parameters.AddWithValue("@password", txtPassword.Text);


            comando.Prepare();
            comando.ExecuteNonQuery();
            
            MessageBox.Show("Usuario cargado");

        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
