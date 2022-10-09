using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Apis
{
    public class GetRequest
    {
        public GetRequest()
        {

        }

        public void GetWebRequest(string url)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                var res = response.Content.ReadAsStringAsync().Result;
                dynamic r = JObject.Parse(res);
               // ApiAutenitficacion.Autentificador.GenerarRespuesta()
            }
        }
    }
}
