using CapaDeDatos;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto.IniciosSeccion
{
    public partial class FormLogging : Form
    {

        public FormLogging()
        {
            InitializeComponent();
            
        }
        private void btnLoggin_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
                "server = 127.0.0.1; " +
                "uid = root;" +
                "pwd=root;" +
                "database=proyecto"
               );

            conexion.Open();
            SetData();
            
        }

        private static string _path = @"C:\Users\Admin\Cache\Credenciales.json";
        public void SetData()
        {
           var UserData = new User
            {
               Username = txtUserName.Text,
               Password = txtPassword.Text
            };

            SerializeJson(UserData);
        }
        public string getUsername()
        {
            return txtUserName.Text;
        }
        public string getPassword()
        {
            return txtPassword.Text;
        }
        public void SerializeJson(User users)
        {
            string userJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(_path, userJson);
        }
      

    }
}
