using System;
using System.Collections.Generic;
using System.Data;
using CapaDeDatos;

namespace CapaLogica
{
    class UserControler
    {
        public static void Alta(int id, string nombre, string apellido, string telefono, string email)
        {
            ModelUser p = new ModelUser();

            p.Id = id;
            p.Name = nombre;
            p.LastName = apellido;
            p.PhoneNumber = telefono;
            p.Email = email;
            p.Save();
        }
        public static void Modificar(int id, string nombre, string apellido, string telefono, string email)
        {
            ModelUser p = new ModelUser(id);
            p.Name = nombre;
            p.LastName = apellido;
            p.PhoneNumber = telefono;
            p.Email = email;
            p.Save();
        }

        public static void Eliminar(int id)
        {
            ModelUser p = new ModelUser(id);
            p.Delete();
        }

        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            ModelUser p = new ModelUser();
            List<ModelUser> personitas = p.GetUserData();

            return tabla;
        }
        public bool credencialesCorrectas;
        public void CallUserVerification()
        {
            ApiAutenitficacion.Autentificador au = new ApiAutenitficacion.Autentificador();
            //if (au.checkData()) credencialesCorrectas = true;
            //else credencialesCorrectas = false;
            Console.Write(credencialesCorrectas);
        }
    }
}

