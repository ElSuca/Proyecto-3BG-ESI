using CapaLogica;
using CapDeDatos;
using System;
using System.IO;

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
        public void SendMails()
        {
            string Correo = "ptahtechnologiesolympus@gmail.com";
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            for(int i = 0; i <= UserControler.GetSubscriptionIndex(); i++)
            mmsg.To.Add(txtMail.Text);
            mmsg.Subject = "Olympus";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = "Hola, este es un mensaje enviado desde el proyecto Olympus";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress(Correo);

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(Correo, "ebsbhhvqesxpleso");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            //try
            //{
                cliente.Send(mmsg);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
