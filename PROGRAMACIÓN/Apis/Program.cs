using API;
using CapaLogica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Apis
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            ApiAutenitficacion.Autentificador a = new ApiAutenitficacion.Autentificador();
            string listenUrl = "http://127.0.0.1:8888/";
            listener.Prefixes.Add(listenUrl);
           // listener.Start();
           // Console.WriteLine("Listening...");
           a.menuprovicional();

           /* while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                Log(request);
                Respuesta r = new Respuesta(request, response);    
                System.IO.Stream output = r.response.OutputStream;
                output.Write(r.buffer, 0, r.buffer.Length);
                output.Close();
            }*/
        }

        static string getData()
        {
            return JsonConvert.SerializeObject(UserControler.ObtenerTodos());
        }


        public static void Log(HttpListenerRequest request)
        {
            Console.WriteLine(request.RemoteEndPoint + " " + request.HttpMethod + " " + request.RawUrl);
        }
    }
}
