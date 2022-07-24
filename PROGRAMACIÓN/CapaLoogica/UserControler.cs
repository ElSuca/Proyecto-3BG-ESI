using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using CapaDeDatos;
using Newtonsoft.Json;

namespace CapaLogica
{
    public class UserControler
    { 
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
        public static bool Autenticar(string nombre, string password)
        {
            ModelUser u = new ModelUser();
            u.Name = nombre;
         
            return u.Autenticar(password);
        }
        
    }
}

