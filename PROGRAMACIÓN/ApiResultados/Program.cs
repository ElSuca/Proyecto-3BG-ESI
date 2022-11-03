using CapDeDatos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiResultados
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPost("http://127.0.0.1:8888/Resultados", "a","a");

            /*
            HttpListener listener = new HttpListener();
            string listenUrl = "http://127.0.0.1:8888/";
            listener.Prefixes.Add(listenUrl);
            listener.Start();
            Console.WriteLine("Listening...");

            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                Log(request);
                EnviarRespuesta(request, response);
            }*/
        }



        static void EnviarRespuesta(HttpListenerRequest request, HttpListenerResponse response)
        {
            Dictionary<string, string> camposJsonDeSalida = new Dictionary<string, string>();
            camposJsonDeSalida = CheckConection(request, response, camposJsonDeSalida);
            response.ContentType = "application/json";
            byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(camposJsonDeSalida));
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
        }

        private static Dictionary<string, string> CheckConection(HttpListenerRequest request, HttpListenerResponse response, Dictionary<string, string> camposJsonDeSalida)
        {
            if (request.Url.AbsolutePath != "/Resultados" || request.HttpMethod != "POST")
            {
                response.StatusCode = 404;
                camposJsonDeSalida.Add("codigo", "404");
                camposJsonDeSalida.Add("mensaje", "URL no encontrada");
            }
            else camposJsonDeSalida = ApiDeResultados.Resultados.GenerarRespuesta(request);
            return camposJsonDeSalida;
        }

        public static void Log(HttpListenerRequest request) => Console.WriteLine(request.RemoteEndPoint + " " + request.HttpMethod + " " + request.RawUrl);

        public static string GetPost(string url, string Username, string Password)
        {
            string result = "";
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            request.ContentType = "application/json;charset=UTF-8";

            using (var m = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"usuario\":\""+Username+"\",\"usuario\":\""+Password+"\"}";
            }
                return result;
        }
    }
}

