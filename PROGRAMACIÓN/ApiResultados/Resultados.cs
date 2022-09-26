using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace ApiDeResultados
{
    class Resultados
    {
        public Resultados()
        {     
        }
        public static Dictionary<string, string> GenerarRespuesta(HttpListenerRequest request) => evaluarCredenciales(extraerCuerpoDeRequest(request));
        private static string extraerCuerpoDeRequest(HttpListenerRequest request)
        {
            string cuerpo;
            using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                cuerpo = reader.ReadToEnd();
            }
            return cuerpo;
        }

        private static Dictionary<string,string> evaluarCredenciales(string cuerpo)
        {
            Dictionary<string, string> credenciales = JsonConvert.DeserializeObject<Dictionary<string, string>>(cuerpo);
            Dictionary<string, string> resultadoRequest = new Dictionary<string, string>();
            
                resultadoRequest.Add("Category", credenciales["Category"]);
                resultadoRequest.Add("Page", credenciales["Page"]);
                resultadoRequest.Add("Search", credenciales["Search"]);
            return resultadoRequest;
        }
    }

}
