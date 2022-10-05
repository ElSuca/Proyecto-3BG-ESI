using CapaDeDatos;
using CapDeDatos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiAurentificacion
{
    public class Web
    {
        static void Main(string[] args)
        {
            string n = "a";
            string p = "a";
            string url = "http://127.0.0.1:8888/autenticar";
             HttpListener listener = new HttpListener();
             listener.Prefixes.Add("http://127.0.0.1:8888/");
             listener.Start();
             Console.WriteLine("Listening...");

            GetPost(url, n, p);
            string result = GetHttp(url);
          /*  while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                Log(request);
                EnviarRespuesta(request, response);
            }*/

        }
        public Web()
        {

        }

        public Web(string Username, string Password) => GetPost("http://127.0.0.1:8888/autenticar", Username, Password);

        static void EnviarRespuesta(HttpListenerRequest request, HttpListenerResponse response)
        {
            string body;
            Dictionary<string, string> camposJsonDeSalida = new Dictionary<string, string>();
            camposJsonDeSalida = CheckConection(request, response, camposJsonDeSalida);
            body = JsonConvert.SerializeObject(camposJsonDeSalida);
            response.ContentType = "application/json";
            byte[] buffer = Encoding.UTF8.GetBytes(body);
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
        }

        private static Dictionary<string, string> CheckConection(HttpListenerRequest request, HttpListenerResponse response, Dictionary<string, string> camposJsonDeSalida)
        {
            if (request.Url.AbsolutePath != "/autenticar" || request.HttpMethod != "POST")
            {
                response.StatusCode = 404;
                camposJsonDeSalida.Add("codigo", "404");
                camposJsonDeSalida.Add("mensaje", "URL no encontrada");
            }
            else camposJsonDeSalida = ApiAutenitficacion.Autentificador.GenerarRespuesta(request);
            return camposJsonDeSalida;
        }

        public static void Log(HttpListenerRequest request)
        {
            Console.WriteLine(request.RemoteEndPoint + " " + request.HttpMethod + " " + request.RawUrl);
        }

        public static void GetPost(string url, string Uname, string Pass)
        {
            WebRequest request = WebRequest.Create(url);
            User u = new User(){Username=Uname,Password=Pass};

            string result = "";
            
            request.Method = "post";
            request.ContentType = "application/json;charset=UTF-8";

            using (var m = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(u, Formatting.Indented);
                m.Write(json);
                m.Flush();
                m.Close();
            }
          /*  WebResponse response = request.GetResponse();
            using (var l = new StreamReader(response.GetResponseStream()))
            {
                result = l.ReadToEnd().Trim();
            }*/
          //  return result;
        }
        public static string GetHttp(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd().Trim();
        }

    }
}
