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
            string Url = "http://127.0.0.1:8888/autenticar/";
            ModelUser u = new ModelUser();
            UserControler uc = new UserControler();
            uc.enviar(nombre, password,Url);
            string respuesta = recivir(Url);
            return u.Autenticar(password);
        }
        public void enviar(string nombre, string password, string Url)
        {
            HttpListener listener = new HttpListener();
            WebRequest request = WebRequest.Create(Url);
            listener.Prefixes.Add(Url);
            checklisten(listener);
            HttpListenerContext context = listener.GetContext();
            HttpListenerResponse response = context.Response;

            string body;
            request.Method = "post";
            Dictionary<string, string> camposJsonDeSalida = new Dictionary<string, string>();
            camposJsonDeSalida.Add(nombre, password);

            body = JsonConvert.SerializeObject(camposJsonDeSalida);

            response.ContentType = "application/json";
            byte[] buffer = Encoding.UTF8.GetBytes(body);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
        }
        public static string recivir(string Url)
        {
           
            WebRequest request = WebRequest.Create(Url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd().Trim();

        }

        public void checklisten(HttpListener listener)
        {
            if (listener.IsListening) listener.Stop();
            else listener.Start();
        }
    }
}

