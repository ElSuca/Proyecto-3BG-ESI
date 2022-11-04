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
    }
}
