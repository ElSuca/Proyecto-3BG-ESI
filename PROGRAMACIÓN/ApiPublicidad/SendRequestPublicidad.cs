using CapDeDatos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Apis
{
    public class SendRequestPublicidad
    {
        public SendRequestPublicidad()
        {
        }
        public static string GetPost(string url, string category) 
        {
            WebRequest request = WebRequest.Create(url);
            Dictionary<string, string> u = new Dictionary<string, string>();
            u.Add("Category",category);
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
            Dictionary<string, string> Path = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            SafeSystemBuffer.Response = Path["path"];
            return result;
        }    
    }
}
