using System;
using System.Collections.Generic;
using System.Data;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
    public class UserControler
    {
        #region FuncionesBasicas  
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
        #endregion
        #region GetUserData
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
        #endregion
        #region GetId
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
        #endregion
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
        #region get
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
        #endregion
        #region SetStatic
        public void SetStaticUsername(string name)
        {
            ModelUser mu = new ModelUser();
            mu.SetUsernameStatic(name);
        }
        public void SetStaticLastName(string lastname)
        {
            ModelUser mu = new ModelUser();
            mu.SetLastNameStatic(lastname);
        }
        public void SetStaticEmail(string email)
        {
            ModelUser mu = new ModelUser();
            mu.SetEmailStatic(email);
        }
        public void SetStaticPhoneNumber(int phonenumber)
        {
            ModelUser mu = new ModelUser();
            mu.SetPhoneNumberStatic(phonenumber);
        }
        public void SetStaticPassword(string password)
        {
            ModelUser mu = new ModelUser();
            mu.SetPasswordStatic(password);
        }
        #endregion
        #region GetStatic
        public string GetStaticUsername()
        {
            ModelUser mu = new ModelUser();
            return mu.GetUsernameStatic();
        }
        public string GetStaticLastName()
        {
            ModelUser mu = new ModelUser();
            return mu.GetLastNameStatic();
        }
        public string GetStaticEmail()
        {
            ModelUser mu = new ModelUser();
            return mu.GetEmailStatic();
        }
        public int GetStaticPhoneNumber()
        {
            ModelUser mu = new ModelUser();
            return mu.GetPhoneNumberStatic();
        }
        public string GetStaticPassword()
        {
            ModelUser mu = new ModelUser();
            return mu.GetPasswordStatic();
        }
        #endregion
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

