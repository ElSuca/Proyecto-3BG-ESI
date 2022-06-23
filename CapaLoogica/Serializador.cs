using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaLoogica
{
    class Serializador
    {
        public HttpListenerResponse response;
        HttpListenerRequest request;

        public byte[] buffer;
        string body;

        public Serializador(HttpListenerRequest request, HttpListenerResponse response)
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
                body = JsonConvert.SerializeObject(us.GetUsername());
            else
            {
                Dictionary<string, string> campos = new Dictionary<string, string>();
                campos.Add("codigo", "-1");
                campos.Add("mensaje", "No encontrado");
                body = JsonConvert.SerializeObject(campos);
                this.response.StatusCode = 404;

            }

        }

        public void CrearRespuesta()
        {
            this.buffer = Encoding.UTF8.GetBytes(this.body);
            this.response.ContentLength64 = this.buffer.Length;
            this.response.ContentType = "application/json";
        }

    }
}
