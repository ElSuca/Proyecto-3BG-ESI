using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using CapaLogica;
using CapaLoogica;
using Newtonsoft.Json;


namespace ApiPublicidad
{
    public class BannerSelector
    {
        public BannerSelector() //a
        {     
        }
        public static Dictionary<string, string> GenerarRespuesta(HttpListenerRequest request) => getAdData(extraerCuerpoDeRequest(request));
        private static string extraerCuerpoDeRequest(HttpListenerRequest request)
        {
            string cuerpo;
            using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                cuerpo = reader.ReadToEnd();
            }
            return cuerpo;
        }
        private static Dictionary<string, string> getAdData(string cuerpo)
        {
            Dictionary<string, string> category = JsonConvert.DeserializeObject<Dictionary<string, string>>(cuerpo);
            Dictionary<string, string> resultadoAutenticacion = new Dictionary<string, string>();
           

            DataTable tabla = new AdControler().GetAdInfo(category["Category"]);
            string[] Ads = tabla.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            Random r = new Random();
            int i = r.Next(Ads.Length);
            string path = Ads[i].ToString();
            resultadoAutenticacion.Add("path", path);
            return resultadoAutenticacion;
        }
    }

}
