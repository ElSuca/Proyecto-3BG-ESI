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
        public bool checkData(string UserName, string Password)
        {
            //string UserName = getUserDataJson().Username;
            //string Password = getUserDataJson().Password;

            ModelUser p = new ModelUser();
            if (UserName == p.GetUserDataLogging(UserName,"Name") && Password == p.GetUserDataLogging(UserName,"Password"))
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

        public void DeserializeJson(string userJson)
        {
             var UserDeserialized = JsonConvert.DeserializeObject(userJson);
           
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
