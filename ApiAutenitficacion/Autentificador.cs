using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Proyecto.Model;

namespace ApiAutenitficacion
{
    class Autentificador
    {
        static void Main(string[] args)
        {        
        }
        public Autentificador()
        {
     
        }
        string Name;
        string Pass;
        string Username;
        string Password;
        private static string _path = @"C:\Proyecto_3BG\Credenciales.json";
        public void checkData()
        {
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader reader;
            MySqlConnection conexion = new MySqlConnection(
               "server = 127.0.0.1; " +
               "uid = root;" +
               "pwd=root;" +
               "database=proyecto"
            );

            conexion.Open();

            reader = comando.ExecuteReader();
            comando.CommandText = "SELECT * FROM personita";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                Username = reader.GetString(1);
                Password = reader.GetString(5);
            }
            if(Username == Name && Password == Pass)
            {
               Console.Write("Usuario cargado");
            }
            else
            {
                Console.Write("Credenciales incorrectas");
            }
        }
        public string getUserDataJson()
        {
            string userJsonRead;
            using(var reader = new StreamReader(_path))
            {
                userJsonRead = reader.ReadToEnd();
            }
            return userJsonRead;
        }
        public void DeserializeJson(string userJson)
        {
            var UserDeserialized = JsonConvert.DeserializeObject<List<User>>(userJson);
            Username = UserDeserialized[1].Name;
            Pass = UserDeserialized[1].Password;
        }

    }
}
