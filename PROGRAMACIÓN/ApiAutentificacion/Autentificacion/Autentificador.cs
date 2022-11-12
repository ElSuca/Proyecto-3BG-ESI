using System.Collections.Generic;
using System.IO;
using System.Net;
using CapaLogica;
using Newtonsoft.Json;


namespace ApiAutenitficacion
{
    class Autentificador
    {
        public Autentificador()
        {     
        }
        public static Dictionary<string, string> GenerarRespuesta(HttpListenerRequest request)
        {
            string cuerpo = extraerCuerpoDeRequest(request);
            Dictionary<string, string> respuesta = evaluarCredenciales(cuerpo);
            return respuesta;
        }
        private static string extraerCuerpoDeRequest(HttpListenerRequest request)
        {
            string cuerpo;
            using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                cuerpo = reader.ReadToEnd();
            }
            return cuerpo;
        }

       
        private static Dictionary<string, string> evaluarCredenciales(string cuerpo)
        {
            Dictionary<string, string> credenciales = JsonConvert.DeserializeObject<Dictionary<string, string>>(cuerpo);
            Dictionary<string, string> resultadoAutenticacion = new Dictionary<string, string>();
            if (UserControler.Autenticar(credenciales["usuario"], credenciales["password"]) == true)
            {
                resultadoAutenticacion.Add("codigo", "1");
                resultadoAutenticacion.Add("mensaje", "Credenciales correctas");
            }
            else
            {
                resultadoAutenticacion.Add("codigo", "-1");
                resultadoAutenticacion.Add("mensaje", "Credenciales invalidas");
            }
            return resultadoAutenticacion;
        }
    }

}
