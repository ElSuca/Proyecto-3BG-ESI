using CapDeDatos;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult
{
    public class SendRequestResult
    {

        public SendRequestResult()
        {
        }
        public static string GetPost(string url, int pageNumber, int sportId)
        {
            WebRequest request = WebRequest.Create(url);
            Dictionary<string, string> u = new Dictionary<string, string>();
            u.Add("PagerNumber", pageNumber.ToString());
            u.Add("SportId", sportId.ToString());

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
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(result, (typeof(DataTable)));

            SafeSystemBuffer.ResponseTable = dt;
            Console.Write(e);
            return result;
        }
    }
}
