using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGrafica.IniciosSeccion
{
    public partial class FormLogginf : Form
    {
        public FormLogginf()
        {
            InitializeComponent();
        }
        string Username;
        string Pasword;
        private void btnLoggin_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
               "server = 127.0.0.1; " +
               "uid = root;" +
               "pwd=root;" +
               "database=proyecto"
              );

            conexion.Open();

            var user = SetData();
            SerializeJson(user);
        }
        private static string _path = @"C:\Proyecto_3BG\Credenciales.json";


        public List<User> SetData()
        {
            Username = txtUserName.Text;
            Pasword = txtPassword.Text;

            new User
            {
                Name = Username,
                Password = Pasword
            };
            return null;
        }
        public void SerializeJson(List<User> users)
        {
            string userJson = JsonConvert.SerializeObject(users.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, userJson);
        }
    }
}
