using System;
using System.Collections.Generic;
using System.Data;
using CapaDeDatos;
using Newtonsoft.Json;

namespace CapaLogica
{
    public class UserControler
    {
        private string Username;
        private string UserPassword;
        private bool PasswordConfirmation;
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
        public static List<ModelUser> GetUserDataID(int id)
        {
            ModelUser p = new ModelUser(id);
            return p.GetUserDataID(id);
        }
        public void getId(int id)
        {
            ModelUser p = new ModelUser(id);
            p.GetId(id);
        }

        public static DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            ModelUser p = new ModelUser();
            List<ModelUser> personitas = p.GetUserData();

            return tabla;
        }
        public string ObtenerNombre()
        {
            return Username;
        }
        public string ObtenerContraseña()
        {
            return UserPassword;
        }
        public void SetUserData(string name, string password)
        {
            Username = name;
            UserPassword = password;
        }
        public static bool Confirmation(string Username, string UserPassword)
        {
            UserControler u = new UserControler();
            u.Username = Username;
            u.UserPassword = UserPassword;

            return true;
        }
        
        public static void setConfirmation(bool value)
        {
            UserControler u = new UserControler();
            u.PasswordConfirmation = value;
        }
        public static bool getConfirmation()
        {
            UserControler u = new UserControler();
            return u.PasswordConfirmation;
        }
        public bool credencialesCorrectas;
        public void CallUserVerification()
        {
           // ApiAutenitficacion.Autentificador au = new ApiAutenitficacion.Autentificador();
            //if (au.checkData()) credencialesCorrectas = true;
            //else credencialesCorrectas = false;
            Console.Write(credencialesCorrectas);
        }
    }
}

