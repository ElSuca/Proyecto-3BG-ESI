using CapDeDatos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Apis
{
    public class SendRequest
    {
        public SendRequest()
        {
        }
        public static string GetPost(string url, string Uname, string Pass) 
        {
            WebRequest request = WebRequest.Create(url);
            PostAut u = new PostAut() { Username = Uname, Password = Pass };

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
            WebResponse response = request.GetResponse();
            using (var l = new StreamReader(response.GetResponseStream()))
            {
                result = l.ReadToEnd().Trim();
            }
            Dictionary<string, string> credenciales = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            SafeSystemBuffer.Response =credenciales["codigo"];
            return result;
        }
    }
}
