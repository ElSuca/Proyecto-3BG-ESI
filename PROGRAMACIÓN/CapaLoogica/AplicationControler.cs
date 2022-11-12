using CapaLogica;
using CapDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace CapaLoogica
{
    public class AplicationControler
    {
        private int _language;
        public int Language
        { 
            get { return _language = getLanguage(); }
            set { _language = value; SafeSystemBuffer.Language = value; }
        }
        public string getResponse() => SafeSystemBuffer.Response;
        public string SetResponse(string v) => SafeSystemBuffer.Response = v;
        public DataTable getResponseTable() => SafeSystemBuffer.ResponseTable;
        public DataTable SetResponseTable(DataTable v) => SafeSystemBuffer.ResponseTable = v;
        private int getLanguage()
        {
            int selection;
            using (StreamReader archivo = File.OpenText("..\\..\\..\\Config.txt"))
            {
                string linea = null;
                int i = 0;
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    if (++i == 2) break;
                }
                selection = Int32.Parse(linea[11].ToString());
            }
            return selection;
        }
        public void SendMails(string Name, int id)
        {
            string Correo = "ptahtechnologiesolympus@gmail.com";
            DataTable tabla = new DataTable();
            tabla = new UserControler().getSubscriptionIndex(id);
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();    
            List<string> list = tabla.AsEnumerable().Select(r => r.Field<string>("EMAIL")).ToList();

            foreach (var mail in list)
            {
                mmsg.To.Add(mail);
                mmsg.Subject = "Olympus";
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                mmsg.Body = $"The event {Name} was published, come see it";
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress(Correo);

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential(Correo, "ebsbhhvqesxpleso");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                try
                {
                    cliente.Send(mmsg);
                    mmsg.To.RemoveAt(0);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
