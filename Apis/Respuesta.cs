using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using CapaLogica;
using Newtonsoft.Json;


namespace API
{
    class Respuesta
    {
        public HttpListenerResponse response;
        HttpListenerRequest request;

        public byte[] buffer;
        string body;
        string Username;
        string Password;

        public Respuesta(HttpListenerRequest request, HttpListenerResponse response)
        {
            this.request = request;
            this.response = response;
            this.CrearCuerpoDeRespuesta();
            this.CrearRespuesta();
        }

        public void CrearCuerpoDeRespuesta()
        {
            UserControler us = new UserControler();
            Console.Write(request.QueryString["usuario"]);

            if (this.request.Url.AbsolutePath == "/listar") 
                body = JsonConvert.SerializeObject(Username + Password);
            else
            {
                Dictionary<string, string> campos = new Dictionary<string, string>();
                //campos.Add("codigo", "-1");
                campos.Add("mensaje", Username +"/"+Password);
                body = JsonConvert.SerializeObject(campos);
                this.response.StatusCode = 404;

            }
                
        }
        public void getName(string Name)
        {
            UserControler us = new UserControler();
            Username = us.ObtenerNombre();
        }
        public void getPassword(string pass)
        {
            UserControler us = new UserControler();
            Password = us.ObtenerContraseña();
        }

        public void CrearRespuesta()
        {
            this.buffer = Encoding.UTF8.GetBytes(this.body);
            this.response.ContentLength64 = this.buffer.Length;
            this.response.ContentType = "application/json";
        }
    }
}
