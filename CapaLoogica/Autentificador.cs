using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;


namespace ApiAutenitficacion
{
    class Autentificador
    {
        public Autentificador()
        {
            //DeserializeJson();
            menuprovicional();
        }
        private static string _path = @"C:\Users\Admin\Cache\Credenciales.json";
        public bool checkData(string UserName, string Password)
        {
            //string UserName = getUserDataJson().Username;
            //string Password = getUserDataJson().Password;

            ModelUser p = new ModelUser();
            if (UserName == p.GetUserName(UserName) && Password == p.GetUserPassword(UserName))
            {
                Console.WriteLine("Credenciales correctas");
                return true;
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
                return false;
            }
        }
        public User getUserDataJson()
        {
            StreamReader r = new StreamReader(_path);
            string jsonRead = r.ReadToEnd();
            User m = JsonConvert.DeserializeObject<User>(jsonRead);

            return m;
        }

        public void DeserializeJson(string userJson)
        {
             //var UserDeserialized = JsonConvert.DeserializeObject<List<ModelUser>>(userJson);
             //Username = UserDeserialized[1].Name;
             //Pass = UserDeserialized[1].Password;
        }
        
        public void menuprovicional()
        {
             Console.WriteLine("Ingrese Nombre:");
             string UserName = Console.ReadLine();
             Console.WriteLine("Ingrese Contraseña:");
             string Password = Console.ReadLine();
             checkData(UserName, Password);
            //getUserDataJson();
        }
    }
}
