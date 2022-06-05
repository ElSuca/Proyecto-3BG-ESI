using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Proyecto.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Proyecto;

namespace Proyecto.IniciosSeccion
{
    public partial class FormLogging : Form
    {

        public FormLogging()
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
