using CapDeDatos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Apis
{
    public class SendRequestResult
    {
        public SendRequestResult()
        {
        }
        public static string GetPost(string url, int pageNumber, int sportId) 
        {
            WebRequest request = WebRequest.Create(url);
            PostResultPageSport u = new PostResultPageSport() { PageNumber = pageNumber, SportId = sportId };

            string result = "";

            request.Method = "POST";
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
            string[] EventId = JsonConvert.DeserializeObject<string[]>(result);
            SafeSystemBuffer.ResponseArray = EventId;
            return result;
        }    
    }
}
