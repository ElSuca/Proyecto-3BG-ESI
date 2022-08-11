using System.Collections.Generic;
using System.Data;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
    public class UserControler
    {
        public void inicializate(string Username)
        {
            ModelUser mu = new ModelUser();
            mu.inicializate(Username);
        }
        public static void Alta(string nombre, string apellido, string telefono, string email, string password)
        {
            ModelUser p = new ModelUser();
            p.Name = nombre;
            p.LastName = apellido;
            p.PhoneNumber = telefono;
            p.Email = email;
            p.Password = password;
            p.Save();
        }
        public static void Modificar(int id, string nombre, string apellido, string telefono, string email, string password)
        {
            ModelUser p = new ModelUser(id);
            p.Name = nombre;
            p.LastName = apellido;
            p.PhoneNumber = telefono;
            p.Email = email;
            p.Password = password;
            p.Save();
        }
        public static void Eliminar(int id)
        {
            ModelUser p = new ModelUser(id);
            p.Delete(id);
        }
        public static List<ModelUser> GetUserData(int id)
        {
            ModelUser p = new ModelUser(id);
            return p.GetUserData();
        }
        public List<ModelUser> GetUserData(string Username)
        {
            ModelUser p = new ModelUser();
            return p.GetUserData(Username);
        }
        public void getId(int id)
        {
            ModelUser p = new ModelUser(id);
            p.GetId(id);
        }
        public int GetId(string Name)
        {
            ModelUser p = new ModelUser();
            int id = p.GetId(Name);
            return id;
        }
        public static DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            ModelUser p = new ModelUser();
            List<ModelUser> personitas = p.GetUserData();

            return tabla;
        }
        public static bool Autenticar(string nombre, string password)
        {
            ModelUser u = new ModelUser();
            u.Name = nombre;
            return u.Autenticar(password);
        }
        public string getEmail()
        {
            ModelUser p = new ModelUser();
            return p.getEmail();
        }
        public string getUsername()
        {
            ModelUser p = new ModelUser();
            return p.getUserName();
        }
        public MySqlConnection ConectDatabase()
        {
            MySqlConnection conexion = new MySqlConnection(
                    "server = 127.0.0.1; " +
                    "uid = root;" +
                    "pwd=root;" +
                    "database=proyecto"
                   );

            conexion.Open();
            return conexion;
        }
    }
}

