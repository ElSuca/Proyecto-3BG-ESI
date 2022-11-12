using CapDeDatos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiPublicidad
{
   public class ApiListener
    {

        static void Main(string[] args) //a
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://127.0.0.1:7777/");
            listener.Start();
            Console.WriteLine("Listening...");
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                Log(request);
                EnviarRespuesta(request, response);
            }

        }
        public ApiListener()
        {
        }

        static string EnviarRespuesta(HttpListenerRequest request, HttpListenerResponse response)
        {
            string body;
            Dictionary<string, string> camposJsonDeSalida = new Dictionary<string, string>();
            camposJsonDeSalida = CheckConection(request, response, camposJsonDeSalida);
            body = JsonConvert.SerializeObject(camposJsonDeSalida);
            response.ContentType = "application/json";
            byte[] buffer = Encoding.UTF8.GetBytes(body);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            SafeSystemBuffer.Response = output.ToString();
            return output.ToString();
        }

        private static Dictionary<string, string> CheckConection(HttpListenerRequest request, HttpListenerResponse response, Dictionary<string, string> camposJsonDeSalida)
        {
            if (request.Url.AbsolutePath != "/Ad" || request.HttpMethod != "POST")
            {
                response.StatusCode = 404;
                camposJsonDeSalida.Add("codigo", "404");
                camposJsonDeSalida.Add("mensaje", "URL no encontrada");
            }
            else camposJsonDeSalida = BannerSelector.GenerarRespuesta(request);
            return camposJsonDeSalida;
        }

        public static void Log(HttpListenerRequest request) => Console.WriteLine(request.RemoteEndPoint + " " + request.HttpMethod + " " + request.RawUrl);
    }
}
